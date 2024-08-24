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
    public partial class frmObraSocialABM : Form
    {
        BDHelper oDatos = BDHelper.getBDHelper();
        Funciones_Auxiliares func = new Funciones_Auxiliares();
        bool nuevo = false;
        string id_os = string.Empty;
        public frmObraSocialABM()
        {
            InitializeComponent();
        }

        private void frmObraSocialABM_Load(object sender, EventArgs e)
        {
            cargarGrila();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            nuevo = true;
            //
            dgvObraSocial.Enabled = false;
            txtNombre.Enabled = true;
            txtCuit.Enabled = true;
            txtTipoOS.Enabled = true;
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;
            //
            txtNombre.Text = string.Empty;
            txtCuit.Text = string.Empty;
            txtTipoOS.Text = string.Empty;
            txtNombre.Focus();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            dgvObraSocial.Enabled = false;
            nuevo = false;
            txtNombre.Enabled = true;
            txtCuit.Enabled = true;
            txtTipoOS.Enabled = true;
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
            btnNuevo.Enabled = false;
            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;
            txtNombre.Focus();
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea eliminar la Obra Social?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Yes)
            {
                string consulta = "update ObraSocial set id_estado = 2 where id_obraSocial = " + id_os;
                oDatos.actualizarBD(consulta);
                MessageBox.Show("Obra Social eliminada.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cargarGrila();
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea cancela? Los datos no se conservarán", "¿Cancelar?",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                restablecerCampos();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text != string.Empty && txtCuit.Text != string.Empty && txtTipoOS.Text != string.Empty)
            {
                if (nuevo == true) //si la bandera es true hace un insert. Else: hace una modificacion.
                {
                    string insert = "insert into ObraSocial (nombre, cuit, tipo, id_estado) values ("
                                    + "'" + txtNombre.Text + "',"
                                    + "'" + txtCuit.Text + "',"
                                    + "'" + txtTipoOS.Text + "',"
                                    + "1)";
                    oDatos.actualizarBD(insert);
                    MessageBox.Show("Obra Social guardada correctamente.", "Obra Social Guardada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    string consulta = "update ObraSocial set nombre = '" + txtNombre.Text +
                                       "'," + "cuit = '" + txtCuit.Text +
                                       "'," + "tipo = '" + txtTipoOS.Text + "'" +
                                       "where id_obraSocial = " + id_os;
                    oDatos.actualizarBD(consulta);
                    MessageBox.Show("Obra Social modificada", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Complete todos los campos, gracias.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            restablecerCampos();
            cargarGrila();
        }

        private void txtCuit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(func.cuit(e.KeyChar)== false)
            {
                e.Handled = true;
            }
        }

        

        private void cargarGrila()
        {
            dgvObraSocial.Rows.Clear();
            string consulta = "select * from ObraSocial where id_estado = 1";
            DataTable tabla = oDatos.consultarSQL(consulta);
            if (tabla.Rows.Count > 0)
            {
                for (int i = 0; i < tabla.Rows.Count; i++)
                {
                    dgvObraSocial.Rows.Add(tabla.Rows[i]["id_obraSocial"],
                                    tabla.Rows[i]["nombre"],
                                    tabla.Rows[i]["cuit"],
                                    tabla.Rows[i]["tipo"]);
                }
            }
        }

        private void restablecerCampos()
        {
            dgvObraSocial.Enabled = true;
            txtNombre.Enabled = false;
            txtCuit.Enabled = false;
            txtTipoOS.Enabled = false;
            //
            txtNombre.Text = string.Empty;
            txtCuit.Text = string.Empty;
            txtTipoOS.Text = string.Empty;
            //
            btnNuevo.Enabled = true;
            btnModificar.Enabled = true;
            btnEliminar.Enabled = true;
            btnCancelar.Enabled = false;
            btnGuardar.Enabled = false;
            
        }
        private void frmObraSocialABM_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea salir? Los datos no guardados no se conservarán", "¿Salir?",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                e.Cancel = false;
            else
                e.Cancel = true;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvObraSocial_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvObraSocial.Rows.Count > 0)
            {
                id_os = dgvObraSocial.CurrentRow.Cells[0].Value.ToString();
                string os = "select id_obraSocial, nombre, cuit, tipo from ObraSocial"
                                + " where id_obraSocial = " + id_os;
                DataTable tabla = oDatos.consultarSQL(os);
                txtNombre.Text = tabla.Rows[0].ItemArray[1].ToString();
                txtCuit.Text = tabla.Rows[0].ItemArray[2].ToString();
                txtTipoOS.Text = tabla.Rows[0].ItemArray[3].ToString();
            }
        }
    }
}
