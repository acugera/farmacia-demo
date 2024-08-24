using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPIntegrador
{
    public partial class frmConsultarNP : Form
    {
        BDHelper oDatos = BDHelper.getBDHelper();
        Funciones_Auxiliares aux = new Funciones_Auxiliares();
        string consulta = string.Empty;
        public frmConsultarNP()
        {
            InitializeComponent();
        }

        private void frmConsultarNP_Load(object sender, EventArgs e)
        {
            aux.cargar_combo(cmbLaboratorio, "Laboratorio", oDatos);
            aux.cargar_combo(cmbMedicamento, "Medicamento", oDatos);
            cmbMedicamento.SelectedValue = -1;
            cmbLaboratorio.SelectedValue = -1;
            cmbFecha.Text = "Ascendente";
            cmbCantidad.Text = "Ascendente";
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            
            if (cmbMedicamento.Text == string.Empty && cmbLaboratorio.Text == string.Empty)
            {
                consulta = "select n.id_NotaPedido, l.nombre, m.nombre as 'med', d.cantidad, n.fechaPedido from DetallePedido d JOIN NotaPedido n ON d.id_NotaPedido=n.id_notaPedido JOIN Medicamento m ON d.id_medcamento=m.id_medicamento JOIN Laboratorio l ON n.id_laboratorio=l.id_laboratorio";
            }
            if (cmbMedicamento.Text!= string.Empty)
            {
                consulta = "select n.id_NotaPedido, l.nombre, m.nombre as 'med', d.cantidad, n.fechaPedido from DetallePedido d JOIN NotaPedido n ON d.id_NotaPedido=n.id_notaPedido JOIN Medicamento m ON d.id_medcamento=m.id_medicamento JOIN Laboratorio l ON n.id_laboratorio=l.id_laboratorio"
                    + " where m.nombre = '"+ cmbMedicamento.Text+"'";
            }
            if (cmbLaboratorio.Text != string.Empty)
            {
                consulta = "select n.id_NotaPedido, l.nombre, m.nombre as 'med', d.cantidad, n.fechaPedido from DetallePedido d JOIN NotaPedido n ON d.id_NotaPedido=n.id_notaPedido JOIN Medicamento m ON d.id_medcamento=m.id_medicamento JOIN Laboratorio l ON n.id_laboratorio=l.id_laboratorio"
                    + " where n.id_laboratorio=" + cmbLaboratorio.SelectedValue;
            }
            if (cmbMedicamento.Text != string.Empty && cmbLaboratorio.Text != string.Empty)
            {
                consulta = "select n.id_NotaPedido, l.nombre, m.nombre as 'med', d.cantidad, n.fechaPedido from DetallePedido d JOIN NotaPedido n ON d.id_NotaPedido=n.id_notaPedido JOIN Medicamento m ON d.id_medcamento=m.id_medicamento JOIN Laboratorio l ON n.id_laboratorio=l.id_laboratorio"
                    + " where n.id_laboratorio=" + cmbLaboratorio.SelectedValue + " AND d.id_medcamento=" + cmbMedicamento.SelectedValue;
            }
            if (cmbFecha.Text == "Ascendente")
            {
                consulta += " order by n.fechaPedido ASC";
            }
            if (cmbFecha.Text == "Descendente")
            {
                consulta += " order by n.fechaPedido DESC";
            }
            if (cmbCantidad.Text == "Ascendente")
            {
                consulta += ", d.cantidad ASC";
            }
            if (cmbCantidad.Text == "Descendente")
            {
                consulta += ", d.cantidad DESC";
            }
            DataTable tabla = new DataTable();
            tabla = oDatos.consultarSQL(consulta);
            cargarGrilla(tabla);
            btnReporte.Enabled = true;
        }
        private void cargarGrilla(DataTable tabla)
        {
            dgvListado.Rows.Clear();
             if (tabla.Rows.Count > 0)
            {
                for (int i = 0; i < tabla.Rows.Count; i++)
                {
                    dgvListado.Rows.Add(tabla.Rows[i]["id_NotaPedido"],
                                    tabla.Rows[i]["nombre"],
                                    tabla.Rows[i]["med"],
                                    tabla.Rows[i]["cantidad"],
                                    tabla.Rows[i]["fechaPedido"]);
                }
            }
            else
                MessageBox.Show("No se ecnontraron NP", "Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
           frmReporteNP fm = new frmReporteNP();
           fm.consulta = consulta;
           fm.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        }
    }

