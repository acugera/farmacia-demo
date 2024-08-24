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
    public partial class frmClienteObraSocial : Form
    {
        BDHelper oDatos = BDHelper.getBDHelper();
        Funciones_Auxiliares aux = new Funciones_Auxiliares();
        string op = string.Empty;
        string obra = string.Empty;
        string client = string.Empty;
        bool ban = true;
        public frmClienteObraSocial(string opc, string id_ObraS, string id_Client)
        {
            InitializeComponent();
            op = opc;
            obra = id_ObraS;
            client = id_Client;
        }

        private void txtNroObraA_TextChanged(object sender, EventArgs e)
        {
            if (txtNroObraA.TextLength == txtNroObraA.MaxLength)
            {
                txtNroObraB.Focus();
            }
        }

        private void txtNroObraB_TextChanged(object sender, EventArgs e)
        {
            if (txtNroObraB.TextLength == txtNroObraB.MaxLength)
            {
                txtNroObraC.Focus();
            }
        }

        private void txtNroObraC_TextChanged(object sender, EventArgs e)
        {
            if (txtNroObraC.TextLength == txtNroObraC.MaxLength)
            {
                txtNroObraD.Focus();
            }
        }

        private void txtNroObraA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (aux.numberVal(e.KeyChar) == false)
                e.Handled = true;
        }

        private void txtNroObraB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (aux.numberVal(e.KeyChar) == false)
                e.Handled = true;
            if (txtNroObraB.Text == string.Empty && Convert.ToInt32(e.KeyChar) == 8)
            {
                txtNroObraA.Focus();
            }
        }

        private void txtNroObraC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (aux.numberVal(e.KeyChar) == false)
                e.Handled = true;
            if (txtNroObraC.Text == string.Empty && Convert.ToInt32(e.KeyChar) == 8)
            {
                txtNroObraB.Focus();
            }
        }

        private void txtNroObraD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (aux.numberVal(e.KeyChar) == false)
                e.Handled = true;
            if (txtNroObraD.Text == string.Empty && Convert.ToInt32(e.KeyChar) == 8)
            {
                txtNroObraC.Focus();
            }
        }
        private Array destruirNro(string cuit)
        {
            int num = 0;
            string str1 = string.Empty;
            string str2 = string.Empty;
            string str3 = string.Empty;
            string str4 = string.Empty;
            foreach (char i in cuit)
            {
                string w = i.ToString();
                if (num < 1)
                {
                    str1 += w;
                }
                if (num > 1 && num < 10)
                {
                    str2 += w;
                }
                if (num > 10 && num < 13)
                {
                    str3 += w;
                }
                if (num > 13)
                {
                    str4 += w;
                }
                num += 1;
            }
            string[] srt = new string[] { str1, str2, str3, str4 };
            return srt;
        }

        private void cargarNro(Array str)
        {
            int num = 0;
            foreach (string i in str)
            {
                if (num == 0)
                    txtNroObraA.Text = i;
                if (num == 1)
                    txtNroObraB.Text = i;
                if (num == 2)
                    txtNroObraC.Text = i;
                if (num == 3)
                    txtNroObraD.Text = i;
                num += 1;
            }
        }
        public void cargar_typoObra(ComboBox cmbTipoObra)
        {
            string consulta = "SELECT id_obraSocial, nombre + ' - ' + tipo AS nombrecompeto FROM ObraSocial WHERE id_estado=1";
            DataTable tabla = oDatos.consultarSQL(consulta);
            cmbTipoObra.DataSource = tabla;
            cmbTipoObra.DisplayMember = tabla.Columns[1].ColumnName;
            cmbTipoObra.ValueMember = tabla.Columns[0].ColumnName.ToString();
        }

        private void frmClienteObraSocial_Load(object sender, EventArgs e)
        {
            cargar_typoObra(cmbTipoObra);
            if (op=="2")
            {
                this.Text = "Modificar Obra Social";
                string consulta = "select * from ClienteObrasSociales where id_cliente = "+client+" and id_obraSocial = "+obra;
                DataTable tabla = oDatos.consultarSQL(consulta);
                Array num = destruirNro(tabla.Rows[0].ItemArray[2].ToString());
                cargarNro(num);
                cmbTipoObra.SelectedValue = tabla.Rows[0].ItemArray[1].ToString();
                cmbTipoObra.Enabled = false;
            }
            else if (op=="1")
                this.Text = "Agregar Obra Social";
            else if (op=="3")
            {
                ban = false;
                string eliminar = "UPDATE ClienteObrasSociales set id_estado = 2 WHERE id_cliente = " + client + " and id_obraSocial = " + obra;
                oDatos.actualizarBD(eliminar);
                this.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmClienteObraSocial_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (ban)
            {
                if (MessageBox.Show("¿Seguro que desea salir, los datos no guardados no se conservarán?", "¿Salir?",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    e.Cancel = false;
                else
                    e.Cancel = true;
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            bool done = false;
            if (op == "1" && txtNroObraA.Text != string.Empty && txtNroObraB.Text != string.Empty && txtNroObraC.Text != string.Empty && txtNroObraD.Text != string.Empty && comprobarUsario(client, cmbTipoObra.SelectedValue.ToString()))
            {
                string insertar = "insert into ClienteObrasSociales (id_cliente, id_obraSocial, nroObraSocial, id_estado) values ("
                                             + "'" + client + "',"
                                             + cmbTipoObra.SelectedValue.ToString() + ","
                                             + "'" + txtNroObraA.Text + "-" + txtNroObraB.Text + "-" + txtNroObraC.Text + "/" + txtNroObraD.Text + "',"
                                             + "1)";
                oDatos.actualizarBD(insertar);
                done = true;
            }
            else if (op == "2" && txtNroObraA.Text != string.Empty && txtNroObraB.Text != string.Empty && txtNroObraC.Text != string.Empty && txtNroObraD.Text != string.Empty)
            {
                string update = "UPDATE ClienteObrasSociales set nroObraSocial = '" + txtNroObraA.Text + "-" + txtNroObraB.Text + "-" + txtNroObraC.Text + "/" + txtNroObraD.Text +
                                            "' WHERE id_estado = 1 and id_cliente = " + client + " and id_obraSocial = " + obra;
                oDatos.actualizarBD(update);
                done = true;
            }
            else if (op=="1")
                MessageBox.Show("El cliente ya posee esa Obra social, o se a dejado algun campo obligatorio vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (op == "2")
                MessageBox.Show("Se a dejado algun campo obligatorio vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            if (done)
            {
                ban = false;
                this.Close();
                MessageBox.Show("Obra Social agregada o modificado con exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }
        private bool comprobarUsario(string id_cli, string id_obra)
        {
            string consular = "select * from ClienteObrasSociales where id_Estado = 1 and id_cliente = " + id_cli + " and id_obraSocial = " + id_obra;
            DataTable tabla = oDatos.consultarSQL(consular);
            if (tabla.Rows.Count != 0)
                return false;
            else
                return true;
        }
    }
}
