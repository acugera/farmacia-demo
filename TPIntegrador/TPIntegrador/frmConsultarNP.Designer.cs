namespace TPIntegrador
{
    partial class frmConsultarNP
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvListado = new System.Windows.Forms.DataGridView();
            this.cmbCantidad = new System.Windows.Forms.ComboBox();
            this.cmbFecha = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbLaboratorio = new System.Windows.Forms.ComboBox();
            this.cmbMedicamento = new System.Windows.Forms.ComboBox();
            this.idpedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labcol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medicol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadcol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechacol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnListar = new System.Windows.Forms.Button();
            this.btnReporte = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbFecha);
            this.groupBox1.Controls.Add(this.cmbCantidad);
            this.groupBox1.Location = new System.Drawing.Point(12, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(555, 50);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ordenar:";
            // 
            // dgvListado
            // 
            this.dgvListado.AllowUserToAddRows = false;
            this.dgvListado.AllowUserToDeleteRows = false;
            this.dgvListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idpedido,
            this.labcol,
            this.medicol,
            this.cantidadcol,
            this.fechacol});
            this.dgvListado.Location = new System.Drawing.Point(12, 164);
            this.dgvListado.Name = "dgvListado";
            this.dgvListado.ReadOnly = true;
            this.dgvListado.Size = new System.Drawing.Size(555, 397);
            this.dgvListado.TabIndex = 1;
            // 
            // cmbCantidad
            // 
            this.cmbCantidad.FormattingEnabled = true;
            this.cmbCantidad.Items.AddRange(new object[] {
            "Ascendente",
            "Descendente"});
            this.cmbCantidad.Location = new System.Drawing.Point(112, 13);
            this.cmbCantidad.Name = "cmbCantidad";
            this.cmbCantidad.Size = new System.Drawing.Size(161, 21);
            this.cmbCantidad.TabIndex = 0;
            // 
            // cmbFecha
            // 
            this.cmbFecha.FormattingEnabled = true;
            this.cmbFecha.Items.AddRange(new object[] {
            "Ascendente",
            "Descendente"});
            this.cmbFecha.Location = new System.Drawing.Point(385, 13);
            this.cmbFecha.Name = "cmbFecha";
            this.cmbFecha.Size = new System.Drawing.Size(161, 21);
            this.cmbFecha.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cantidad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(298, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fecha";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.cmbLaboratorio);
            this.groupBox2.Controls.Add(this.cmbMedicamento);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(555, 50);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Buscar:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(298, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Laboratorio:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Medicamento:";
            // 
            // cmbLaboratorio
            // 
            this.cmbLaboratorio.FormattingEnabled = true;
            this.cmbLaboratorio.Location = new System.Drawing.Point(385, 13);
            this.cmbLaboratorio.Name = "cmbLaboratorio";
            this.cmbLaboratorio.Size = new System.Drawing.Size(161, 21);
            this.cmbLaboratorio.TabIndex = 1;
            // 
            // cmbMedicamento
            // 
            this.cmbMedicamento.FormattingEnabled = true;
            this.cmbMedicamento.Location = new System.Drawing.Point(112, 13);
            this.cmbMedicamento.Name = "cmbMedicamento";
            this.cmbMedicamento.Size = new System.Drawing.Size(161, 21);
            this.cmbMedicamento.TabIndex = 0;
            // 
            // idpedido
            // 
            this.idpedido.HeaderText = "Nro. de Pedido";
            this.idpedido.Name = "idpedido";
            this.idpedido.ReadOnly = true;
            // 
            // labcol
            // 
            this.labcol.HeaderText = "Laboratorio";
            this.labcol.Name = "labcol";
            this.labcol.ReadOnly = true;
            // 
            // medicol
            // 
            this.medicol.HeaderText = "Medicamento";
            this.medicol.Name = "medicol";
            this.medicol.ReadOnly = true;
            // 
            // cantidadcol
            // 
            this.cantidadcol.HeaderText = "Cantidad";
            this.cantidadcol.Name = "cantidadcol";
            this.cantidadcol.ReadOnly = true;
            // 
            // fechacol
            // 
            this.fechacol.HeaderText = "Fecha";
            this.fechacol.Name = "fechacol";
            this.fechacol.ReadOnly = true;
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(12, 135);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(555, 23);
            this.btnListar.TabIndex = 5;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // btnReporte
            // 
            this.btnReporte.Location = new System.Drawing.Point(377, 567);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(109, 23);
            this.btnReporte.TabIndex = 6;
            this.btnReporte.Text = "Generar Reporte";
            this.btnReporte.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(492, 567);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // frmConsultarNP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 598);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnReporte);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgvListado);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmConsultarNP";
            this.Text = "frmConsultarNP";
            this.Load += new System.EventHandler(this.frmConsultarNP_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvListado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbFecha;
        private System.Windows.Forms.ComboBox cmbCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn labcol;
        private System.Windows.Forms.DataGridViewTextBoxColumn medicol;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadcol;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechacol;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbLaboratorio;
        private System.Windows.Forms.ComboBox cmbMedicamento;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Button btnReporte;
        private System.Windows.Forms.Button btnSalir;
    }
}