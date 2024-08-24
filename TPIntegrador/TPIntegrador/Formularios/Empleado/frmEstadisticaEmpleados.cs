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
    public partial class frmEstadisticaEmpleados : Form
    {
        BDHelper oDatos = new BDHelper();
        public frmEstadisticaEmpleados()
        {
            InitializeComponent();
        }

        private void frmEstadisticaEmpleados_Load(object sender, EventArgs e)
        {
            string consulta = "select e.nombre, COUNT(v.id_empleado) from Venta v JOIN Empleado e ON v.id_empleado = e.id_empleado GROUP BY e.nombre";
            EmpleadoBindingSource.DataSource = oDatos.consultarSQL(consulta);
            rpvReporte.RefreshReport();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            if (dtpDesde.Value < dtpHasta.Value)
            {
                string consulta = "select e.nombre, COUNT(v.id_empleado) from Venta v JOIN Empleado e ON v.id_empleado = e.id_empleado where v.fecha_venta between '" + dtpDesde.Value.ToShortDateString() + "' AND '" + dtpHasta.Value.ToShortDateString() + "'  GROUP BY e.nombre";
                EmpleadoBindingSource.DataSource = oDatos.consultarSQL(consulta);
                rpvReporte.RefreshReport();
            }
            else
                MessageBox.Show("La fecha Desde debe ser menor o fecha Hasta debe ser mayor.");
        }
    }
}
