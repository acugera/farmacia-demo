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
    public partial class frmReporteVentas : Form
    {
        public string consulta = string.Empty;
        BDHelper oDatos = BDHelper.getBDHelper();
        public frmReporteVentas()
   
        {
            InitializeComponent();
        }

        private void frmReporte_Load(object sender, EventArgs e)
        {
            VentaBindingSource.DataSource = oDatos.consultarSQL(consulta);         
            rpvReporte.RefreshReport();
            this.rpvReporte.RefreshReport();
            this.rpvReporte.RefreshReport();
        }
    }
}
