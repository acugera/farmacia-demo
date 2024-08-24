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
    public partial class frmConsultarVentas : Form
    {
        BDHelper oDatos = BDHelper.getBDHelper();
        string consulta = string.Empty;
        public frmConsultarVentas()
        {
            InitializeComponent();
        }

        private void frmConsultarVentas_Load(object sender, EventArgs e)
        {
            cmbFech.Text = "Ascendente";
            cmbPre.Text = "Ascendente";
            tmrAux.Start();
        }

        private void btnLISTAR_Click(object sender, EventArgs e)
        {
            consulta = "select v.id_venta, e.nombre + ' ' + e.apellido as 'empleado', c.nombre + ' ' + c.apellido as 'cliente', v.total_venta, v.tipoFactura, v.fecha_venta from Venta v JOIN Empleado e ON v.id_empleado = e.id_empleado JOIN Cliente c ON v.id_cliente = c.id_cliente where 1=1";
            if (cmbTipoF.Text!=string.Empty)
            {
                consulta += " and tipoFactura='"+cmbTipoF.Text+"'";
            }
            if (txtMin.Text != string.Empty)
            {
                consulta += " AND v.total_venta > " + txtMin.Text;
            }
            if (txtMax.Text != string.Empty)
            {
                consulta += " AND v.total_venta <" +  txtMax.Text;
            }
            if (cmbFech.Text == "Ascendente")
            {
                consulta += " order by v.fecha_venta ASC";
            }
            if (cmbFech.Text == "Descendente")
            {
                consulta += " order by v.fecha_venta DESC";
            }
            if (cmbPre.Text == "Ascendente")
            {
                consulta += ", v.total_venta ASC";
            }
            if (cmbPre.Text == "Descendente")
            {
                consulta += ", v.total_venta DESC";
            }
            DataTable tabla = new DataTable();
            tabla = oDatos.consultarSQL(consulta);
            cargarGrilla(tabla);
        }
        private void cargarGrilla(DataTable tabla)
        {
            dgvVentas.Rows.Clear();
            if (tabla.Rows.Count > 0)
            {
                for (int i = 0; i < tabla.Rows.Count; i++)
                {
                    dgvVentas.Rows.Add(tabla.Rows[i]["id_venta"],
                                    tabla.Rows[i]["empleado"],
                                    tabla.Rows[i]["cliente"],
                                    tabla.Rows[i]["total_venta"],
                                    tabla.Rows[i]["tipoFactura"],
                                    tabla.Rows[i]["fecha_venta"]);
                }
            }
            else
                MessageBox.Show("No se ecnontraron Ventas", "Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnREPORTE_Click(object sender, EventArgs e)
        {
            frmReporteVentas fm = new frmReporteVentas();
            fm.consulta = consulta;
            fm.ShowDialog();
        }

        private void tmrAux_Tick(object sender, EventArgs e)
        {
            if (consulta != string.Empty)
            {
                btnREPORTE.Enabled = true;
            }
            else
            {
                btnREPORTE.Enabled = false;
            }
        }

        private void btnSALIR_Click(object sender, EventArgs e)
        {
            tmrAux.Stop();
            this.Close();
        }

       

        

       

       
    }
}
