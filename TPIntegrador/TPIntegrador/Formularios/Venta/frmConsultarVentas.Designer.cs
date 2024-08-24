namespace TPIntegrador
{
    partial class frmConsultarVentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultarVentas));
            this.txtMin = new System.Windows.Forms.TextBox();
            this.txtMax = new System.Windows.Forms.TextBox();
            this.cmbTipoF = new System.Windows.Forms.ComboBox();
            this.cmbPre = new System.Windows.Forms.ComboBox();
            this.cmbFech = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvVentas = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnLISTAR = new System.Windows.Forms.Button();
            this.btnREPORTE = new System.Windows.Forms.Button();
            this.btnSALIR = new System.Windows.Forms.Button();
            this.tmrAux = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMin
            // 
            this.txtMin.Location = new System.Drawing.Point(349, 16);
            this.txtMin.Name = "txtMin";
            this.txtMin.Size = new System.Drawing.Size(100, 20);
            this.txtMin.TabIndex = 0;
            // 
            // txtMax
            // 
            this.txtMax.Location = new System.Drawing.Point(537, 16);
            this.txtMax.Name = "txtMax";
            this.txtMax.Size = new System.Drawing.Size(100, 20);
            this.txtMax.TabIndex = 1;
            // 
            // cmbTipoF
            // 
            this.cmbTipoF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoF.FormattingEnabled = true;
            this.cmbTipoF.Items.AddRange(new object[] {
            "",
            "A",
            "B",
            "C"});
            this.cmbTipoF.Location = new System.Drawing.Point(163, 16);
            this.cmbTipoF.Name = "cmbTipoF";
            this.cmbTipoF.Size = new System.Drawing.Size(55, 21);
            this.cmbTipoF.TabIndex = 2;
            // 
            // cmbPre
            // 
            this.cmbPre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPre.FormattingEnabled = true;
            this.cmbPre.Items.AddRange(new object[] {
            "Ascendente",
            "Descendente"});
            this.cmbPre.Location = new System.Drawing.Point(97, 19);
            this.cmbPre.Name = "cmbPre";
            this.cmbPre.Size = new System.Drawing.Size(121, 21);
            this.cmbPre.TabIndex = 3;
            // 
            // cmbFech
            // 
            this.cmbFech.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFech.FormattingEnabled = true;
            this.cmbFech.Items.AddRange(new object[] {
            "Ascendente",
            "Descendente"});
            this.cmbFech.Location = new System.Drawing.Point(423, 19);
            this.cmbFech.Name = "cmbFech";
            this.cmbFech.Size = new System.Drawing.Size(121, 21);
            this.cmbFech.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmbTipoF);
            this.groupBox1.Controls.Add(this.txtMax);
            this.groupBox1.Controls.Add(this.txtMin);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(643, 50);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtrar por:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(270, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Precio Minimo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(455, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Precio Maximo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tipo de Factura:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cmbPre);
            this.groupBox2.Controls.Add(this.cmbFech);
            this.groupBox2.Location = new System.Drawing.Point(12, 68);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(638, 51);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ordenar por:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(374, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Fecha:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Precio:";
            // 
            // dgvVentas
            // 
            this.dgvVentas.AllowUserToAddRows = false;
            this.dgvVentas.AllowUserToDeleteRows = false;
            this.dgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dgvVentas.Location = new System.Drawing.Point(12, 154);
            this.dgvVentas.Name = "dgvVentas";
            this.dgvVentas.ReadOnly = true;
            this.dgvVentas.Size = new System.Drawing.Size(643, 340);
            this.dgvVentas.TabIndex = 7;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Nro. Venta";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Empleado";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Cliente";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Total de Venta";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Tipo de Factura";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Fecha";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // btnLISTAR
            // 
            this.btnLISTAR.Location = new System.Drawing.Point(12, 125);
            this.btnLISTAR.Name = "btnLISTAR";
            this.btnLISTAR.Size = new System.Drawing.Size(643, 23);
            this.btnLISTAR.TabIndex = 8;
            this.btnLISTAR.Text = "Listar";
            this.btnLISTAR.UseVisualStyleBackColor = true;
            this.btnLISTAR.Click += new System.EventHandler(this.btnLISTAR_Click);
            // 
            // btnREPORTE
            // 
            this.btnREPORTE.Location = new System.Drawing.Point(12, 500);
            this.btnREPORTE.Name = "btnREPORTE";
            this.btnREPORTE.Size = new System.Drawing.Size(643, 23);
            this.btnREPORTE.TabIndex = 9;
            this.btnREPORTE.Text = "Generar Reporte";
            this.btnREPORTE.UseVisualStyleBackColor = true;
            this.btnREPORTE.Click += new System.EventHandler(this.btnREPORTE_Click);
            // 
            // btnSALIR
            // 
            this.btnSALIR.Location = new System.Drawing.Point(12, 529);
            this.btnSALIR.Name = "btnSALIR";
            this.btnSALIR.Size = new System.Drawing.Size(643, 23);
            this.btnSALIR.TabIndex = 10;
            this.btnSALIR.Text = "Salir";
            this.btnSALIR.UseVisualStyleBackColor = true;
            this.btnSALIR.Click += new System.EventHandler(this.btnSALIR_Click);
            // 
            // tmrAux
            // 
            this.tmrAux.Tick += new System.EventHandler(this.tmrAux_Tick);
            // 
            // frmConsultarVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 558);
            this.Controls.Add(this.btnSALIR);
            this.Controls.Add(this.btnREPORTE);
            this.Controls.Add(this.btnLISTAR);
            this.Controls.Add(this.dgvVentas);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(678, 597);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(678, 597);
            this.Name = "frmConsultarVentas";
            this.Text = "Consultar Ventas";
            this.Load += new System.EventHandler(this.frmConsultarVentas_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtMin;
        private System.Windows.Forms.TextBox txtMax;
        private System.Windows.Forms.ComboBox cmbTipoF;
        private System.Windows.Forms.ComboBox cmbPre;
        private System.Windows.Forms.ComboBox cmbFech;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvVentas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Button btnLISTAR;
        private System.Windows.Forms.Button btnREPORTE;
        private System.Windows.Forms.Button btnSALIR;
        private System.Windows.Forms.Timer tmrAux;
    }
}