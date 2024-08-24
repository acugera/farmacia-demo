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
    public partial class frmConsultaMedicamento : Form
    {
        BDHelper oDatos = new BDHelper();
        enum conReceta
        {
            conReceta, sinReceta
        }
        public frmConsultaMedicamento()
        {
            InitializeComponent();
        }

        private void frmConsultaMedicamento_Load(object sender, EventArgs e)
        {
            cmbMedicamento.SelectedItem = "Todos";

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvMedicamento.Rows.Clear();
            string consulta = string.Empty;
            if(cmbMedicamento.SelectedItem == "Nombre")
            {
                consulta = "select m.nombre, m.droga, l.nombre as 'laboratorio', m.receta, m.precio, m.stock_real from "
                            + " Medicamento m JOIN Laboratorio l ON m.id_laboratorio = l.id_laboratorio where m.id_estado = 1 AND m.nombre = '" + txtBusqueda.Text + "'";
            }
            if (cmbMedicamento.SelectedItem == "Droga")
            {
                consulta = "select m.nombre, m.droga, l.nombre as 'laboratorio', m.receta, m.precio, m.stock_real from "
                            + " Medicamento m JOIN Laboratorio l ON m.id_laboratorio = l.id_laboratorio where m.id_estado = 1 AND m.droga = '" + txtBusqueda.Text +"'";
            }
            if (cmbMedicamento.SelectedItem == "Laboratorio")
            {
                consulta = "select m.nombre, m.droga, l.nombre as 'laboratorio', m.receta, m.precio, m.stock_real from "
                            + " Medicamento m JOIN Laboratorio l ON m.id_laboratorio = l.id_laboratorio where m.id_estado = 1 AND l.nombre = '" + txtBusqueda.Text + "'";
            }
            if (cmbMedicamento.SelectedItem == "Todos")
            {
                consulta = "select m.nombre, m.droga, l.nombre as 'laboratorio', m.receta, m.precio, m.stock_real from "
                            + " Medicamento m JOIN Laboratorio l ON m.id_laboratorio = l.id_laboratorio where m.id_estado = 1";
            }
            if (chkReceta.Checked == true)
                consulta += " AND m.receta LIKE 'true'";
            else
                consulta += " AND m.receta LIKE 'false'";
            DataTable tabla = oDatos.consultarSQL(consulta);
            if (tabla.Rows.Count > 0)
            {
                for (int i = 0; i < tabla.Rows.Count; i++)
                {
                    dgvMedicamento.Rows.Add(tabla.Rows[i]["nombre"],
                                    tabla.Rows[i]["droga"],
                                    tabla.Rows[i]["laboratorio"],
                                    tabla.Rows[i]["receta"],
                                    tabla.Rows[i]["precio"],
                                    tabla.Rows[i]["stock_real"]);
                }
            }
            else
                MessageBox.Show("No se ecnontraron Medicamentos", "Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void frmConsultaMedicamento_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea salir?", "¿Salir?",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                e.Cancel = false;
            else
                e.Cancel = true;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
