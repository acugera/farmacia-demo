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
    public partial class frmEmpleado : Form
    {
        BDHelper oDatos = BDHelper.getBDHelper();
        Funciones_Auxiliares aux = new Funciones_Auxiliares();
        string id_med = string.Empty;
        public frmEmpleado()
        {
            InitializeComponent();
        }

        private void frmEmpleado_Load(object sender, EventArgs e)
        {
            cmbBuscar.SelectedItem =  "Todos";
            aux.cargar_combo(cmbPerfil, "Usuario", oDatos);
            aux.cargar_combo(cmbPerfilModificar, "Usuario", oDatos);

            //cargar grilla de modificación
            cargarGrila();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvBusqueda.Rows.Clear();
            string consulta=string.Empty;
            if (cmbBuscar.Text== "Número de Empleado")
            {
                consulta = "select e.id_empleado, u.descripcion, e.nombre, e.apellido, e.usuario from Empleado e JOIN Usuario u " +
                               "ON e.id_usuario = u.id_usuario where id_empleado = " + txtBuscar.Text  + "AND e.estado=1";
            }
            if ( cmbBuscar.Text == "Perfil")
            {
                consulta = "select e.id_empleado, u.descripcion, e.nombre, e.apellido, e.usuario from Empleado e JOIN Usuario u " +
                               "ON e.id_usuario = u.id_usuario where u.descripcion LIKE '" + txtBuscar.Text + "' AND e.estado=1";
            }
            if (cmbBuscar.Text == "Nombre")
            {
                consulta = "select e.id_empleado, u.descripcion, e.nombre, e.apellido, e.usuario from Empleado e JOIN Usuario u " +
                               "ON e.id_usuario = u.id_usuario where e.Nombre LIKE '" + txtBuscar.Text + "' AND e.estado=1";
            }
            if (cmbBuscar.Text == "Apellido")
            {
                consulta = "select e.id_empleado, u.descripcion, e.nombre, e.apellido, e.usuario from Empleado e JOIN Usuario u " +
                               "ON e.id_usuario = u.id_usuario where e.Apellido LIKE '" + txtBuscar.Text + "' AND e.estado=1";
            }
            if ( cmbBuscar.Text == "Usuario")
            {
                consulta = "select e.id_empleado, u.descripcion, e.nombre, e.apellido, e.usuario from Empleado e JOIN Usuario u " +
                               "ON e.id_usuario = u.id_usuario where e.Usuario LIKE '" + txtBuscar.Text + "' AND e.estado=1";
            }
            if (cmbBuscar.Text == "Todos")
            {
                
                consulta = "select e.id_empleado, u.descripcion, e.nombre, e.apellido, e.usuario from Empleado e JOIN Usuario u " +
                               "ON e.id_usuario = u.id_usuario where e.estado=1";
            }

            DataTable tabla = oDatos.consultarSQL(consulta);
            if (tabla.Rows.Count > 0) 
            {
                for (int i = 0; i < tabla.Rows.Count; i++) 
                {
                    dgvBusqueda.Rows.Add(tabla.Rows[i]["id_empleado"],
                                    tabla.Rows[i]["descripcion"],
                                    tabla.Rows[i]["nombre"],
                                    tabla.Rows[i]["apellido"],
                                    tabla.Rows[i]["usuario"]); 
                }
            }
            
            else
            {
                MessageBox.Show("No se ecnontraron Empleados","Búsqueda",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(txtNombre.Text== string.Empty || txtApellido.Text==string.Empty || txtUsuario.Text== string.Empty || txtContraseña.Text== string.Empty || txtContraseñaRepetida.Text==string.Empty)
            {
                MessageBox.Show("Completar todos los campos","Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
                if(txtContraseña.Text== txtContraseñaRepetida.Text)
                {
                    if (oDatos.verificarUsuario(txtUsuario.Text)==true)
                    {
                    string insertar = "insert into Empleado (id_usuario, nombre, apellido, usuario, contraseña, estado) values ("
                                        + cmbPerfil.SelectedValue + ","
                                        + "'" + txtNombre.Text + "',"
                                        + "'" + txtApellido.Text + "',"
                                        + "'" + txtUsuario.Text + "'," 
                                        + "'" + txtContraseña.Text + "',"
                                        + "1)";
                    oDatos.actualizarBD(insertar);
                    MessageBox.Show("Empleado guardado correctamente.", "Empleado Guardado", MessageBoxButtons.OK,MessageBoxIcon.Information);
                    txtNombre.Text = string.Empty;
                    txtApellido.Text = string.Empty;
                    txtUsuario.Text = string.Empty;
                    txtContraseña.Text = string.Empty;
                    txtContraseñaRepetida.Text = string.Empty;
                    cmbPerfil.SelectedItem = "Todos";
                    }
                    else{
                        MessageBox.Show("Este usuario ya existe, por favor cambie de usuario.","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Las contraseñas deben ser iguales.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            cargarGrila();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea cancelar, los datos no guardados no se conservarán?", "¿Cancelar?",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                txtNombre.Text = string.Empty;
                txtApellido.Text = string.Empty;
                txtUsuario.Text = string.Empty;
                txtContraseña.Text = string.Empty;
                txtContraseñaRepetida.Text = string.Empty;
            }
            
        }



        private void cargarGrila()
        {
            dgvModificar.Rows.Clear();
            dgvCrear.Rows.Clear();
            string consulta = "select * from Empleado where estado = 1";
            DataTable tabla = oDatos.consultarSQL(consulta);
            if (tabla.Rows.Count > 0)
            {
                for (int i = 0; i < tabla.Rows.Count; i++)
                {
                    dgvModificar.Rows.Add(tabla.Rows[i]["id_empleado"],
                                    tabla.Rows[i]["nombre"],
                                    tabla.Rows[i]["apellido"]);
                    dgvCrear.Rows.Add(tabla.Rows[i]["id_empleado"],
                                    tabla.Rows[i]["nombre"],
                                    tabla.Rows[i]["apellido"]);
                }
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (txtNombreModificar.Text!= string.Empty || txtApellidoModificar.Text!=string.Empty || txtUsuarioModificar.Text!= string.Empty || txtContraseñaModificar.Text!= string.Empty || txtContrRepModificar.Text!=string.Empty)
            {
                if(txtContraseñaModificar.Text == txtContrRepModificar.Text)
                {
                     if (oDatos.verificarUsuarioID(txtUsuarioModificar.Text, id_med)==false)
                     {
                         string consulta = "update Empleado set nombre = '" + txtNombreModificar.Text + 
                                            "', apellido = '" + txtApellidoModificar.Text +
                                            "', usuario = '" + txtUsuarioModificar.Text +
                                            "', contraseña = '" + txtContraseñaModificar.Text + 
                                            "', id_usuario = " + cmbPerfilModificar.SelectedValue +
                                            " where id_empleado = " + id_med;
                         oDatos.actualizarBD(consulta);
                         cargarGrila();
                         MessageBox.Show("Empleado modificado", "Información",MessageBoxButtons.OK,MessageBoxIcon.Information);
                         limpieza_modificar();
                     }
                     else
                     {
                         MessageBox.Show("Ya existe un empleado con este usuario", "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
                     }
                }
                else
                {
                    MessageBox.Show("Las contraseñas deben ser iguales.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("¿Está seguro que desea eliminar al empleado?", "Advertencia", MessageBoxButtons.YesNo,MessageBoxIcon.Warning)== System.Windows.Forms.DialogResult.Yes)
            {
                string consulta = "update Empleado set estado = 2 where id_empleado = " + id_med;
                oDatos.actualizarBD(consulta);
                MessageBox.Show("Empleado eliminado.", "Información", MessageBoxButtons.OK,MessageBoxIcon.Information);
                cargarGrila();
                limpieza_modificar();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmEmpleado_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea salir, los datos no guardados no se conservarán?", "¿Salir?",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                e.Cancel = false;
            else
                e.Cancel = true;
        }

        private void btnCancelarModificar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea cancelar, los datos no guardados no se conservarán?", "¿Cancelar?",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                limpieza_modificar();
            }
        }
        private void limpieza_modificar()
        {
            txtNombreModificar.Text = string.Empty;
            txtApellidoModificar.Text = string.Empty;
            txtUsuarioModificar.Text = string.Empty;
            txtContraseñaModificar.Text = string.Empty;
            txtContrRepModificar.Text = string.Empty;
            id_med = string.Empty;
            txtNombreModificar.Enabled = false;
            txtApellidoModificar.Enabled = false;
            txtUsuarioModificar.Enabled = false;
            txtContraseñaModificar.Enabled = false;
            txtContrRepModificar.Enabled = false;
            cmbPerfilModificar.Enabled = false;
            btnCancelarModificar.Enabled = false;
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;
        }
        private void enabled()
        {
            txtNombreModificar.Enabled = true;
            txtApellidoModificar.Enabled = true;
            txtUsuarioModificar.Enabled = true;
            txtContraseñaModificar.Enabled = true;
            txtContrRepModificar.Enabled = true;
            cmbPerfilModificar.Enabled = true;
            btnCancelarModificar.Enabled = true;
            btnEliminar.Enabled = true;
            btnModificar.Enabled = true;
        }

        private void dgvModificar_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvModificar.Rows.Count > 0)
            {
                id_med = dgvModificar.CurrentRow.Cells[0].Value.ToString();
                string empl = "select Nombre, Apellido, Usuario, Contraseña, id_usuario from Empleado"
                                + " where id_empleado = " + id_med;
                DataTable tabla = oDatos.consultarSQL(empl);

                //
                txtNombreModificar.Text = tabla.Rows[0].ItemArray[0].ToString();
                txtApellidoModificar.Text = tabla.Rows[0].ItemArray[1].ToString();
                txtUsuarioModificar.Text = tabla.Rows[0].ItemArray[2].ToString();
                txtContraseñaModificar.Text = tabla.Rows[0].ItemArray[3].ToString();
                txtContrRepModificar.Text = txtContraseñaModificar.Text;
                cmbPerfilModificar.SelectedValue = tabla.Rows[0].ItemArray[4].ToString();

                enabled();
            }
        }
    }
}
