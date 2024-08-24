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
    public partial class frmActualizarStock : Form
    {
        BDHelper oDatos = BDHelper.getBDHelper();
        string id = string.Empty;
        DataTable tabla = new DataTable();
        public frmActualizarStock()
        {
            InitializeComponent();
        }

        private void frmActualizarStock_Load(object sender, EventArgs e)
        {
            string consulta = "select c.id_medicamento, c.nombre, o.nombre as lab, c.stock_real from Medicamento c JOIN Laboratorio o ON o.id_laboratorio = c.id_laboratorio";
            tabla = oDatos.consultarSQL(consulta);
            if (tabla.Rows.Count != 0)
            {
                for (int i = 0; i < tabla.Rows.Count; i++)
                {
                    dgvStock.Rows.Add(tabla.Rows[i]["id_medicamento"],
                                tabla.Rows[i]["nombre"],
                                tabla.Rows[i]["lab"],
                                tabla.Rows[i]["stock_real"]);
                }
            }
        }

        private void dgvStock_SelectionChanged(object sender, EventArgs e)
        {
            id=dgvStock.CurrentRow.Cells[0].Value.ToString();
            txtStock.Text = dgvStock.CurrentRow.Cells[3].Value.ToString();
            numStock.Value =Int32.Parse(txtStock.Text);
            btnConfirmar.Enabled = true;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            string actualizar = "Update Medicamento set stock_real = " + numStock.Value.ToString() + " where id_medicamento = " + id;
            oDatos.actualizarBD(actualizar);
            MessageBox.Show("Stock Actualizado.", "Stock Actualizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void frmActualizarStock_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea salir, los datos no guardados no se conservarán?", "¿Salir?",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                e.Cancel = false;
            else
                e.Cancel = true;
        }
    }
}
