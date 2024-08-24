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
    public partial class frmDetalleCliente : Form
    {
        BDHelper oDatos = BDHelper.getBDHelper();
        public string id = string.Empty;
        public string nombre = string.Empty;
        public frmDetalleCliente()
        {
            InitializeComponent();
        }

        private void frmDetalleCliente_Load(object sender, EventArgs e)
        {
            lblID.Text += " " + id;
            lblNom.Text += " " + nombre;
            string consulta = "select o.nombre, c.nroObraSocial from ClienteObrasSociales c JOIN ObraSocial o ON o.id_obraSocial = c.id_obraSocial WHERE id_cliente = "+id;
            DataTable tabla = oDatos.consultarSQL(consulta);
            if (tabla.Rows.Count > 0)
            {
                for (int i = 0; i < tabla.Rows.Count; i++)
                {
                    dgvObra.Rows.Add(tabla.Rows[i]["nombre"],
                                    tabla.Rows[i]["nroObraSocial"]);
                }
            }
        }
    }
}
