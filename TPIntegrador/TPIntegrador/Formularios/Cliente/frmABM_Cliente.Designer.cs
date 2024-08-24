namespace TPIntegrador
{
    partial class frmABM_Cliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmABM_Cliente));
            this.label6 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.grpOpciones = new System.Windows.Forms.GroupBox();
            this.radEliminar = new System.Windows.Forms.RadioButton();
            this.radModificar = new System.Windows.Forms.RadioButton();
            this.radCrear = new System.Windows.Forms.RadioButton();
            this.lstCli = new System.Windows.Forms.ListBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.timBotones = new System.Windows.Forms.Timer(this.components);
            this.lstObra = new System.Windows.Forms.ListBox();
            this.btnAddObra = new System.Windows.Forms.Button();
            this.btnEditObra = new System.Windows.Forms.Button();
            this.btnDeleteObra = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblInfoObra = new System.Windows.Forms.Label();
            this.grpOpciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(70, 533);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 15);
            this.label6.TabIndex = 29;
            this.label6.Text = "Campos Obligatorios (*)";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(138, 562);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(101, 70);
            this.btnSalir.TabIndex = 24;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(31, 601);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(101, 31);
            this.btnCancelar.TabIndex = 23;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(31, 562);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(101, 31);
            this.btnConfirmar.TabIndex = 22;
            this.btnConfirmar.Text = "Guardar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // grpOpciones
            // 
            this.grpOpciones.Controls.Add(this.radEliminar);
            this.grpOpciones.Controls.Add(this.radModificar);
            this.grpOpciones.Controls.Add(this.radCrear);
            this.grpOpciones.Location = new System.Drawing.Point(17, 14);
            this.grpOpciones.Name = "grpOpciones";
            this.grpOpciones.Size = new System.Drawing.Size(474, 67);
            this.grpOpciones.TabIndex = 25;
            this.grpOpciones.TabStop = false;
            this.grpOpciones.Text = "Opciones:";
            // 
            // radEliminar
            // 
            this.radEliminar.AutoSize = true;
            this.radEliminar.Location = new System.Drawing.Point(397, 25);
            this.radEliminar.Name = "radEliminar";
            this.radEliminar.Size = new System.Drawing.Size(71, 19);
            this.radEliminar.TabIndex = 2;
            this.radEliminar.TabStop = true;
            this.radEliminar.Text = "Eliminar";
            this.radEliminar.UseVisualStyleBackColor = true;
            this.radEliminar.CheckedChanged += new System.EventHandler(this.radEliminar_CheckedChanged);
            // 
            // radModificar
            // 
            this.radModificar.AutoSize = true;
            this.radModificar.Location = new System.Drawing.Point(194, 25);
            this.radModificar.Name = "radModificar";
            this.radModificar.Size = new System.Drawing.Size(76, 19);
            this.radModificar.TabIndex = 1;
            this.radModificar.TabStop = true;
            this.radModificar.Text = "Modificar";
            this.radModificar.UseVisualStyleBackColor = true;
            this.radModificar.CheckedChanged += new System.EventHandler(this.radModificar_CheckedChanged);
            // 
            // radCrear
            // 
            this.radCrear.AutoSize = true;
            this.radCrear.Location = new System.Drawing.Point(8, 25);
            this.radCrear.Name = "radCrear";
            this.radCrear.Size = new System.Drawing.Size(55, 19);
            this.radCrear.TabIndex = 0;
            this.radCrear.TabStop = true;
            this.radCrear.Text = "Crear";
            this.radCrear.UseVisualStyleBackColor = true;
            this.radCrear.CheckedChanged += new System.EventHandler(this.radCrear_CheckedChanged);
            // 
            // lstCli
            // 
            this.lstCli.FormattingEnabled = true;
            this.lstCli.ItemHeight = 15;
            this.lstCli.Location = new System.Drawing.Point(270, 98);
            this.lstCli.Name = "lstCli";
            this.lstCli.Size = new System.Drawing.Size(221, 544);
            this.lstCli.TabIndex = 16;
            this.lstCli.SelectedIndexChanged += new System.EventHandler(this.lstCli_SelectedIndexChanged);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(34, 106);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(230, 21);
            this.txtNombre.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 15);
            this.label1.TabIndex = 31;
            this.label1.Text = "Nombre (*)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 33;
            this.label2.Text = "Apellido (*)";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(34, 151);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(230, 21);
            this.txtApellido.TabIndex = 32;
            // 
            // timBotones
            // 
            this.timBotones.Tick += new System.EventHandler(this.timBotones_Tick);
            // 
            // lstObra
            // 
            this.lstObra.FormattingEnabled = true;
            this.lstObra.ItemHeight = 15;
            this.lstObra.Location = new System.Drawing.Point(34, 193);
            this.lstObra.Name = "lstObra";
            this.lstObra.Size = new System.Drawing.Size(230, 214);
            this.lstObra.TabIndex = 49;
            // 
            // btnAddObra
            // 
            this.btnAddObra.Location = new System.Drawing.Point(34, 413);
            this.btnAddObra.Name = "btnAddObra";
            this.btnAddObra.Size = new System.Drawing.Size(230, 31);
            this.btnAddObra.TabIndex = 50;
            this.btnAddObra.Text = "Agregar Obra Social";
            this.btnAddObra.UseVisualStyleBackColor = true;
            this.btnAddObra.Click += new System.EventHandler(this.btnAddObra_Click);
            // 
            // btnEditObra
            // 
            this.btnEditObra.Location = new System.Drawing.Point(34, 450);
            this.btnEditObra.Name = "btnEditObra";
            this.btnEditObra.Size = new System.Drawing.Size(230, 31);
            this.btnEditObra.TabIndex = 52;
            this.btnEditObra.Text = "Editar Obra Social";
            this.btnEditObra.UseVisualStyleBackColor = true;
            this.btnEditObra.Click += new System.EventHandler(this.btnEditObra_Click);
            // 
            // btnDeleteObra
            // 
            this.btnDeleteObra.Location = new System.Drawing.Point(34, 487);
            this.btnDeleteObra.Name = "btnDeleteObra";
            this.btnDeleteObra.Size = new System.Drawing.Size(230, 31);
            this.btnDeleteObra.TabIndex = 53;
            this.btnDeleteObra.Text = "Eliminar Obra Social";
            this.btnDeleteObra.UseVisualStyleBackColor = true;
            this.btnDeleteObra.Click += new System.EventHandler(this.btnDeleteObra_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 15);
            this.label3.TabIndex = 54;
            this.label3.Text = "Obras Sociales";
            // 
            // lblInfoObra
            // 
            this.lblInfoObra.AutoSize = true;
            this.lblInfoObra.BackColor = System.Drawing.Color.White;
            this.lblInfoObra.Location = new System.Drawing.Point(39, 198);
            this.lblInfoObra.Name = "lblInfoObra";
            this.lblInfoObra.Size = new System.Drawing.Size(196, 30);
            this.lblInfoObra.TabIndex = 55;
            this.lblInfoObra.Text = "Primero se deve crear al cliente\r\nantes de agragarle Obras Sociales";
            // 
            // frmABM_Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 650);
            this.Controls.Add(this.lblInfoObra);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnDeleteObra);
            this.Controls.Add(this.btnEditObra);
            this.Controls.Add(this.btnAddObra);
            this.Controls.Add(this.lstObra);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.grpOpciones);
            this.Controls.Add(this.lstCli);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(515, 689);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(515, 689);
            this.Name = "frmABM_Cliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar Cliente";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmABM_Cliente_FormClosing);
            this.Load += new System.EventHandler(this.frmABM_Cliente_Load);
            this.grpOpciones.ResumeLayout(false);
            this.grpOpciones.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.GroupBox grpOpciones;
        private System.Windows.Forms.RadioButton radEliminar;
        private System.Windows.Forms.RadioButton radModificar;
        private System.Windows.Forms.RadioButton radCrear;
        private System.Windows.Forms.ListBox lstCli;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Timer timBotones;
        private System.Windows.Forms.ListBox lstObra;
        private System.Windows.Forms.Button btnAddObra;
        private System.Windows.Forms.Button btnEditObra;
        private System.Windows.Forms.Button btnDeleteObra;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblInfoObra;

    }
}