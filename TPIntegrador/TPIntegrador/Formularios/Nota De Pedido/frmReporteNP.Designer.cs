namespace TPIntegrador
{
    partial class frmReporteNP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReporteNP));
            this.NpTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsNP = new TPIntegrador.dsNP();
            this.rpvReporte = new Microsoft.Reporting.WinForms.ReportViewer();
            this.NpTableTableAdapter = new TPIntegrador.dsNPTableAdapters.NpTableTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.NpTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNP)).BeginInit();
            this.SuspendLayout();
            // 
            // NpTableBindingSource
            // 
            this.NpTableBindingSource.DataMember = "NpTable";
            this.NpTableBindingSource.DataSource = this.dsNP;
            // 
            // dsNP
            // 
            this.dsNP.DataSetName = "dsNP";
            this.dsNP.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rpvReporte
            // 
            this.rpvReporte.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "dsNP";
            reportDataSource1.Value = this.NpTableBindingSource;
            this.rpvReporte.LocalReport.DataSources.Add(reportDataSource1);
            this.rpvReporte.LocalReport.ReportEmbeddedResource = "TPIntegrador.Reportes.rptNP.rdlc";
            this.rpvReporte.Location = new System.Drawing.Point(0, 0);
            this.rpvReporte.Name = "rpvReporte";
            this.rpvReporte.Size = new System.Drawing.Size(742, 750);
            this.rpvReporte.TabIndex = 0;
            // 
            // NpTableTableAdapter
            // 
            this.NpTableTableAdapter.ClearBeforeFill = true;
            // 
            // frmReporteNP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 750);
            this.Controls.Add(this.rpvReporte);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(758, 789);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(758, 789);
            this.Name = "frmReporteNP";
            this.Text = "Reporte Nota de Pedido";
            this.Load += new System.EventHandler(this.frmReporteNP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NpTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpvReporte;
        private System.Windows.Forms.BindingSource NpTableBindingSource;
        private dsNP dsNP;
        private dsNPTableAdapters.NpTableTableAdapter NpTableTableAdapter;
    }
}