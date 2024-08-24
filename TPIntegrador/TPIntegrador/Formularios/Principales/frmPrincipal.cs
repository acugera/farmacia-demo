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
    public partial class frmPrincipal : Form
    {
        BDHelper oDatos = BDHelper.getBDHelper();
        string perfil = string.Empty;
        string id = string.Empty;
        public frmPrincipal(string id_empleado)
        {
            InitializeComponent();
            id = id_empleado;
            string str = "select u.descripcion, e.nombre, e.apellido, u.nivel  from Empleado e JOIN Usuario u ON u.id_usuario = e.id_usuario "
                            +"where e.id_empleado = " + id_empleado;
            DataTable tabla = oDatos.consultarSQL(str);
            lblNombre.Text = "NOMBRE: " + tabla.Rows[0].ItemArray[1].ToString();
            lblApellido.Text = "APELLIDO: " + tabla.Rows[0].ItemArray[2].ToString();
            lblusuario.Text = "PERFIL: " + tabla.Rows[0].ItemArray[0].ToString();
            perfil = tabla.Rows[0].ItemArray[3].ToString();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            if ("1" != perfil)
            {
                btnEmpleado.Visible = false;
                btnCrea_Modifica.Visible = false;
            }
            
        }

        private void frmPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmEmpleado().ShowDialog();
        }

        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea salir?", "¿Salir?",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                e.Cancel = false;
            else
                e.Cancel = true;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnModiLab_Click(object sender, EventArgs e)
        {
            new frmABM_Lab().ShowDialog();
        }

        private void laboratorioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new frmConsula_Lab().ShowDialog();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            new frmABM_Cliente().ShowDialog();
        }

        private void editarLaboratoriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmConsulta_Cliente().ShowDialog();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            new frmMedicamentosAMB().ShowDialog();
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            new frmObraSocialABM().ShowDialog();
        }

        private void crearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmVenta(id).ShowDialog();
        }

        private void nuevaNotaDePedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmNotaPedido().ShowDialog();
        }

        private void medicamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmConsultaMedicamento().ShowDialog();
        }

        private void obraSocialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmConsultaObraSocial().ShowDialog();
        }

        private void consultarVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmConsultarVentas().ShowDialog();
        }

        private void consultarNotasDePedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmConsultarNP().ShowDialog();
        }

        private void modificarStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmActualizarStock().ShowDialog();
        }

        private void productosMásVendidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmEstadisticaMedicamento().ShowDialog();
        }

        private void ventasDeEmpleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmEstadisticaEmpleados().ShowDialog();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            new frmTipoDescuentoABM().ShowDialog();
        }

        private void tipoDeUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmUsuarioABM().ShowDialog();
        }
    }
}
