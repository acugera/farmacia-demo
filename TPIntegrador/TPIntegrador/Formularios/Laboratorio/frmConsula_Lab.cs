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
    public partial class frmConsula_Lab : Form
    {
        BDHelper oDatos = BDHelper.getBDHelper();
        Funciones_Auxiliares aux = new Funciones_Auxiliares();
        public frmConsula_Lab()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvLab.Rows.Clear();
            string consulta=string.Empty;
            if (txtBusqueda.Text==string.Empty)
                consulta = "SELECT id_laboratorio, nombre, cuit, telefono FROM Laboratorio WHERE id_estado = 1";
            else if (trcSeleccionador.Value==0)
                consulta = "SELECT id_laboratorio, nombre, cuit, telefono FROM Laboratorio WHERE id_estado = 1 AND id_laboratorio = " + txtBusqueda.Text;
            else if (trcSeleccionador.Value==1)
                consulta = "SELECT id_laboratorio, nombre, cuit, telefono FROM Laboratorio WHERE id_estado = 1 AND nombre = '" + txtBusqueda.Text + "'";
            else if (trcSeleccionador.Value==2)
                consulta = "SELECT id_laboratorio, nombre, cuit, telefono FROM Laboratorio WHERE id_estado = 1 AND cuit = '" + txtBusqueda.Text + "'";
            else if (trcSeleccionador.Value==3)
                consulta = "SELECT id_laboratorio, nombre, cuit, telefono FROM Laboratorio WHERE id_estado = 1 AND telefono = " + txtBusqueda.Text;
            DataTable tabla = oDatos.consultarSQL(consulta);
            if (tabla.Rows.Count > 0)
            {
                for (int i = 0; i < tabla.Rows.Count; i++)
                {
                    dgvLab.Rows.Add(tabla.Rows[i]["id_laboratorio"],
                                    tabla.Rows[i]["nombre"],
                                    tabla.Rows[i]["cuit"],
                                    tabla.Rows[i]["telefono"]);
                }
            }
            txtBusqueda.Text = string.Empty;
        }

        private void trcSeleccionador_Scroll(object sender, EventArgs e)
        {
            txtBusqueda.Text = string.Empty;
        }

        private void txtBusqueda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (trcSeleccionador.Value == 0)
            {
                if (aux.numberVal(e.KeyChar) == false)
                    e.Handled = true;
            }
               
            else if (trcSeleccionador.Value == 3)
                if (aux.numberVal(e.KeyChar) == false)
                    e.Handled = true; 
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmConsula_Lab_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea salir de la consulta de Laboratorios?", "¿Salir?",
                              MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                e.Cancel = false;
            else
                e.Cancel = true;
        }

        
    }
}
