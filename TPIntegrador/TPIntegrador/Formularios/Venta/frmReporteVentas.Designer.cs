namespace TPIntegrador
{
    partial class frmReporteVentas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReporteVentas));
            this.VentaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsVentas = new TPIntegrador.dsVentas();
            this.rpvReporte = new Microsoft.Reporting.WinForms.ReportViewer();
            this.VentaTableAdapter = new TPIntegrador.dsVentasTableAdapters.VentaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.VentaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // VentaBindingSource
            // 
            this.VentaBindingSource.DataMember = "Venta";
            this.VentaBindingSource.DataSource = this.dsVentas;
            // 
            // dsVentas
            // 
            this.dsVentas.DataSetName = "dsVentas";
            this.dsVentas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rpvReporte
            // 
            this.rpvReporte.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "dsVentas";
            reportDataSource1.Value = this.VentaBindingSource;
            this.rpvReporte.LocalReport.DataSources.Add(reportDataSource1);
            this.rpvReporte.LocalReport.ReportEmbeddedResource = "TPIntegrador.Reportes.rptVentas.rdlc";
            this.rpvReporte.Location = new System.Drawing.Point(0, 0);
            this.rpvReporte.Name = "rpvReporte";
            this.rpvReporte.Size = new System.Drawing.Size(742, 749);
            this.rpvReporte.TabIndex = 0;
            // 
            // VentaTableAdapter
            // 
            this.VentaTableAdapter.ClearBeforeFill = true;
            // 
            // frmReporteVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 749);
            this.Controls.Add(this.rpvReporte);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(758, 789);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(758, 726);
            this.Name = "frmReporteVentas";
            this.Text = "Reporte Ventas";
            this.Load += new System.EventHandler(this.frmReporte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.VentaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsVentas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpvReporte;
        private System.Windows.Forms.BindingSource VentaBindingSource;
        private dsVentas dsVentas;
        private dsVentasTableAdapters.VentaTableAdapter VentaTableAdapter;





    }
}