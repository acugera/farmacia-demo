namespace TPIntegrador
{
    partial class frmConsultaObraSocial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultaObraSocial));
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.cmbBuscar = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCuit = new System.Windows.Forms.Label();
            this.lblTipoCuit = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCuit = new System.Windows.Forms.TextBox();
            this.txtTipoCuit = new System.Windows.Forms.TextBox();
            this.dgvObraSocial = new System.Windows.Forms.DataGridView();
            this.nroObraSocial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoCuit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblNumero = new System.Windows.Forms.Label();
            this.txtNroObraSocial = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvObraSocial)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(79, 72);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(124, 23);
            this.btnBuscar.TabIndex = 5;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Visible = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(12, 205);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Salir";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // cmbBuscar
            // 
            this.cmbBuscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBuscar.FormattingEnabled = true;
            this.cmbBuscar.Items.AddRange(new object[] {
            "Nro. Obra Social",
            "Nombre",
            "CUIT",
            "Tipo de Cuit",
            "Todos"});
            this.cmbBuscar.Location = new System.Drawing.Point(79, 21);
            this.cmbBuscar.Name = "cmbBuscar";
            this.cmbBuscar.Size = new System.Drawing.Size(124, 21);
            this.cmbBuscar.TabIndex = 0;
            this.cmbBuscar.SelectedIndexChanged += new System.EventHandler(this.cmbBuscar_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Buscar por:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(26, 49);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 4;
            this.lblNombre.Text = "Nombre:";
            this.lblNombre.Visible = false;
            // 
            // lblCuit
            // 
            this.lblCuit.AutoSize = true;
            this.lblCuit.Location = new System.Drawing.Point(38, 49);
            this.lblCuit.Name = "lblCuit";
            this.lblCuit.Size = new System.Drawing.Size(35, 13);
            this.lblCuit.TabIndex = 5;
            this.lblCuit.Text = "CUIT:";
            this.lblCuit.Visible = false;
            // 
            // lblTipoCuit
            // 
            this.lblTipoCuit.AutoSize = true;
            this.lblTipoCuit.Location = new System.Drawing.Point(21, 49);
            this.lblTipoCuit.Name = "lblTipoCuit";
            this.lblTipoCuit.Size = new System.Drawing.Size(52, 13);
            this.lblTipoCuit.TabIndex = 6;
            this.lblTipoCuit.Text = "Tipo Cuit:";
            this.lblTipoCuit.Visible = false;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(79, 46);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(124, 20);
            this.txtNombre.TabIndex = 2;
            this.txtNombre.Visible = false;
            // 
            // txtCuit
            // 
            this.txtCuit.Location = new System.Drawing.Point(79, 46);
            this.txtCuit.Name = "txtCuit";
            this.txtCuit.Size = new System.Drawing.Size(124, 20);
            this.txtCuit.TabIndex = 3;
            this.txtCuit.Visible = false;
            this.txtCuit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCuit_KeyPress);
            // 
            // txtTipoCuit
            // 
            this.txtTipoCuit.Location = new System.Drawing.Point(79, 46);
            this.txtTipoCuit.Name = "txtTipoCuit";
            this.txtTipoCuit.Size = new System.Drawing.Size(124, 20);
            this.txtTipoCuit.TabIndex = 4;
            this.txtTipoCuit.Visible = false;
            // 
            // dgvObraSocial
            // 
            this.dgvObraSocial.AllowUserToAddRows = false;
            this.dgvObraSocial.AllowUserToDeleteRows = false;
            this.dgvObraSocial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvObraSocial.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nroObraSocial,
            this.nombre,
            this.cuit,
            this.tipoCuit});
            this.dgvObraSocial.Location = new System.Drawing.Point(209, 12);
            this.dgvObraSocial.Name = "dgvObraSocial";
            this.dgvObraSocial.ReadOnly = true;
            this.dgvObraSocial.Size = new System.Drawing.Size(409, 216);
            this.dgvObraSocial.TabIndex = 10;
            // 
            // nroObraSocial
            // 
            this.nroObraSocial.HeaderText = "Nro. Obra Social";
            this.nroObraSocial.Name = "nroObraSocial";
            this.nroObraSocial.ReadOnly = true;
            this.nroObraSocial.Width = 60;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // cuit
            // 
            this.cuit.HeaderText = "CUIT";
            this.cuit.Name = "cuit";
            this.cuit.ReadOnly = true;
            // 
            // tipoCuit
            // 
            this.tipoCuit.HeaderText = "Tipo de Cuit";
            this.tipoCuit.Name = "tipoCuit";
            this.tipoCuit.ReadOnly = true;
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(26, 49);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(47, 13);
            this.lblNumero.TabIndex = 11;
            this.lblNumero.Text = "Número:";
            this.lblNumero.Visible = false;
            // 
            // txtNroObraSocial
            // 
            this.txtNroObraSocial.Location = new System.Drawing.Point(79, 46);
            this.txtNroObraSocial.Name = "txtNroObraSocial";
            this.txtNroObraSocial.Size = new System.Drawing.Size(124, 20);
            this.txtNroObraSocial.TabIndex = 1;
            this.txtNroObraSocial.Visible = false;
            this.txtNroObraSocial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNroObraSocial_KeyPress);
            // 
            // frmConsultaObraSocial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 237);
            this.Controls.Add(this.txtNroObraSocial);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.dgvObraSocial);
            this.Controls.Add(this.txtTipoCuit);
            this.Controls.Add(this.txtCuit);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblTipoCuit);
            this.Controls.Add(this.lblCuit);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbBuscar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnBuscar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(646, 276);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(646, 276);
            this.Name = "frmConsultaObraSocial";
            this.Text = "Consulta Obras Sociales";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmConsultaObraSocial_FormClosing);
            this.Load += new System.EventHandler(this.frmConsultaObraSocial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvObraSocial)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ComboBox cmbBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCuit;
        private System.Windows.Forms.Label lblTipoCuit;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCuit;
        private System.Windows.Forms.TextBox txtTipoCuit;
        private System.Windows.Forms.DataGridView dgvObraSocial;
        private System.Windows.Forms.DataGridViewTextBoxColumn nroObraSocial;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuit;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoCuit;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.TextBox txtNroObraSocial;
    }
}