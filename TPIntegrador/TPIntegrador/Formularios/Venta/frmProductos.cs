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
    public partial class frmProductos : Form
    {
        Funciones_Auxiliares aux = new Funciones_Auxiliares();
        BDHelper oDatos = BDHelper.getBDHelper();
        string idMedicamento = string.Empty;
        string precioUnitario = string.Empty;
        float cantidad = 0;
        float total = 0;
        bool flag = false;
        bool salir = false;
        bool load = false;
        string[] srt = new string[] {string.Empty , string.Empty , string.Empty};
        public frmProductos()
        {
            InitializeComponent();
        }

        private void frmProductos_Load(object sender, EventArgs e)
        {
            if (load == false)
            {
                aux.cargar_combo(cmbMedicamento, "Medicamento", oDatos);            
            }
            seleccionarPrecioUnitario();
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (aux.numberVal(e.KeyChar) == false)
            {
                e.Handled = true;
            }
        }

        private void cmbMedicamento_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            seleccionarPrecioUnitario();
            string txt = txtCantidad.Text;
            float precio = float.Parse(precioUnitario);
            total = (precio * cantidad);
            lblTotal.Text = total.ToString();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {         
                if (txtCantidad.Text != string.Empty)
                {
                    string consulta = "select stock_real from Medicamento where id_medicamento = " + cmbMedicamento.SelectedValue.ToString();
                    DataTable tabla = oDatos.consultarSQL(consulta);
                    Int32 cantidad = Int32.Parse(txtCantidad.Text);
                    Int32 stockReal = Int32.Parse(tabla.Rows[0].ItemArray[0].ToString());
                    if (cantidad > stockReal)
                    {
                        MessageBox.Show("La cantidad supera el Stock.");
                    }
                    else
                    {

                        srt = new string[] { cmbMedicamento.SelectedValue.ToString(), txtCantidad.Text, total.ToString() };
                        salir = true;
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Complete campo.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
        }


        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            if (txtCantidad.Text == string.Empty)
            {
                cantidad = float.Parse("0");
            }
            else
            {
                cantidad = float.Parse(txtCantidad.Text);
            }
            string txt = txtCantidad.Text;
            float precio = float.Parse(precioUnitario);
            total = (precio * cantidad);
            lblTotal.Text = total.ToString();
        }
        private void seleccionarPrecioUnitario()
        {
            if (flag == false)
            {
                aux.cargar_combo(cmbMedicamento, "Medicamento", oDatos);
                flag = true;
            }
            string consulta = "select id_medicamento, precio from Medicamento where id_medicamento = " + cmbMedicamento.SelectedValue;
            DataTable tabla = oDatos.consultarSQL(consulta);
            precioUnitario = tabla.Rows[0].ItemArray[1].ToString();
            lblPrecio.Text = "$" + precioUnitario;
        }

        private void frmProductos_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (salir == false)
            {
                if (MessageBox.Show("¿Seguro que desea salir? Se perderán los datos.", "¿Salir?",
                                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    e.Cancel = false;
                else
                {
                    e.Cancel = true;
                    srt = new string[] { string.Empty, string.Empty, string.Empty };
                }
                    
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
             
            this.Close();
        }

        public Array iniciarFrmProducto()
        {
            this.ShowDialog();
            return srt;
        }
        public Int32 modificarCantidad(string id, string cantidad)
        {
            load = true;
            cmbMedicamento.Enabled = false;
            aux.cargar_combo(cmbMedicamento, "Medicamento", oDatos);
            cmbMedicamento.SelectedValue = id;
            txtCantidad.Text = cantidad;
            this.ShowDialog();
            Int32 cantidadInt = Int32.Parse(txtCantidad.Text);
            return cantidadInt;
        }
    }
}
