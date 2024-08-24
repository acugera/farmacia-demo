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

    public partial class frmLogin : Form
    {
        BDHelper oDatos = BDHelper.getBDHelper();
        bool flag = false;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text==string.Empty || txtContrasenia.Text==string.Empty)
            {
                MessageBox.Show("Complete todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string consulta = "select * from Empleado where usuario LIKE '" + txtUsuario.Text + "' AND contraseña LIKE '" + txtContrasenia.Text + "' AND estado = 1";
                DataTable tabla = oDatos.consultarSQL(consulta);
                if (tabla.Rows.Count == 1)
                {
                    flag = true;
                    this.Hide();
                    frmPrincipal fp = new frmPrincipal(tabla.Rows[0].ItemArray[0].ToString());
                    fp.Show();
                }
                else
                {
                    MessageBox.Show("Usuario y/o Contraseña incorrecto.","Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
                    txtContrasenia.Text = string.Empty;
                    txtUsuario.Text = string.Empty;
                    txtUsuario.Focus();
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (flag == false)
            {
                if (MessageBox.Show("¿Seguro que desea salir?", "¿Salir?",
                                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    e.Cancel = false;
                else
                    e.Cancel = true;
            }
        }
    }
}
