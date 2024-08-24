namespace TPIntegrador
{
    partial class frmDetalleCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDetalleCliente));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblID = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.dgvObra = new System.Windows.Forms.DataGridView();
            this.fgdsf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvObra)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblNom);
            this.groupBox1.Controls.Add(this.lblID);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(350, 67);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Personales";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvObra);
            this.groupBox2.Location = new System.Drawing.Point(12, 85);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(350, 291);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos de Obras Sociales";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(6, 21);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(21, 13);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "ID:";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(6, 43);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(94, 13);
            this.lblNom.TabIndex = 1;
            this.lblNom.Text = "Nombre Completo:";
            // 
            // dgvObra
            // 
            this.dgvObra.AllowUserToAddRows = false;
            this.dgvObra.AllowUserToDeleteRows = false;
            this.dgvObra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvObra.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fgdsf,
            this.Column1});
            this.dgvObra.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvObra.Location = new System.Drawing.Point(3, 16);
            this.dgvObra.Name = "dgvObra";
            this.dgvObra.ReadOnly = true;
            this.dgvObra.Size = new System.Drawing.Size(344, 272);
            this.dgvObra.TabIndex = 0;
            // 
            // fgdsf
            // 
            this.fgdsf.HeaderText = "Obra Social";
            this.fgdsf.Name = "fgdsf";
            this.fgdsf.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Nro. Obra Social";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 200;
            // 
            // frmDetalleCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 385);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(385, 424);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(385, 424);
            this.Name = "frmDetalleCliente";
            this.Text = "Detalle del Cliente:";
            this.Load += new System.EventHandler(this.frmDetalleCliente_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvObra)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvObra;
        private System.Windows.Forms.DataGridViewTextBoxColumn fgdsf;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}