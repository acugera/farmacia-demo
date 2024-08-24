namespace TPIntegrador
{
    partial class frmConsula_Lab
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsula_Lab));
            this.dgvLab = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.trcSeleccionador = new System.Windows.Forms.TrackBar();
            this.grpBuscar = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.idLab = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreLab = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuitLab = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoLab = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLab)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trcSeleccionador)).BeginInit();
            this.grpBuscar.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvLab
            // 
            this.dgvLab.AllowUserToAddRows = false;
            this.dgvLab.AllowUserToDeleteRows = false;
            this.dgvLab.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLab.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idLab,
            this.nombreLab,
            this.cuitLab,
            this.telefonoLab});
            this.dgvLab.Location = new System.Drawing.Point(12, 130);
            this.dgvLab.Name = "dgvLab";
            this.dgvLab.ReadOnly = true;
            this.dgvLab.Size = new System.Drawing.Size(752, 303);
            this.dgvLab.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID Laboratorio";
            // 
            // trcSeleccionador
            // 
            this.trcSeleccionador.Location = new System.Drawing.Point(6, 19);
            this.trcSeleccionador.Maximum = 3;
            this.trcSeleccionador.Name = "trcSeleccionador";
            this.trcSeleccionador.Size = new System.Drawing.Size(740, 45);
            this.trcSeleccionador.TabIndex = 0;
            this.trcSeleccionador.Scroll += new System.EventHandler(this.trcSeleccionador_Scroll);
            // 
            // grpBuscar
            // 
            this.grpBuscar.Controls.Add(this.label4);
            this.grpBuscar.Controls.Add(this.label3);
            this.grpBuscar.Controls.Add(this.label2);
            this.grpBuscar.Controls.Add(this.label1);
            this.grpBuscar.Controls.Add(this.trcSeleccionador);
            this.grpBuscar.Location = new System.Drawing.Point(12, 12);
            this.grpBuscar.Name = "grpBuscar";
            this.grpBuscar.Size = new System.Drawing.Size(752, 67);
            this.grpBuscar.TabIndex = 0;
            this.grpBuscar.TabStop = false;
            this.grpBuscar.Text = "Buscar por:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(697, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Telefono";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(480, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "CUIT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(238, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre";
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusqueda.Location = new System.Drawing.Point(12, 90);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(707, 26);
            this.txtBusqueda.TabIndex = 1;
            this.txtBusqueda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBusqueda_KeyPress);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(689, 439);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.Location = new System.Drawing.Point(725, 85);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(39, 39);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // idLab
            // 
            this.idLab.HeaderText = "Num. Laboratorio";
            this.idLab.Name = "idLab";
            this.idLab.ReadOnly = true;
            // 
            // nombreLab
            // 
            this.nombreLab.HeaderText = "Nombre";
            this.nombreLab.Name = "nombreLab";
            this.nombreLab.ReadOnly = true;
            this.nombreLab.Width = 200;
            // 
            // cuitLab
            // 
            this.cuitLab.HeaderText = "CUIT";
            this.cuitLab.Name = "cuitLab";
            this.cuitLab.ReadOnly = true;
            this.cuitLab.Width = 200;
            // 
            // telefonoLab
            // 
            this.telefonoLab.HeaderText = "Telefono";
            this.telefonoLab.Name = "telefonoLab";
            this.telefonoLab.ReadOnly = true;
            this.telefonoLab.Width = 200;
            // 
            // frmConsula_Lab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 466);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBusqueda);
            this.Controls.Add(this.grpBuscar);
            this.Controls.Add(this.dgvLab);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(786, 505);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(786, 505);
            this.Name = "frmConsula_Lab";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar Laboratorios";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmConsula_Lab_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLab)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trcSeleccionador)).EndInit();
            this.grpBuscar.ResumeLayout(false);
            this.grpBuscar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLab;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar trcSeleccionador;
        private System.Windows.Forms.GroupBox grpBuscar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridViewTextBoxColumn idLab;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreLab;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuitLab;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoLab;
    }
}