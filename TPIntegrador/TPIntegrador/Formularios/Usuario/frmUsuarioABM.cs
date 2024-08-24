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
    public partial class frmUsuarioABM : Form
    {
        BDHelper oDatos = new BDHelper();
        string id_usuario = string.Empty;
        string id_fila = string.Empty;
        bool nuevo = false;
        public frmUsuarioABM()
        {
            InitializeComponent();
        }
        private void frmUsuarioABM_Load(object sender, EventArgs e)
        {
            cargarGrila();
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            btnNuevo.Enabled = false;
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
            btnCancelar.Enabled = true;
            btnGuardar.Enabled = true;
            txtDescripcion.Text = string.Empty;
            txtDescripcion.Enabled = true;
            txtDescripcion.Focus();
            nuevo = true;
        }

        private void cargarGrila()
        {
            dgvUsuario.Rows.Clear();
            string consulta = "select id_usuario, descripcion, nivel from Usuario where id_estado = 1";
            DataTable tabla = oDatos.consultarSQL(consulta);
            if (tabla.Rows.Count > 0)
            {
                for (int i = 0; i < tabla.Rows.Count; i++)
                {
                    dgvUsuario.Rows.Add(tabla.Rows[i]["id_usuario"],
                                    tabla.Rows[i]["descripcion"],
                                    tabla.Rows[i]["nivel"]);
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void dgvUsuario_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvUsuario.Rows.Count > 0)
            {
                id_usuario = dgvUsuario.CurrentRow.Cells[0].Value.ToString();
                id_fila = dgvUsuario.CurrentRow.Index.ToString();
                btnEliminar.Enabled = true;
                btnModificar.Enabled = true;
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            dgvUsuario.Enabled = false;

            id_usuario = dgvUsuario.CurrentRow.Cells[0].Value.ToString();
            Int32 fila = Int32.Parse(id_fila);
            btnNuevo.Enabled = false;
            btnEliminar.Enabled = false;
            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;
            txtDescripcion.Text = dgvUsuario.Rows[fila].Cells[1].Value.ToString();
            cmbPermisos.Text = dgvUsuario.Rows[fila].Cells[2].Value.ToString();
            txtDescripcion.Enabled = true;
            txtDescripcion.Focus();
            nuevo = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (nuevo == true)
            {
                if (txtDescripcion.Text == string.Empty)
                    MessageBox.Show("Debe ingresar una descripcion para el usuario.");
                else
                {
                    //string nivel = "select IDENT_CURRENT('Usuario')";
                    //DataTable tabla = oDatos.consultarSQL(nivel);
                    //nivel = tabla.Rows[0].ItemArray[0].ToString();
                    //Int32 lvl = Int32.Parse(nivel);
                    //lvl += 1;
                    string insertar = "insert into Usuario (descripcion, nivel, id_estado) values ("
                                        + "'" + txtDescripcion.Text + "'," 
                                        + cmbPermisos.Text + ", 1)";
                    oDatos.actualizarBD(insertar);

                    MessageBox.Show("Usuario guardado correctamente.", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                if (txtDescripcion.Text == string.Empty)
                    MessageBox.Show("Debe ingresar una descripcion para el usuario.");
                else
                {
                    string update = "update Usuario set descripcion = '" + txtDescripcion.Text + 
                                    "', nivel = " + cmbPermisos.Text + " where id_usuario = " + id_usuario;
                    oDatos.actualizarBD(update);

                    MessageBox.Show("Usuario modificado correctamente.");
                }
            }
            cargarGrila();
            limpiar();
        }

        private void limpiar()
        {
            txtDescripcion.Text = string.Empty;
            txtDescripcion.Enabled = false;
            btnCancelar.Enabled = false;
            btnGuardar.Enabled = false;
            btnNuevo.Enabled = true;
            btnModificar.Enabled = true;
            btnEliminar.Enabled = true;
            dgvUsuario.Enabled = true;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea eliminar el producto de la lista?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Int32 fila = Int32.Parse(id_fila);
                dgvUsuario.Rows.RemoveAt(fila);
                btnEliminar.Enabled = false;
                btnModificar.Enabled = false;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmUsuarioABM_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea salir? Los datos que no fueron guardados se perderán.", "¿Salir?",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                e.Cancel = false;
            else
                e.Cancel = true;
        }
    }
}
