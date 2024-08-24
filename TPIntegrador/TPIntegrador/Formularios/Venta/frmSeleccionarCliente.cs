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
    public partial class frmSeleccionarCliente : Form
    {
        Funciones_Auxiliares aux = new Funciones_Auxiliares();
        BDHelper oDatos = BDHelper.getBDHelper();
        string ids = string.Empty;
        bool salir = false;
        public frmSeleccionarCliente()
        {
            InitializeComponent();
        }
        public string iniciarFrm()
        {
            this.ShowDialog();
            return ids;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            ids = lstClientes.SelectedValue.ToString();
            salir = true;
            this.Close();
        }

        private void frmSeleccionarCliente_Load(object sender, EventArgs e)
        {
            string consulta = "select id_cliente, apellido + ' ' + nombre as 'nombreCompleto' from Cliente where id_estado=1";
            DataTable tabla = oDatos.consultarSQL(consulta);
            lstClientes.DataSource = tabla;
            lstClientes.DisplayMember = tabla.Columns[1].ColumnName;
            lstClientes.ValueMember = tabla.Columns[0].ColumnName.ToString();
        }

        private void frmSeleccionarCliente_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (salir == false)
            {
                if (MessageBox.Show("¿Seguro que desea salir? Se perderán los datos.", "¿Salir?",
                                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    e.Cancel = false;
                else
                {
                    ids = string.Empty;
                    e.Cancel = true;         
                }
            }
        }
    }
}
