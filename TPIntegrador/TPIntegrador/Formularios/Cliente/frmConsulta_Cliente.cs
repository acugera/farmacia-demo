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
    public partial class frmConsulta_Cliente : Form
    {
        BDHelper oDatos = BDHelper.getBDHelper();
        Funciones_Auxiliares aux = new Funciones_Auxiliares();
        bool evento = false;
        string id = string.Empty;
        string nombre = string.Empty;
        public frmConsulta_Cliente()
        {
            InitializeComponent();
        }

       

        private void btnBusc_Click(object sender, EventArgs e)
        {
            dgvLIST.Rows.Clear();
            string consulta = "select id_cliente, nombre, apellido from cliente where id_estado=1";

            if (txtBus.Text != string.Empty && cmbTip.Text=="Apellido")
            {
                consulta = "select id_cliente, nombre, apellido from cliente where id_estado=1 and apellido='" + txtBus.Text+"'";
            }
            if (txtBus.Text != string.Empty && cmbTip.Text == "Nombre")
            {
                consulta = "select id_cliente, nombre, apellido from cliente where id_estado=1 and nombre='" + txtBus.Text+"'";
            }

            DataTable tabla = oDatos.consultarSQL(consulta);
            if (tabla.Rows.Count != 0)
            { 
                for (int i = 0; i < tabla.Rows.Count; i++)
                {
                    dgvLIST.Rows.Add(tabla.Rows[i]["id_cliente"],
                                tabla.Rows[i]["nombre"],
                                tabla.Rows[i]["apellido"]);
                }
            }
            
            
        }

        private void frmConsulta_Cliente_Load(object sender, EventArgs e)
        {
            cmbTip.SelectedIndex = -1;
        }

        private void dgvLIST_SelectionChanged(object sender, EventArgs e)
        {
            id=dgvLIST.CurrentRow.Cells[0].Value.ToString();
            nombre = dgvLIST.CurrentRow.Cells[1].Value.ToString() + " " + dgvLIST.CurrentRow.Cells[2].Value.ToString();
            btnDet.Enabled = true;
        }

        private void btnDet_Click(object sender, EventArgs e)
        {
            frmDetalleCliente fr = new frmDetalleCliente();
            fr.id=id;
            fr.nombre = nombre;
            fr.ShowDialog();
        }

        private void frmConsulta_Cliente_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea salir de la consulta de Clientes?", "¿Salir?",
                              MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                e.Cancel = false;
            else
                e.Cancel = true;
        }

        
    }
}
