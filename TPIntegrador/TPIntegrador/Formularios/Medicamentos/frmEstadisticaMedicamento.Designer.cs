namespace TPIntegrador
{
    partial class frmEstadisticaMedicamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEstadisticaMedicamento));
            this.MedicamentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsEstadisticaMedicamento = new TPIntegrador.dsEstadisticaMedicamento();
            this.rpvReporte = new Microsoft.Reporting.WinForms.ReportViewer();
            this.MedicamentoTableAdapter = new TPIntegrador.dsEstadisticaMedicamentoTableAdapters.MedicamentoTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.MedicamentoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsEstadisticaMedicamento)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MedicamentoBindingSource
            // 
            this.MedicamentoBindingSource.DataMember = "Medicamento";
            this.MedicamentoBindingSource.DataSource = this.dsEstadisticaMedicamento;
            // 
            // dsEstadisticaMedicamento
            // 
            this.dsEstadisticaMedicamento.DataSetName = "dsEstadisticaMedicamento";
            this.dsEstadisticaMedicamento.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rpvReporte
            // 
            reportDataSource1.Name = "dsEstadisticaMedicamento";
            reportDataSource1.Value = this.MedicamentoBindingSource;
            this.rpvReporte.LocalReport.DataSources.Add(reportDataSource1);
            this.rpvReporte.LocalReport.ReportEmbeddedResource = "TPIntegrador.Reportes.rptEstadisticaMedicamento.rdlc";
            this.rpvReporte.Location = new System.Drawing.Point(0, 65);
            this.rpvReporte.Name = "rpvReporte";
            this.rpvReporte.Size = new System.Drawing.Size(472, 400);
            this.rpvReporte.TabIndex = 0;
            // 
            // MedicamentoTableAdapter
            // 
            this.MedicamentoTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnFiltrar);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtpHasta);
            this.groupBox1.Controls.Add(this.dtpDesde);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(448, 47);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(385, 18);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(57, 20);
            this.btnFiltrar.TabIndex = 4;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(193, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fecha Hasta:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Fecha desde:";
            // 
            // dtpHasta
            // 
            this.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHasta.Location = new System.Drawing.Point(270, 19);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(109, 20);
            this.dtpHasta.TabIndex = 1;
            // 
            // dtpDesde
            // 
            this.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDesde.Location = new System.Drawing.Point(89, 19);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(98, 20);
            this.dtpDesde.TabIndex = 0;
            // 
            // frmEstadisticaMedicamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 465);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.rpvReporte);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(488, 504);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(488, 504);
            this.Name = "frmEstadisticaMedicamento";
            this.Text = "Estadistica Medicamentos";
            this.Load += new System.EventHandler(this.frmEstadisticaMedicamento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MedicamentoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsEstadisticaMedicamento)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpvReporte;
        private System.Windows.Forms.BindingSource MedicamentoBindingSource;
        private dsEstadisticaMedicamento dsEstadisticaMedicamento;
        private dsEstadisticaMedicamentoTableAdapters.MedicamentoTableAdapter MedicamentoTableAdapter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.DateTimePicker dtpDesde;
    }
}