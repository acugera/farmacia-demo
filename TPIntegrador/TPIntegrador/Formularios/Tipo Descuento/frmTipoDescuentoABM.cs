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
    public partial class frmTipoDescuentoABM : Form
    {
        BDHelper oDatos = new BDHelper();
        Funciones_Auxiliares aux = new Funciones_Auxiliares();
        string id_medicamento = string.Empty;
        string id_os = string.Empty;
        bool nuevo = false;
        public frmTipoDescuentoABM()
        {
            InitializeComponent();
        }

        private void frmTipoDescuentoABM_Load(object sender, EventArgs e)
        {
            aux.cargar_combo(cmbMedicamento, "Medicamento", oDatos);
            aux.cargar_combo(cmbObraSocial, "ObraSocial", oDatos);
            cargarGrila();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            cmbMedicamento.Enabled = true;
            cmbObraSocial.Enabled = true;
            txtDescuento.Enabled = true;
            cmbObraSocial.SelectedValue = 1;
            cmbMedicamento.SelectedValue = 1;
            txtDescuento.Text = string.Empty;
            btnCancelar.Enabled = true;
            btnGuardar.Enabled = true;
            btnNuevo.Enabled = false;
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
            dgvDescuento.Enabled = false;
            nuevo = true;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (txtDescuento.Text == string.Empty)
                MessageBox.Show("Por favor, seleccione un descuento");
            else
            {
                cmbMedicamento.Enabled = true;
                cmbObraSocial.Enabled = true;
                txtDescuento.Enabled = true;
                btnCancelar.Enabled = true;
                btnGuardar.Enabled = true;
                btnNuevo.Enabled = false;
                btnModificar.Enabled = false;
                btnEliminar.Enabled = false;
                dgvDescuento.Enabled = false;
                nuevo = false;
            }
        }

        private void cargarGrila()
        {
            dgvDescuento.Rows.Clear();
            string consulta = "select m.nombre as 'med', o.nombre, t.descuento, m.id_medicamento, o.id_obraSocial from TipoDescuento t JOIN Medicamento m ON t.id_medicamento = m.id_medicamento JOIN ObraSocial o ON t.id_obraSocial = o.id_obraSocial where t.id_estado = 1";
            DataTable tabla = oDatos.consultarSQL(consulta);
            if (tabla.Rows.Count > 0)
            {
                for (int i = 0; i < tabla.Rows.Count; i++)
                {
                    dgvDescuento.Rows.Add(tabla.Rows[i]["med"],
                                    tabla.Rows[i]["nombre"],
                                    tabla.Rows[i]["descuento"],
                                    tabla.Rows[i]["id_medicamento"],
                                    tabla.Rows[i]["id_obraSocial"]);
                }
            }
        }

        private void dgvDescuento_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDescuento.Rows.Count > 0)
            {
                id_os = dgvDescuento.CurrentRow.Cells[4].Value.ToString();
                id_medicamento = dgvDescuento.CurrentRow.Cells[3].Value.ToString();
                cmbMedicamento.SelectedValue = id_medicamento;
                cmbObraSocial.SelectedValue = id_os;
                txtDescuento.Text = dgvDescuento.CurrentRow.Cells[2].Value.ToString();
            }
        }

        private void limpiar()
        {
            dgvDescuento.Enabled = true;
            cmbMedicamento.SelectedValue = 1;
            cmbObraSocial.SelectedValue = 1;
            cmbMedicamento.Enabled = false;
            cmbObraSocial.Enabled = false;
            txtDescuento.Text = string.Empty;
            txtDescuento.Enabled = false;
            btnNuevo.Enabled = true;
            btnModificar.Enabled = true;
            btnEliminar.Enabled = true;
        }

        private bool existeDesc()
        {
            string consulta = "select * from TipoDescuento where id_medicamento = " + cmbMedicamento.SelectedValue + "AND id_obraSocial = " + cmbObraSocial.SelectedValue + "AND id_estado = 1";
            DataTable tabla = oDatos.consultarSQL(consulta);
            if (tabla.Rows.Count > 0)
                return true;
            else
                return false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (nuevo == true)
            {
                if (existeDesc() == true)
                {
                    MessageBox.Show("El tipo de descuento ya existe.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (txtDescuento.Text != string.Empty)
                    {
                        string insertar = "insert into TipoDescuento (id_medicamento, id_obraSocial, descuento, id_estado) values ( "
                                           + cmbMedicamento.SelectedValue + ","
                                           + cmbObraSocial.SelectedValue + ","
                                           + txtDescuento.Text + ","
                                           + "1)";
                        oDatos.actualizarBD(insertar);
                        MessageBox.Show("Descuento guardado correctamente");
                    }
                    else
                        MessageBox.Show("Debe ingresar un desceunto");
                }
            }
            else //modificar
            {
                string update = "update TipoDescuento set id_medicamento = " + cmbMedicamento.SelectedValue
                                + ", id_obraSocial = " + cmbObraSocial.SelectedValue 
                                + ", descuento = " + txtDescuento.Text
                                + " where id_medicamento = " + cmbMedicamento.SelectedValue + " AND id_obraSocial = " + cmbObraSocial.SelectedValue;
                oDatos.actualizarBD(update);
                MessageBox.Show("Descuento modificado correctamente.");
            }
            cargarGrila();
            limpiar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea eliminar el medicamento?", "Advertencia.", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Yes)
            {
                string eliminar = "delete from TipoDescuento where id_medicamento = " + cmbMedicamento.SelectedValue + " AND id_obraSocial = " + cmbObraSocial.SelectedValue;
                oDatos.actualizarBD(eliminar);
                MessageBox.Show("Descuento eliminado correctamente.");
                cargarGrila();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmTipoDescuentoABM_FormClosing(object sender, FormClosingEventArgs e)
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
    }
}
