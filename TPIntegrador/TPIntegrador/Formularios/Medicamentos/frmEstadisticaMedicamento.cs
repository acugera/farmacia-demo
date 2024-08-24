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
    public partial class frmEstadisticaMedicamento : Form
    {
        BDHelper oDatos = new BDHelper();
        public frmEstadisticaMedicamento()
        {
            InitializeComponent();
        }

        private void frmEstadisticaMedicamento_Load(object sender, EventArgs e)
        {
            string consulta = "select m.nombre, SUM(d.cantidad) from DetalleVenta d JOIN Medicamento m ON m.id_medicamento = d.id_medicamento JOIN Venta v ON d.id_venta = v.id_venta GROUP BY m.nombre";
            MedicamentoBindingSource.DataSource = oDatos.consultarSQL(consulta);
            rpvReporte.RefreshReport();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            if (dtpDesde.Value < dtpHasta.Value)
            {
                string consulta = "select m.nombre, SUM(d.cantidad) from DetalleVenta d JOIN Medicamento m ON m.id_medicamento = d.id_medicamento JOIN Venta v ON d.id_venta = v.id_venta where v.fecha_venta between '" + dtpDesde.Value.ToShortDateString() + "' AND '" + dtpHasta.Value.ToShortDateString() + "' GROUP BY m.nombre";
                MedicamentoBindingSource.DataSource = oDatos.consultarSQL(consulta);
                rpvReporte.RefreshReport();
            }
            else
                MessageBox.Show("La fecha Desde debe ser menor o fecha Hasta debe ser mayor.");
        }
    }
}
