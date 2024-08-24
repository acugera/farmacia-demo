namespace TPIntegrador
{
    partial class frmConsulta_Cliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsulta_Cliente));
            this.cmbTip = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBus = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvLIST = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBusc = new System.Windows.Forms.Button();
            this.btnDet = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLIST)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbTip
            // 
            this.cmbTip.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTip.FormattingEnabled = true;
            this.cmbTip.Items.AddRange(new object[] {
            "ID",
            "Nombre",
            "Apellido"});
            this.cmbTip.Location = new System.Drawing.Point(386, 13);
            this.cmbTip.Margin = new System.Windows.Forms.Padding(4);
            this.cmbTip.Name = "cmbTip";
            this.cmbTip.Size = new System.Drawing.Size(166, 24);
            this.cmbTip.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Buscar Cliente:";
            // 
            // txtBus
            // 
            this.txtBus.Location = new System.Drawing.Point(129, 13);
            this.txtBus.Margin = new System.Windows.Forms.Padding(4);
            this.txtBus.Name = "txtBus";
            this.txtBus.Size = new System.Drawing.Size(172, 22);
            this.txtBus.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(309, 16);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "que es su:";
            // 
            // dgvLIST
            // 
            this.dgvLIST.AllowUserToAddRows = false;
            this.dgvLIST.AllowUserToDeleteRows = false;
            this.dgvLIST.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLIST.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvLIST.Location = new System.Drawing.Point(9, 71);
            this.dgvLIST.Name = "dgvLIST";
            this.dgvLIST.ReadOnly = true;
            this.dgvLIST.Size = new System.Drawing.Size(543, 250);
            this.dgvLIST.TabIndex = 5;
            this.dgvLIST.SelectionChanged += new System.EventHandler(this.dgvLIST_SelectionChanged);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nombre";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 200;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Apellido";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 200;
            // 
            // btnBusc
            // 
            this.btnBusc.Location = new System.Drawing.Point(9, 42);
            this.btnBusc.Name = "btnBusc";
            this.btnBusc.Size = new System.Drawing.Size(543, 23);
            this.btnBusc.TabIndex = 6;
            this.btnBusc.Text = "Buscar";
            this.btnBusc.UseVisualStyleBackColor = true;
            this.btnBusc.Click += new System.EventHandler(this.btnBusc_Click);
            // 
            // btnDet
            // 
            this.btnDet.Enabled = false;
            this.btnDet.Location = new System.Drawing.Point(9, 329);
            this.btnDet.Name = "btnDet";
            this.btnDet.Size = new System.Drawing.Size(543, 23);
            this.btnDet.TabIndex = 7;
            this.btnDet.Text = "Ver Detalle del Cliente";
            this.btnDet.UseVisualStyleBackColor = true;
            this.btnDet.Click += new System.EventHandler(this.btnDet_Click);
            // 
            // frmConsulta_Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 359);
            this.Controls.Add(this.dgvLIST);
            this.Controls.Add(this.btnDet);
            this.Controls.Add(this.btnBusc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbTip);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(573, 398);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(573, 398);
            this.Name = "frmConsulta_Cliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Clientes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmConsulta_Cliente_FormClosing);
            this.Load += new System.EventHandler(this.frmConsulta_Cliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLIST)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbTip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvLIST;
        private System.Windows.Forms.Button btnBusc;
        private System.Windows.Forms.Button btnDet;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;

    }
}