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
    public partial class frmMedicamentosAMB : Form
    {
        BDHelper oDatos = BDHelper.getBDHelper();
        Funciones_Auxiliares aux = new Funciones_Auxiliares();
        bool nuevo = false;
        string id = string.Empty;
        string id_med = string.Empty;
        public frmMedicamentosAMB()
        {
            InitializeComponent();
        }
        private void frmMedicamentos_Load(object sender, EventArgs e)
        {
            cargarGrila();
            aux.cargar_combo(cmbLaboratorio, "Laboratorio", oDatos);
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            //
            dgvMedicamentos.Enabled = false;
            txtNombre.Enabled = true;
            txtDroga.Enabled = true;
            txtPrecio.Enabled = true;
            txtStock.Enabled = true;
            panel.Enabled = true;
            cmbLaboratorio.Enabled = true;
            btnNuevo.Enabled = false;
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;
            //
            txtNombre.Text = string.Empty;
            txtDroga.Text = string.Empty;
            txtPrecio.Text = string.Empty;
            txtStock.Text = string.Empty;
            rdbSi.Checked = true;
            cmbLaboratorio.SelectedValue = 1;
            nuevo = true;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            dgvMedicamentos.Enabled = false;
            txtNombre.Enabled = true;
            txtDroga.Enabled = true;
            txtPrecio.Enabled = true;
            txtStock.Enabled = true;
            panel.Enabled = true;
            cmbLaboratorio.Enabled = true;
            btnNuevo.Enabled = false;
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;
            nuevo = false;
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea eliminar el medicamento?", "Advertencia.", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Yes)
            {
                string eliminar = "update Medicamento set id_estado = 2 where id_medicamento = " + id_med;
                oDatos.actualizarBD(eliminar);
                MessageBox.Show("Medicamento eliminado correctamente.");
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
            if (txtNombre.Text != string.Empty && txtDroga.Text != string.Empty && txtPrecio.Text != string.Empty && txtStock.Text != string.Empty)
            {
                if (nuevo == true) //entra cuando se aprieta el botón de Nuevo
                {      
                     if (rdbSi.Checked) //si se selecciona que el medicamento si tiene receta.
                     {
                            string nuevoM = "insert into Medicamento (nombre, droga, id_laboratorio, receta, precio, stock_real, id_estado) values ( "
                                            + "'" + txtNombre.Text + "',"
                                            + "'" + txtDroga.Text + "',"
                                            + cmbLaboratorio.SelectedValue + ","
                                            + "'true',"
                                            + txtPrecio.Text + ","
                                            + txtStock.Text + ","
                                            + " 1)";
                            oDatos.actualizarBD(nuevoM);
                      }
                      else
                      {
                          string nuevoM = "insert into Medicamento (nombre, droga, id_laboratorio, receta, precio, stock_real, id_estado) values ( "
                                            + "'" + txtNombre.Text + "',"
                                            + "'" + txtDroga.Text + "',"
                                            + cmbLaboratorio.SelectedValue + ","
                                            + "'false',"
                                            + txtPrecio.Text + ","
                                            + txtStock.Text + ","
                                            + "1)";
                            oDatos.actualizarBD(nuevoM);
                      }  
                        MessageBox.Show("Medicamento guardado correctamente.","Medicamento guardado", MessageBoxButtons.OK,MessageBoxIcon.Information);
                        restablecerCampos();           
                }
                else //si se aprieta el botón modificar.
                {
                      if (rdbSi.Checked)
                      {
                          string modificar = "update Medicamento set nombre = '" + txtNombre.Text + "',"
                                              + "droga = '" + txtDroga.Text + "',"
                                              + "id_laboratorio = " + cmbLaboratorio.SelectedValue + ","
                                              + "receta = 'true',"
                                              + "precio = " + txtPrecio.Text + ","
                                              + "stock_real = " + txtStock.Text
                                              + " where id_medicamento = " + id_med;
                          oDatos.actualizarBD(modificar);
                      }
                      else
                      {
                          string modificar = "update Medicamento set nombre = '" + txtNombre.Text + "',"
                                              + "droga = '" + txtDroga.Text + "',"
                                              + "id_laboratorio = " + cmbLaboratorio.SelectedValue + ","
                                              + "receta = 'false',"
                                              + "precio = " + txtPrecio.Text + ","
                                              + "stock_real = " + txtStock.Text
                                              + " where id_medicamento = " + id_med;
                          oDatos.actualizarBD(modificar);
                      }
                      MessageBox.Show("Medicamento Modificado correctamente.", "Medicamento Modificado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                      restablecerCampos();  
                }
                cargarGrila();
            }
            else
            {
                MessageBox.Show("Por favor complete todos los campos.", "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        private void restablecerCampos()
        {
            dgvMedicamentos.Enabled = true;
            txtNombre.Text = string.Empty;
            txtDroga.Text = string.Empty;
            txtPrecio.Text = string.Empty;
            txtStock.Text = string.Empty;
            cmbLaboratorio.SelectedValue = 1;
            panel.Enabled = false;
            rdbSi.Checked = true;
            txtNombre.Enabled = false;
            txtDroga.Enabled = false;
            txtPrecio.Enabled = false;
            txtStock.Enabled = false;
            cmbLaboratorio.Enabled = false;
            btnNuevo.Enabled = true;
            btnModificar.Enabled = true;
            btnEliminar.Enabled = true;
            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;
        }
        private void cargarGrila()
        {
            dgvMedicamentos.Rows.Clear();
            string consulta = "select m.id_medicamento, m.nombre, m.droga, l.nombre as 'nombreLab' from Medicamento m JOIN Laboratorio l ON m.id_laboratorio = l.id_laboratorio where m.id_estado = 1";
            DataTable tabla = oDatos.consultarSQL(consulta);
            if (tabla.Rows.Count > 0)
            {
                for (int i = 0; i < tabla.Rows.Count; i++)
                {
                    dgvMedicamentos.Rows.Add(tabla.Rows[i]["id_medicamento"],
                                    tabla.Rows[i]["nombre"],
                                    tabla.Rows[i]["droga"],
                                    tabla.Rows[i]["nombreLab"]);
                }
            }
        }
        private void txtStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (aux.numberVal(e.KeyChar) == false)
            {
                e.Handled = true;
            }
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (aux.numberVal(e.KeyChar) == false)
            {
                e.Handled = true;
            }
        }
        private void frmMedicamentos_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea salir?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvMedicamentos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvMedicamentos.Rows.Count > 0)
            {
                id_med = dgvMedicamentos.CurrentRow.Cells[0].Value.ToString();
                string med = "select m.id_medicamento, m.nombre, m.droga, m.id_laboratorio, m.precio, m.receta, m.stock_real from Medicamento m "
                                + " where m.id_medicamento = " + id_med;
                DataTable tabla = oDatos.consultarSQL(med);
                txtNombre.Text = tabla.Rows[0].ItemArray[1].ToString();
                txtDroga.Text = tabla.Rows[0].ItemArray[2].ToString();
                cmbLaboratorio.SelectedValue = tabla.Rows[0].ItemArray[3].ToString();
                txtPrecio.Text = tabla.Rows[0].ItemArray[4].ToString();
                txtStock.Text = tabla.Rows[0].ItemArray[6].ToString();
                if (tabla.Rows[0].ItemArray[5].ToString() == "true")
                {
                    rdbSi.Checked = true;
                }
                else
                {
                    rdbNo.Checked = true;
                }
            }
        }
    }
}
