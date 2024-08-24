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
    public partial class frmABM_Cliente : Form
    {
        int op = 2;
        string id = string.Empty;
        BDHelper oDatos = BDHelper.getBDHelper();
        Funciones_Auxiliares aux = new Funciones_Auxiliares();
        bool ban = true;
        public frmABM_Cliente()
        {
            InitializeComponent();
        }

        private void radCrear_CheckedChanged(object sender, EventArgs e)
        {
            lstObra.Enabled = false;
            btnAddObra.Enabled = false;
            this.Text = "Crear Cliente";
            txtNombre.Enabled = true;
            txtApellido.Enabled = true;
            btnConfirmar.Text = "Crear";
            btnConfirmar.Height = 31;
            btnCancelar.Visible = true;
            lstCli.Enabled = false;
            limpieza();
            op = 1;
            txtNombre.Focus();
            lstObra.DataSource = new DataTable();
            lblInfoObra.Visible = true;
        }

        private void radModificar_CheckedChanged(object sender, EventArgs e)
        {
            lstObra.Enabled = true;
            btnAddObra.Enabled = true;
            this.Text = "Modificar Cliente";
            txtNombre.Enabled = true;
            txtApellido.Enabled = true;
            btnConfirmar.Text = "Guardar";
            btnConfirmar.Height = 31;
            btnCancelar.Visible = true;
            lstCli.Enabled = true;
            limpieza();
            op = 2;
            lstCli.Focus();
            lstObra.DataSource = new DataTable();
            lblInfoObra.Visible = false;
        }

        private void radEliminar_CheckedChanged(object sender, EventArgs e)
        {
            lstObra.Enabled = false;
            btnAddObra.Enabled = false;
            this.Text = "Eliminar Cliente";
            txtNombre.Enabled = false;
            txtApellido.Enabled = false;
            btnConfirmar.Text = "Eliminar";
            btnConfirmar.Height = 70;
            btnCancelar.Visible = false;
            lstCli.Enabled = true;
            limpieza();
            op = 3;
            lstCli.Focus();
            lstObra.DataSource = new DataTable();
            lblInfoObra.Visible = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea cancelar, los datos no guardados no se conservarán?", "¿Cancelar?",
                                  MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                limpieza();
                if (op == 1)
                    txtNombre.Focus();
                else
                    lstCli.Focus();

            }
        }
         private void limpieza()
        {
            txtNombre.Text = string.Empty;
            txtApellido.Text = string.Empty;
            id = string.Empty;
        }

         private void btnSalir_Click(object sender, EventArgs e)
         {
             this.Close();
         }

         private void frmABM_Cliente_FormClosing(object sender, FormClosingEventArgs e)
         {
             if (MessageBox.Show("¿Seguro que desea salir, los datos no guardados no se conservarán?", "¿Salir?",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                 e.Cancel = false;
             else
                 e.Cancel = true;
         }

         private void actualizarLst ()
        {
            string consulta = "SELECT id_cliente, apellido + ' ' + nombre AS nombrecompeto FROM Cliente WHERE id_estado=1";
            DataTable tabla = oDatos.consultarSQL(consulta);
            lstCli.DataSource = tabla;
            lstCli.DisplayMember = tabla.Columns[1].ColumnName;
            lstCli.ValueMember = tabla.Columns[0].ColumnName.ToString();
        }

         private void frmABM_Cliente_Load(object sender, EventArgs e)
         {
             radModificar.Checked = true;
             limpieza();
             actualizarLst();
             lstCli.Focus();
             timBotones.Start();
             lblInfoObra.Visible = false; 
         }

         private void lstCli_SelectedIndexChanged(object sender, EventArgs e)
         {
             if (ban)
             {
                 actualizarLst();
                 ban = false;
             }
             id = lstCli.SelectedValue.ToString();
             string consulta = "select nombre, apellido from Cliente where id_cliente = " + id;
             DataTable tabla = oDatos.consultarSQL(consulta);
             txtNombre.Text = tabla.Rows[0].ItemArray[0].ToString();
             txtApellido.Text = tabla.Rows[0].ItemArray[1].ToString();
             cargarObra();
             txtNombre.Focus();
             
         }
         private void cargarObra()
         {
             string consulta = "SELECT o.id_obraSocial, o.nombre + ' - ' + o.tipo AS nombrecompeto FROM ObraSocial o, ClienteObrasSociales c WHERE c.id_estado=1 AND c.id_obraSocial=o.id_obraSocial AND c.id_cliente = " + id;
             DataTable tabla = oDatos.consultarSQL(consulta);
             lstObra.DataSource = tabla;
             if (tabla.Rows.Count > 0)
             {
                 lstObra.DisplayMember = tabla.Columns[1].ColumnName;
                 lstObra.ValueMember = tabla.Columns[0].ColumnName.ToString();
                 if (op != 3)
                 {
                     btnEditObra.Enabled = true;
                     btnDeleteObra.Enabled = true;
                 }

             }
             else
             {
                 btnEditObra.Enabled = false;
                 btnDeleteObra.Enabled = false;
             }
         }
         private void btnConfirmar_Click(object sender, EventArgs e)
         {
             if (op == 1 && txtNombre.Text != string.Empty && txtApellido.Text != string.Empty)
             {
                 if (validarCli(txtNombre.Text, txtApellido.Text) == true)
                 {
                     string insertar = "insert into Cliente (nombre, apellido, id_estado) values ("
                                             + "'" + txtNombre.Text + "',"
                                             + "'" + txtApellido.Text + "',"
                                             + "1)";
                     oDatos.actualizarBD(insertar);
                     actualizarLst();
                     limpieza();
                     MessageBox.Show("Cliente guardado correctamente.", "Cliente Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                 }
                 else
                     MessageBox.Show("Ese Cliente ya Existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
             }
             
             else if (op == 2 && txtNombre.Text != string.Empty && txtApellido.Text != string.Empty )
             {
                 if (validarCli(txtNombre.Text, txtApellido.Text) == true)
                 {
                     string update = "UPDATE Cliente set nombre = '" + txtNombre.Text +
                                            "', apellido = '" + txtApellido.Text +
                                            "' WHERE id_cliente = " + id;
                     oDatos.actualizarBD(update);
                     actualizarLst();
                     limpieza();
                     MessageBox.Show("Cliente modificado", "Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                 }
                 else
                     MessageBox.Show("Ese Cliente ya Existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
             }
             else if (op == 3 && id != string.Empty)
             {
                 if (MessageBox.Show("¿Está seguro que desea eliminar este Cliente?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Yes)
                 {
                     string eliminar = "UPDATE Cliente set id_estado = 2 WHERE id_Cliente = " + id;
                     oDatos.actualizarBD(eliminar);
                     actualizarLst();
                     limpieza();
                 }
             }
             else
                 MessageBox.Show("Debe completar los campos obligatorios y/o seleccionar un Clente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

             txtNombre.Focus();
         }
         

        private bool validarCli (string nom, string ape)
         {
             if (op == 1)
             {
                 DataTable tablaVali = oDatos.consultarSQL("SELECT * from Cliente WHERE nombre LIKE '" + nom + "' AND apellido LIKE '"+ ape + "'");
                 if (tablaVali.Rows.Count == 0)
                     return true;
                 else
                     return false;
             }
             else if (op == 2)
             {
                 DataTable tablaVali = oDatos.consultarSQL("SELECT id_cliente from Cliente WHERE nombre LIKE '" + nom + "' AND apellido LIKE '" + ape + "'");
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
            if (op != 2)
                btnAddObra.Enabled = false;
            else
                btnAddObra.Enabled = true;
            if (op == 2 && id == string.Empty)
                btnAddObra.Enabled = false;
            else if (op == 2)
                btnAddObra.Enabled = true;
            if (lstObra.Items.Count==0 || op==3)
            {
                btnDeleteObra.Enabled = false;
                btnEditObra.Enabled = false;
            }
            else
            {
                btnDeleteObra.Enabled = true;
                btnEditObra.Enabled = true;
            }

        }

        private void btnAddObra_Click(object sender, EventArgs e)
        {
            new frmClienteObraSocial("1",string.Empty,id).ShowDialog();
            cargarObra();
        }

        private void btnEditObra_Click(object sender, EventArgs e)
        {
            new frmClienteObraSocial("2", lstObra.SelectedValue.ToString(), id).ShowDialog();
            cargarObra();
        }

        private void btnDeleteObra_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea eliminar la Obra Social?", "¿Eliminar?",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                new frmClienteObraSocial("3", lstObra.SelectedValue.ToString(), id).ShowDialog();

            cargarObra();
        }
    }
}
