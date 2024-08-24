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
    public partial class frmVenta : Form
    {
        BDHelper oDatos = BDHelper.getBDHelper();
        Funciones_Auxiliares aux = new Funciones_Auxiliares();
        string id_cliente = string.Empty;
        string id_medicamento = string.Empty;
        string id_producto = string.Empty;
        string id_fila = string.Empty;
        string cantidadEnFila = string.Empty;
        string cantidad = string.Empty;
        string total = string.Empty;
        bool primeraVezCliente = true;
        string id_empleado = string.Empty;
        public frmVenta(string id)
        {
            InitializeComponent();
            id_empleado = id;
            string consulta = "select nombre, apellido from Empleado where id_empleado = " + id_empleado;
            DataTable tabla = oDatos.consultarSQL(consulta);
            lblVendedor.Text = tabla.Rows[0].ItemArray[0].ToString() + " " + tabla.Rows[0].ItemArray[1].ToString();
        }

        private void btnAddCliente_Click(object sender, EventArgs e)
        {
            string id = new frmSeleccionarCliente().iniciarFrm();
            if (primeraVezCliente == true && id != string.Empty)
            {
                id_cliente = id;
                primeraVezCliente = false;
            }
            else if (primeraVezCliente == false && id != string.Empty)
            {
                id_cliente = id;
                chkObraSocial.Checked = false;
            }
            if (id_cliente != string.Empty)
            {
                string consulta = "select nombre, apellido from Cliente where id_cliente = " + id_cliente;
                DataTable tabla = oDatos.consultarSQL(consulta);
                txtNombreCli.Text = tabla.Rows[0].ItemArray[0].ToString();
                txtApellidoCli.Text = tabla.Rows[0].ItemArray[1].ToString();
                chkObraSocial.Enabled = true;
            }
        }

        private void chkObraSocial_CheckedChanged(object sender, EventArgs e)
        {
            if (chkObraSocial.Checked == true)
            {
                cmbObra_Social.Enabled = true;
                string consulta = "select id_obraSocial, nroObraSocial from ClienteObrasSociales where id_cliente = " + id_cliente;
                DataTable tabla = oDatos.consultarSQL(consulta);
                cmbObra_Social.DataSource = tabla;
                cmbObra_Social.DisplayMember = tabla.Columns[1].ColumnName;
                cmbObra_Social.ValueMember = tabla.Columns[0].ColumnName.ToString();
            }
            else
            {
                cmbObra_Social.DataSource = new DataTable();
                cmbObra_Social.Enabled = false;
            }
            
        }

        private void cargarGrila()
        {
            DataTable tablaDescuento = new DataTable();
            string consulta = "select id_medicamento, nombre, precio from Medicamento where id_medicamento = " + id_medicamento;
            DataTable tabla = oDatos.consultarSQL(consulta);
            if (chkObraSocial.Checked == true)
            {
                string descuento = "select descuento from tipoDescuento where id_estado = 1 AND id_medicamento = " + id_medicamento +
                                    "AND id_obraSocial = " + cmbObra_Social.SelectedValue;
                tablaDescuento = oDatos.consultarSQL(descuento);
            }
            
            if (tabla.Rows.Count > 0 && tablaDescuento.Rows.Count == 0)
            {
                for (int i = 0; i < tabla.Rows.Count; i++)
                {
                    dgvProductos.Rows.Add(tabla.Rows[i]["id_medicamento"],
                                    tabla.Rows[i]["nombre"],
                                    cantidad,
                                    tabla.Rows[i]["precio"],
                                    Int32.Parse(total),
                                    0,
                                    i);
                }
            }
            else if (tabla.Rows.Count > 0 && tablaDescuento.Rows.Count > 0 && chkObraSocial.Checked == true)
            {
                Int32 porcentaje = Int32.Parse(tablaDescuento.Rows[0].ItemArray[0].ToString());
                Int32 precioU = Int32.Parse(tabla.Rows[0].ItemArray[2].ToString());
                Int32 cantidadMed = Int32.Parse(cantidad);
                float operacion = ((porcentaje * precioU) / 100) * cantidadMed;
                for (int i = 0; i < tabla.Rows.Count; i++)
                {
                    dgvProductos.Rows.Add(tabla.Rows[i]["id_medicamento"],
                                    tabla.Rows[i]["nombre"],
                                    cantidad,
                                    tabla.Rows[i]["precio"],
                                    Int32.Parse(total),
                                    operacion,
                                    i);
                }
            }

        }
        private void btnAddProducto_Click(object sender, EventArgs e)
        {
            bool evitarCarga = false;
            Array arrayProducto = new frmProductos().iniciarFrmProducto();
            int num = 0;           
            if (arrayProducto != new string[] { string.Empty, string.Empty, string.Empty })
            {
                foreach (string i in arrayProducto)
                {
                    if (num == 0)
                        id_medicamento = i.ToString();
                    if (num == 1)
                        cantidad = i.ToString();
                    if (num == 2)
                        total = i.ToString();
                    num += 1;
                }
                for (int i = 0; i < dgvProductos.Rows.Count; i++ )
                {
                    if (dgvProductos.Rows[i].Cells[0].Value.ToString() == id_medicamento)
                    {
                        MessageBox.Show("El Medicamento ya ha sido seleccionado.");
                        evitarCarga = false;
                        break;
                    }
                    else
                    {
                        evitarCarga = true;
                    }
                }
                if (id_medicamento != string.Empty && cantidad != string.Empty && total != string.Empty && evitarCarga == true)
                    cargarGrila();
                if (id_medicamento != string.Empty && cantidad != string.Empty && total != string.Empty && dgvProductos.Rows.Count == 0)
                    cargarGrila();
            }
            operacionTotal();
        }
        private void operacionTotal()
        {
            double sumaDescuento = 0;
            double sumaPrecio = 0;
            int h = dgvProductos.Rows.Count;
            for (int x = 0; x < h; x++)
            {
                sumaPrecio += double.Parse(dgvProductos[4, x].Value.ToString());
                sumaDescuento += double.Parse(dgvProductos[5, x].Value.ToString());
            }
            double operacionFinal = (sumaPrecio - sumaDescuento);
            txtTotal.Text = operacionFinal.ToString();
        }

        private void btnConfirmarCliente_Click(object sender, EventArgs e)
        {
            if (id_cliente != string.Empty)
            {
                if (btnConfirmarCliente.Text == "Confirmar")
                {
                    grpProducto.Enabled = true;
                    cmbObra_Social.Enabled = false;
                    chkObraSocial.Enabled = false;
                    btnAddCliente.Enabled = false;
                    btnConfirmarCliente.Text = "Cancelar";
                }
                else
                {
                    grpProducto.Enabled = false;
                    cmbObra_Social.Enabled = true;
                    chkObraSocial.Enabled = true;
                    btnAddCliente.Enabled = true;
                    dgvProductos.Rows.Clear();
                    txtTotal.Text = string.Empty;
                    btnConfirmarCliente.Text = "Confirmar";
                }
            }
        }

        private void btnDeleteProducto_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea eliminar el producto de la lista?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Int32 fila = Int32.Parse(id_fila);
                dgvProductos.Rows.RemoveAt(fila);
                operacionTotal();
                btnDeleteProducto.Enabled = false;
                btnModificarCantidad.Enabled = false;
            }
        }

        private void dgvProductos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvProductos.Rows.Count > 0)
            {
                id_producto = dgvProductos.CurrentRow.Cells[0].Value.ToString();
                id_fila = dgvProductos.CurrentRow.Index.ToString();
                cantidadEnFila = dgvProductos.CurrentRow.Cells[2].Value.ToString();
                btnModificarCantidad.Enabled = true;
                btnDeleteProducto.Enabled = true;
            }
        }

        private void btnModificarCantidad_Click(object sender, EventArgs e)
        {
            Int32 nuevaCantidad = new frmProductos().modificarCantidad(id_producto, cantidadEnFila);
            Int32 fila = Int32.Parse(id_fila);          
            dgvProductos.Rows[fila].Cells[2].Value = nuevaCantidad;
            dgvProductos.Rows[fila].Cells[4].Value = nuevaCantidad * (float.Parse(dgvProductos.Rows[fila].Cells[3].Value.ToString()));
            if (chkObraSocial.Checked == true)
            {
                string descuento = "select descuento from tipoDescuento where id_estado = 1 AND id_medicamento = " + id_medicamento +
                                    "AND id_obraSocial = " + cmbObra_Social.SelectedValue;
                DataTable tablaDescuento = oDatos.consultarSQL(descuento);
                tablaDescuento = oDatos.consultarSQL(descuento);
                if (tablaDescuento.Rows.Count != 0)
                {
                    Int32 porcentaje = Int32.Parse(tablaDescuento.Rows[0].ItemArray[0].ToString());
                    float precioU = float.Parse(dgvProductos.Rows[fila].Cells[3].Value.ToString());
                    float operacion = ((porcentaje * precioU) / 100) * nuevaCantidad;
                    dgvProductos.Rows[fila].Cells[5].Value = operacion;
                }
            }
            operacionTotal();
            btnModificarCantidad.Enabled = false;
            btnDeleteProducto.Enabled = false;
        }

        private void tmrAuxiliar_Tick(object sender, EventArgs e)
        {
            if (dgvProductos.Rows.Count!=0 && cmbTipoFac.Text != string.Empty)
            {
                btnConfirmarVenta.Enabled = true;
            }
            else
            {
                btnConfirmarVenta.Enabled = false;
            }
        }

        private void btnConfirmarVenta_Click(object sender, EventArgs e)
        {
            oDatos.startTransaction();
            grabarEncabezado();
            grabarDetalle();
            oDatos.endTransaction();
            if (oDatos.resultadoDeTrasaccion==true)
            {
                MessageBox.Show("Venta realizada con EXITO!");
            }
            else
            {
                MessageBox.Show("ERROR! En la Venta");
            }
            limpiar();
        }

        private void grabarEncabezado()
        {

            string insertar = "insert into Venta (id_empleado, id_cliente, total_venta, fecha_venta, tipoFactura) values("
                                                              + id_empleado + ","
                                                              + id_cliente + ","
                                                              + txtTotal.Text.Replace(".", ",") + ","
                                                              + "'" + dtpFechaEmision.Value.ToShortDateString() + "',"
                                                              + "'" + cmbTipoFac.Text + "')";
            oDatos.actualizarBD(insertar);
        }
        private void grabarDetalle()
        {
            string identity = "select IDENT_CURRENT('Venta') as 'Identity'";
            DataTable tabla = oDatos.consultarSQL(identity);
            identity = tabla.Rows[0].ItemArray[0].ToString();
            for (int i = 0; i < dgvProductos.Rows.Count; i++)
            {
                
                string insertar = "insert into DetalleVenta (id_venta, id_medicamento, cantidad, precioUnitario, descuento) values(" + identity + ", "
                                                                         + dgvProductos.Rows[i].Cells[0].Value.ToString() + ","
                                                                         + dgvProductos.Rows[i].Cells[2].Value.ToString().Replace(".", ",") + ","
                                                                         + dgvProductos.Rows[i].Cells[3].Value.ToString().Replace(".", ",") + ","
                                                                         + dgvProductos.Rows[i].Cells[5].Value.ToString().Replace(".", ",") + ")";
                string consulta = "select stock_real - " + dgvProductos.Rows[i].Cells[2].Value.ToString() +  " from Medicamento where id_medicamento = " + dgvProductos.Rows[i].Cells[0].Value.ToString();
                DataTable tablaStock = oDatos.consultarSQL(consulta);      
                string upDate = "update Medicamento set stock_real = " + tablaStock.Rows[0].ItemArray[0].ToString() + " where id_medicamento = " + dgvProductos.Rows[i].Cells[0].Value.ToString();
                oDatos.actualizarBD(insertar);
                oDatos.actualizarBD(upDate);
            }
        }

        private void btnCancelarVenta_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmVenta_Load(object sender, EventArgs e)
        {
            tmrAuxiliar.Start();
        } 

        private void limpiar()
        {
            grpProducto.Enabled = false;
            btnAddCliente.Enabled = true;
            txtTotal.Text = string.Empty;
            btnConfirmarCliente.Text = "Confirmar";
            dgvProductos.Rows.Clear();
            txtApellidoCli.Text = string.Empty;
            txtNombreCli.Text = string.Empty;
            chkObraSocial.Checked = false;
            cmbObra_Social.Text = string.Empty;
            cmbTipoFac.SelectedValue = -1;
            btnAddProducto.Enabled = false;
            btnDeleteProducto.Enabled = false;
        }

        private void frmVenta_FormClosing(object sender, FormClosingEventArgs e)
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
