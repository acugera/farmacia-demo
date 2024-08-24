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
    public partial class frmABM_Lab : Form
    {
        int op = 2;
        string id = string.Empty;
        BDHelper oDatos = BDHelper.getBDHelper();
        Funciones_Auxiliares aux = new Funciones_Auxiliares();
        bool ban = true;
        public frmABM_Lab()
        {
            InitializeComponent();
        }

        private void radCrear_CheckedChanged(object sender, EventArgs e)
        {
            this.Text = "Crear Laboratorio";
            txtNombre.Enabled = true;
            txtCuitC.Enabled = true;
            txtCuitB.Enabled = true;
            txtCuitA.Enabled = true;
            txtTelefono.Enabled = true;
            btnConfirmar.Text = "Crear";
            btnConfirmar.Height = 27;
            btnCancelar.Visible = true;
            lstLab.Enabled = false;
            limpieza();
            op = 1;
            txtNombre.Focus();
        }

        private void radModificar_CheckedChanged(object sender, EventArgs e)
        {
            this.Text = "Modificar Laboratorio";
            txtNombre.Enabled = true;
            txtCuitC.Enabled = true;
            txtCuitB.Enabled = true;
            txtCuitA.Enabled = true;
            txtTelefono.Enabled = true;
            btnConfirmar.Text = "Guardar";
            btnConfirmar.Height = 27;
            btnCancelar.Visible = true;
            lstLab.Enabled = true;
            op = 2;
            lstLab.Focus();
            
        }

        private void radEliminar_CheckedChanged(object sender, EventArgs e)
        {
            this.Text = "Eliminar Laboratorio";
            txtNombre.Enabled = false;
            txtCuitC.Enabled = false;
            txtCuitB.Enabled = false;
            txtCuitA.Enabled = false;
            txtTelefono.Enabled = false;
            btnConfirmar.Text = "Eliminar";
            btnConfirmar.Height = 61;
            btnCancelar.Visible = false;
            lstLab.Enabled = true;
            op = 3;
            lstLab.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea cancelar, los datos no guardados no se conservarán?", "¿Cancelar?",
                                  MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                limpieza();
                lstLab.Focus();
            }
            
        }
        private void limpieza()
        {
            txtNombre.Text = string.Empty;
            txtCuitC.Text = string.Empty;
            txtCuitB.Text = string.Empty;
            txtCuitA.Text = string.Empty;
            txtTelefono.Text = string.Empty;
            id = string.Empty; 
        }


        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmABM_Lab_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea salir, los datos no guardados no se conservarán?", "¿Salir?",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                e.Cancel = false;
            else
                e.Cancel = true;
        }

        private void txtCuitA_TextChanged(object sender, EventArgs e)
        {
            if (txtCuitA.TextLength == txtCuitA.MaxLength)
            {
                txtCuitB.Focus();
            }
        }

        private void txtCuitB_TextChanged(object sender, EventArgs e)
        {
            if (txtCuitB.TextLength == txtCuitB.MaxLength)
            {
                txtCuitC.Focus();
            }
        }

        private void txtCuitA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (aux.numberVal(e.KeyChar) == false)
                e.Handled = true;
            if (txtCuitC.Text == string.Empty && Convert.ToInt32(e.KeyChar) == 8)
            {
                txtCuitB.Focus();
            }
        }

        private void txtCuitB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (aux.numberVal(e.KeyChar) == false)
                e.Handled = true;
            if (txtCuitB.Text == string.Empty &&  Convert.ToInt32(e.KeyChar) == 8)
            {
                txtCuitA.Focus();
            }
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (aux.numberVal(e.KeyChar) == false)
                e.Handled = true;
            
        }

        private void txtCuitC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (aux.numberVal(e.KeyChar) == false)
                e.Handled = true;
            
        }

        private void frmABM_Lab_Load(object sender, EventArgs e)
        { 
            radModificar.Checked = true;
            actualizarLst();
            lstLab.Focus();
            timBotones.Start();
            
            
        }

        private void lstLab_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ban)
            {
                actualizarLst();
                ban = false;
            }

            id = lstLab.SelectedValue.ToString();
            string consulta = "SELECT nombre, cuit, telefono FROM Laboratorio where id_laboratorio = "+id;
            DataTable tabla = oDatos.consultarSQL(consulta);
            txtNombre.Text = tabla.Rows[0].ItemArray[0].ToString();
            Array cuit = destruirCuit(tabla.Rows[0].ItemArray[1].ToString());
            cargarCuil(cuit);
            txtTelefono.Text = tabla.Rows[0].ItemArray[2].ToString();
            txtNombre.Focus();
        }

        private Array destruirCuit(string cuit)
        {
            int num = 0;
            string str1 = string.Empty;
            string str2 = string.Empty;
            string str3 = string.Empty;
            foreach (char i in cuit)
            {
               string  w = i.ToString();
                if (num<2)
                {
                    str1 += w;
                }
                if (num > 2 && num < 11)
                {
                    str2 += w;
                }
                if (num > 11)
                {
                    str3 += w;
                }
                num += 1;
            }
            string[] srt = new string[] { str1, str2, str3 };
            return srt ;
        }

        private void cargarCuil(Array str)
        {
            int num = 0;
            foreach (string i in str)
            {
                if (num == 0)
                    txtCuitA.Text = i;
                if (num == 1)
                    txtCuitB.Text = i;
                if (num == 2)
                    txtCuitC.Text = i;
                num += 1;
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (op == 1 && txtNombre.Text != string.Empty && txtCuitA.Text != string.Empty && txtCuitB.Text != string.Empty && txtCuitC.Text != string.Empty && id == string.Empty && txtTelefono.Text==string.Empty)
            {
                if (validarLab(txtNombre.Text) == true)
                {
                    string insertar = "insert into Laboratorio (nombre, cuit, telefono, id_estado) values ("
                                            + "'" + txtNombre.Text + "',"
                                            + "'" + txtCuitA.Text + "-" + txtCuitB.Text + "-" + txtCuitC.Text + "',"
                                            + "null,"
                                            + "1)";
                    oDatos.actualizarBD(insertar);
                    actualizarLst();
                    limpieza();
                    MessageBox.Show("Laboratorio guardado correctamente.", "Laboratorio Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Ese Laboratiro ya Existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (op == 1 && txtNombre.Text != string.Empty && txtCuitA.Text != string.Empty && txtCuitB.Text != string.Empty && txtCuitC.Text != string.Empty && id == string.Empty)
            {
                if (validarLab(txtNombre.Text) == true)
                {
                    string insertar = "insert into Laboratorio (nombre, cuit, telefono, id_estado) values ("
                                            + "'" + txtNombre.Text + "',"
                                            + "'" + txtCuitA.Text + "-" + txtCuitB.Text + "-" + txtCuitC.Text + "',"
                                            + "'" + txtTelefono.Text + "',"
                                            + "1)";
                    oDatos.actualizarBD(insertar);
                    actualizarLst();
                    limpieza();
                    MessageBox.Show("Laboratorio guardado correctamente.", "Laboratorio Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Ese Laboratiro ya Existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            else if (op == 2 && txtNombre.Text != string.Empty && txtCuitA.Text != string.Empty && txtCuitB.Text != string.Empty && txtCuitC.Text != string.Empty && id != string.Empty)
            {
                if (validarLab(txtNombre.Text) == true && txtTelefono.Text==string.Empty)
                {
                    string update = "UPDATE Laboratorio set nombre = '" + txtNombre.Text +
                                            "', cuit = '"+ txtCuitA.Text + "-" + txtCuitB.Text + "-" + txtCuitC.Text +
                                            "', telefono = NULL"+
                                            " WHERE id_laboratorio = " + id;
                    oDatos.actualizarBD(update);
                    actualizarLst();
                    limpieza();
                    MessageBox.Show("Laboratorio modificado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
                else if (validarLab(txtNombre.Text) == true)
                {
                    string update = "UPDATE Laboratorio set nombre = '" + txtNombre.Text +
                                            "', cuit = '" + txtCuitA.Text + "-" + txtCuitB.Text + "-" + txtCuitC.Text +
                                            "', telefono = '" + txtTelefono.Text +
                                            "' WHERE id_laboratorio = " + id;
                    oDatos.actualizarBD(update);
                    actualizarLst();
                    limpieza();
                    MessageBox.Show("Laboratorio modificado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Ese Laboratiro ya Existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (op == 3 && id != string.Empty)
            {
                if(MessageBox.Show("¿Está seguro que desea eliminar este Laboratorio?", "Advertencia", MessageBoxButtons.YesNo,MessageBoxIcon.Warning)== System.Windows.Forms.DialogResult.Yes)
                {
                    string eliminar = "UPDATE Laboratorio set id_estado = 2 WHERE id_laboratorio = " + id;
                    oDatos.actualizarBD(eliminar);
                    actualizarLst();
                    limpieza();
                }
                
            }
            else
                MessageBox.Show("Debe completar los campos obligatorios y/o seleccionar un Laboratorio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            txtNombre.Focus();
        }
        private bool validarLab(string lab)
        {
            if (op == 1)
            {
                DataTable tablaVali = oDatos.consultarSQL("SELECT * from Laboratorio WHERE nombre LIKE '" + lab + "'");
                if (tablaVali.Rows.Count == 0)
                    return true;
                else
                    return false;
            }
            else if (op == 2)
            {
                DataTable tablaVali = oDatos.consultarSQL("SELECT id_laboratorio from Laboratorio WHERE nombre LIKE '" + lab + "'");
                if (tablaVali.Rows.Count == 0)
                    return true;
                else if (tablaVali.Rows[0].ItemArray[0].ToString() == id)
                    return true;
                else
                    return false;
            }
            else
                return false;
        }
        
        private void actualizarLst ()
        {
            string consulta = "SELECT id_laboratorio, nombre from Laboratorio WHERE id_estado=1";
            DataTable tabla = oDatos.consultarSQL(consulta);
            lstLab.DataSource = tabla;
            lstLab.DisplayMember = tabla.Columns[1].ColumnName;
            lstLab.ValueMember = tabla.Columns[0].ColumnName.ToString();
        }

        private void timBotones_Tick(object sender, EventArgs e)
        {
            if (id == string.Empty && op != 1)
            {
                btnConfirmar.Enabled = false;
                btnCancelar.Enabled = false;
            }
            else
            {
                btnConfirmar.Enabled = true;
                btnCancelar.Enabled = true;
            }
        }


    }

        
 }
