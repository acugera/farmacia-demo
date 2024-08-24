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
    public partial class frmReporteNP : Form
    {
        BDHelper oDatos = BDHelper.getBDHelper();
        public string consulta = string.Empty;
        public frmReporteNP()
        {
            InitializeComponent();
        }

        private void frmReporteNP_Load(object sender, EventArgs e)
        {
            NpTableBindingSource.DataSource = oDatos.consultarSQL(consulta);
            rpvReporte.RefreshReport();
            this.rpvReporte.RefreshReport();
            this.rpvReporte.RefreshReport();
        }
    }
}
