namespace TPIntegrador
{
    partial class frmConsultaMedicamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultaMedicamento));
            this.chkReceta = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbMedicamento = new System.Windows.Forms.ComboBox();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dgvMedicamento = new System.Windows.Forms.DataGridView();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.droga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.laboratorio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockReal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicamento)).BeginInit();
            this.SuspendLayout();
            // 
            // chkReceta
            // 
            this.chkReceta.AutoSize = true;
            this.chkReceta.Location = new System.Drawing.Point(72, 39);
            this.chkReceta.Name = "chkReceta";
            this.chkReceta.Size = new System.Drawing.Size(78, 17);
            this.chkReceta.TabIndex = 0;
            this.chkReceta.Text = "Con receta";
            this.chkReceta.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Buscar por:";
            // 
            // cmbMedicamento
            // 
            this.cmbMedicamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMedicamento.FormattingEnabled = true;
            this.cmbMedicamento.Items.AddRange(new object[] {
            "Nombre",
            "Droga",
            "Laboratorio",
            "Todos"});
            this.cmbMedicamento.Location = new System.Drawing.Point(72, 12);
            this.cmbMedicamento.Name = "cmbMedicamento";
            this.cmbMedicamento.Size = new System.Drawing.Size(164, 21);
            this.cmbMedicamento.TabIndex = 2;
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Location = new System.Drawing.Point(242, 13);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(158, 20);
            this.txtBusqueda.TabIndex = 3;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(406, 13);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(65, 21);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dgvMedicamento
            // 
            this.dgvMedicamento.AllowUserToAddRows = false;
            this.dgvMedicamento.AllowUserToDeleteRows = false;
            this.dgvMedicamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedicamento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombre,
            this.droga,
            this.laboratorio,
            this.receta,
            this.precio,
            this.stockReal});
            this.dgvMedicamento.Location = new System.Drawing.Point(12, 62);
            this.dgvMedicamento.Name = "dgvMedicamento";
            this.dgvMedicamento.ReadOnly = true;
            this.dgvMedicamento.Size = new System.Drawing.Size(524, 198);
            this.dgvMedicamento.TabIndex = 5;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(461, 288);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 6;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Width = 80;
            // 
            // droga
            // 
            this.droga.HeaderText = "Droga";
            this.droga.Name = "droga";
            this.droga.ReadOnly = true;
            this.droga.Width = 80;
            // 
            // laboratorio
            // 
            this.laboratorio.HeaderText = "Laboratorio";
            this.laboratorio.Name = "laboratorio";
            this.laboratorio.ReadOnly = true;
            this.laboratorio.Width = 90;
            // 
            // receta
            // 
            this.receta.HeaderText = "Receta";
            this.receta.Name = "receta";
            this.receta.ReadOnly = true;
            this.receta.Width = 75;
            // 
            // precio
            // 
            this.precio.HeaderText = "Precio";
            this.precio.Name = "precio";
            this.precio.ReadOnly = true;
            this.precio.Width = 75;
            // 
            // stockReal
            // 
            this.stockReal.HeaderText = "Stock Real";
            this.stockReal.Name = "stockReal";
            this.stockReal.ReadOnly = true;
            this.stockReal.Width = 80;
            // 
            // frmConsultaMedicamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 323);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.dgvMedicamento);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBusqueda);
            this.Controls.Add(this.cmbMedicamento);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chkReceta);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(558, 362);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(558, 362);
            this.Name = "frmConsultaMedicamento";
            this.Text = "Consultar Medicamentos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmConsultaMedicamento_FormClosing);
            this.Load += new System.EventHandler(this.frmConsultaMedicamento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicamento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkReceta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbMedicamento;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dgvMedicamento;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn droga;
        private System.Windows.Forms.DataGridViewTextBoxColumn laboratorio;
        private System.Windows.Forms.DataGridViewTextBoxColumn receta;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockReal;
    }
}