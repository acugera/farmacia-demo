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
    public partial class frmConsultaObraSocial : Form
    {
        BDHelper oDatos = new BDHelper();
        Funciones_Auxiliares aux = new Funciones_Auxiliares();
        public frmConsultaObraSocial()
        {
            InitializeComponent();
        }

        private void porDefecto()
        {
            lblCuit.Visible = false;
            lblNombre.Visible = false;
            lblNumero.Visible = false;
            lblTipoCuit.Visible = false;
            txtCuit.Visible = false;
            txtNombre.Visible = false;
            txtNroObraSocial.Visible = false;
            txtTipoCuit.Visible = false;
            txtCuit.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtNroObraSocial.Text = string.Empty;
            txtTipoCuit.Text = string.Empty;
        }
        private void cmbBuscar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBuscar.Text == "Nro. Obra Social")
            {
                porDefecto();
                lblNumero.Visible = true;
                txtNroObraSocial.Visible = true;
            }
            if (cmbBuscar.Text == "Nombre")
            {
                porDefecto();
                lblNombre.Visible = true;
                txtNombre.Visible = true;
            }
            if (cmbBuscar.Text == "CUIT")
            {
                porDefecto();
                lblCuit.Visible = true;
                txtCuit.Visible = true;
            }
            if (cmbBuscar.Text == "Tipo de Cuit")
            {
                porDefecto();
                lblTipoCuit.Visible = true;
                txtTipoCuit.Visible = true;
            }
            if (cmbBuscar.Text == "Todos")
            {
                porDefecto();
            }
            btnBuscar.Visible = true;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvObraSocial.Rows.Clear();
            string consulta = string.Empty;
            if (cmbBuscar.Text == "Nro. Obra Social")
            {
                consulta = "select id_obraSocial, nombre, cuit, tipo from ObraSocial where id_estado = 1 AND id_obraSocial = " + txtNroObraSocial.Text;
            }
            if (cmbBuscar.Text == "Nombre")
            {
                consulta = "select id_obraSocial, nombre, cuit, tipo from ObraSocial where id_estado = 1 AND nombre = '" + txtNombre.Text + "'";
            }
            if (cmbBuscar.Text == "CUIT")
            {
                consulta = "select id_obraSocial, nombre, cuit, tipo from ObraSocial where id_estado = 1 AND cuit = '" + txtCuit.Text +"'";
            }
            if (cmbBuscar.Text == "Tipo de Cuit")
            {
                consulta = "select id_obraSocial, nombre, cuit, tipo from ObraSocial where id_estado = 1 AND tipo = " + txtTipoCuit.Text;
            }
            if (cmbBuscar.Text == "Todos")
            {
                consulta = "select id_obraSocial, nombre, cuit, tipo from ObraSocial where id_estado = 1 ";
            }
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
            else
                MessageBox.Show("No se ecnontraron Obras Sociales", "Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void frmConsultaObraSocial_Load(object sender, EventArgs e)
        {
            cmbBuscar.Text = "Todos";
        }

        private void txtNroObraSocial_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (aux.numberVal(e.KeyChar) == false)
            {
                e.Handled = true;
            }
        }

        private void txtCuit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (aux.cuit(e.KeyChar) == false)
            {
                e.Handled = true;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmConsultaObraSocial_FormClosing(object sender, FormClosingEventArgs e)
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
