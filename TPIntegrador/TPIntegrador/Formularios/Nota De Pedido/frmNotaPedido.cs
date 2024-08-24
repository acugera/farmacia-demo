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
    public partial class frmNotaPedido : Form
    {
        Funciones_Auxiliares aux = new Funciones_Auxiliares();
        BDHelper oDatos = new BDHelper();
        string id_fila = string.Empty;
        bool evitarCarga = false;
        public frmNotaPedido()
        {
            InitializeComponent();
        }

        private void frmNotaPedido_Load(object sender, EventArgs e)
        {
            aux.cargar_combo(cmbLaboratorio, "Laboratorio", oDatos);
            timAux.Start();
        }

        private void btnConfirmarLaboratorio_Click(object sender, EventArgs e)
        {
            if (btnConfirmarLaboratorio.Text == "Confirmar")
            {
                string consulta = "select id_medicamento, nombre from Medicamento where id_laboratorio = " + cmbLaboratorio.SelectedValue.ToString(); ;
                DataTable tabla = oDatos.consultarSQL(consulta);
                cmbMedicamento.DataSource = tabla;
                cmbMedicamento.DisplayMember = tabla.Columns[1].ColumnName;
                cmbMedicamento.ValueMember = tabla.Columns[0].ColumnName.ToString();
                cmbMedicamento.SelectedValue = -1;
                panelMedicamento.Enabled = true;
                btnConfirmarLaboratorio.Text = "Cancelar";
            }
            else
            {
                limpiar();
                btnConfirmarLaboratorio.Text = "Confirmar";
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (btnAgregar.Text == "Agregar")
            {
                if ((txtCantidad.Text == string.Empty && cmbMedicamento.Text == string.Empty) || txtCantidad.Text == "0")
                    MessageBox.Show("Los campos no deben estar vacíos.");
                else
                {
                    panelGrilla.Enabled = true;
                    for (int i = 0; i < dgvMedicamento.Rows.Count; i++)
                    {
                        if (dgvMedicamento.Rows[i].Cells[2].Value.ToString() == cmbMedicamento.SelectedValue.ToString())
                        {
                            MessageBox.Show("El Medicamento ya ha sido seleccionado.");
                            txtCantidad.Text = string.Empty;
                            cmbMedicamento.SelectedValue = -1;
                            evitarCarga = false;
                            break;
                        }
                        else
                        {
                            evitarCarga = true;

                        }
                    }
                    if (evitarCarga == true)
                    {
                        cargarGrila();
                        txtCantidad.Text = string.Empty;
                        cmbMedicamento.SelectedValue = -1;
                    }
                    if (dgvMedicamento.Rows.Count == 0)
                    {
                        cargarGrila();
                        txtCantidad.Text = string.Empty;
                        cmbMedicamento.SelectedValue = -1;
                    }
                }
            }
            else
            {
                if (txtCantidad.Text == string.Empty || txtCantidad.Text == "0")
                    MessageBox.Show("No puede agregar una cantidad con valor cero.");
                else
                {
                    Int32 fila = Int32.Parse(id_fila);
                    dgvMedicamento.Rows[fila].Cells[1].Value = txtCantidad.Text;
                    btnAgregar.Text = "Agregar";
                    panelEncabezado.Enabled = true;
                    panelGrilla.Enabled = true;
                    cmbMedicamento.Enabled = true;
                    txtCantidad.Text = string.Empty;
                }
            }
            btnConfirmarNota.Enabled = true;
        }
        private void cargarGrila()
        {
            string consulta = "select nombre, id_medicamento from Medicamento where id_medicamento = " + cmbMedicamento.SelectedValue;
            DataTable tabla = oDatos.consultarSQL(consulta);
            if (tabla.Rows.Count > 0)
            {
                for (int i = 0; i < tabla.Rows.Count; i++)
                {
                    dgvMedicamento.Rows.Add(tabla.Rows[i]["nombre"],
                                            txtCantidad.Text,
                                            tabla.Rows[i]["id_medicamento"]);
                }
            }
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (aux.numberVal(e.KeyChar) == false)
            {
                e.Handled = true;
            }
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea eliminar el Medicamento de la lista?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Int32 fila = Int32.Parse(id_fila);
                dgvMedicamento.Rows.RemoveAt(fila);
                btnQuitar.Enabled = false;
                btnModificarCantidad.Enabled = false;
                if (dgvMedicamento.Rows.Count == 0)
                    btnConfirmarNota.Enabled = false;
            }
        }

        private void dgvMedicamento_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvMedicamento.Rows.Count > 0)
            {
                id_fila = dgvMedicamento.CurrentRow.Index.ToString();
                btnQuitar.Enabled = true;
                btnModificarCantidad.Enabled = true;
            }
        }

        private void btnModificarCantidad_Click(object sender, EventArgs e)
        {
            btnAgregar.Text = "Confirmar";
            id_fila = dgvMedicamento.CurrentRow.Index.ToString();
            txtCantidad.Focus();
            panelEncabezado.Enabled = false;
            panelGrilla.Enabled = false;
            cmbMedicamento.Enabled = false;
            btnConfirmarNota.Enabled = false;
        }

        private void frmNotaPedido_FormClosing(object sender, FormClosingEventArgs e)
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

        private void btnCancelarVenta_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirmarNota_Click(object sender, EventArgs e)
        {
            oDatos.startTransaction();
            grabarEncabezado();
            grabarDetalle();
            oDatos.endTransaction();
            if (oDatos.resultadoDeTrasaccion == true)
            {
                MessageBox.Show("Nota de Pedido realizada con ¡ÉXITO!");
            }
            else
            {
                MessageBox.Show("¡ERROR! No se pudo realizar el pedido con éxito.");
            }
            limpiar();
        }

        private void grabarEncabezado()
        {
            string insert = "insert into NotaPedido (id_laboratorio, fechaPedido) values("
                                                    + cmbLaboratorio.SelectedValue + ","
                                                    + "'" + dtpFechaPedido.Value.ToShortDateString() + "')";
            oDatos.actualizarBD(insert);
        }

        private void grabarDetalle()
        {
            string identity = "select IDENT_CURRENT('NotaPedido') as 'Identity'";
            DataTable tabla = oDatos.consultarSQL(identity);
            identity = tabla.Rows[0].ItemArray[0].ToString();
            for (int i = 0; i < dgvMedicamento.Rows.Count; i++)
            {
                string insert = "insert into DetallePedido (id_NotaPedido, id_medcamento, cantidad) values(" + identity + ","
                                                            + dgvMedicamento.Rows[i].Cells[2].Value.ToString() + ","
                                                            + dgvMedicamento.Rows[i].Cells[1].Value.ToString() + ")";
                oDatos.actualizarBD(insert);
            }
        }

        private void limpiar()
        {
            panelGrilla.Enabled = false;
            panelMedicamento.Enabled = false;
            dgvMedicamento.Rows.Clear();
            btnConfirmarNota.Enabled = false;
            btnConfirmarLaboratorio.Text = "Confirmar";
            //btnAgregar.Text = "Agregar";
        }

        private void timAux_Tick(object sender, EventArgs e)
        {
            if (btnConfirmarLaboratorio.Text == "Confirmar")
            {
                cmbLaboratorio.Enabled = true;
            }
            else
            {
                cmbLaboratorio.Enabled = false;
            }
        }
    }
}
