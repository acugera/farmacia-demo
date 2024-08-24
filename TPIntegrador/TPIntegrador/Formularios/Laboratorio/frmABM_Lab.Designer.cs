namespace TPIntegrador
{
    partial class frmABM_Lab
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmABM_Lab));
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCuitC = new System.Windows.Forms.TextBox();
            this.txtCuitB = new System.Windows.Forms.TextBox();
            this.txtCuitA = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lstLab = new System.Windows.Forms.ListBox();
            this.grpOpciones = new System.Windows.Forms.GroupBox();
            this.radEliminar = new System.Windows.Forms.RadioButton();
            this.radModificar = new System.Windows.Forms.RadioButton();
            this.radCrear = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.timBotones = new System.Windows.Forms.Timer(this.components);
            this.grpOpciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(14, 127);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(169, 21);
            this.txtNombre.TabIndex = 1;
            // 
            // txtCuitC
            // 
            this.txtCuitC.Location = new System.Drawing.Point(159, 172);
            this.txtCuitC.MaxLength = 1;
            this.txtCuitC.Name = "txtCuitC";
            this.txtCuitC.Size = new System.Drawing.Size(22, 21);
            this.txtCuitC.TabIndex = 4;
            this.txtCuitC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCuitA_KeyPress);
            // 
            // txtCuitB
            // 
            this.txtCuitB.Location = new System.Drawing.Point(66, 172);
            this.txtCuitB.MaxLength = 8;
            this.txtCuitB.Name = "txtCuitB";
            this.txtCuitB.Size = new System.Drawing.Size(64, 21);
            this.txtCuitB.TabIndex = 3;
            this.txtCuitB.TextChanged += new System.EventHandler(this.txtCuitB_TextChanged);
            this.txtCuitB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCuitB_KeyPress);
            // 
            // txtCuitA
            // 
            this.txtCuitA.Location = new System.Drawing.Point(12, 172);
            this.txtCuitA.MaxLength = 2;
            this.txtCuitA.Name = "txtCuitA";
            this.txtCuitA.Size = new System.Drawing.Size(24, 21);
            this.txtCuitA.TabIndex = 2;
            this.txtCuitA.TextChanged += new System.EventHandler(this.txtCuitA_TextChanged);
            this.txtCuitA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCuitC_KeyPress);
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(14, 217);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(169, 21);
            this.txtTelefono.TabIndex = 5;
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefono_KeyPress);
            // 
            // lstLab
            // 
            this.lstLab.FormattingEnabled = true;
            this.lstLab.ItemHeight = 15;
            this.lstLab.Location = new System.Drawing.Point(189, 78);
            this.lstLab.Name = "lstLab";
            this.lstLab.Size = new System.Drawing.Size(174, 349);
            this.lstLab.TabIndex = 0;
            this.lstLab.SelectedIndexChanged += new System.EventHandler(this.lstLab_SelectedIndexChanged);
            // 
            // grpOpciones
            // 
            this.grpOpciones.Controls.Add(this.radEliminar);
            this.grpOpciones.Controls.Add(this.radModificar);
            this.grpOpciones.Controls.Add(this.radCrear);
            this.grpOpciones.Location = new System.Drawing.Point(14, 14);
            this.grpOpciones.Name = "grpOpciones";
            this.grpOpciones.Size = new System.Drawing.Size(349, 58);
            this.grpOpciones.TabIndex = 9;
            this.grpOpciones.TabStop = false;
            this.grpOpciones.Text = "Opciones:";
            // 
            // radEliminar
            // 
            this.radEliminar.AutoSize = true;
            this.radEliminar.Location = new System.Drawing.Point(272, 22);
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
            this.radModificar.Location = new System.Drawing.Point(131, 22);
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
            this.radCrear.Location = new System.Drawing.Point(7, 22);
            this.radCrear.Name = "radCrear";
            this.radCrear.Size = new System.Drawing.Size(55, 19);
            this.radCrear.TabIndex = 0;
            this.radCrear.TabStop = true;
            this.radCrear.Text = "Crear";
            this.radCrear.UseVisualStyleBackColor = true;
            this.radCrear.CheckedChanged += new System.EventHandler(this.radCrear_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Nombre (*)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "CUIT (*)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(11, 15);
            this.label3.TabIndex = 14;
            this.label3.Text = "-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(138, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(11, 15);
            this.label4.TabIndex = 15;
            this.label4.Text = "-";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Telefono";
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(48, 285);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(87, 27);
            this.btnConfirmar.TabIndex = 6;
            this.btnConfirmar.Text = "Guardar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(48, 319);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(87, 27);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(48, 352);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(87, 61);
            this.btnSalir.TabIndex = 8;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 258);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "Campos Obligatorios (*)";
            // 
            // timBotones
            // 
            this.timBotones.Tick += new System.EventHandler(this.timBotones_Tick);
            // 
            // frmABM_Lab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 435);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grpOpciones);
            this.Controls.Add(this.lstLab);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtCuitA);
            this.Controls.Add(this.txtCuitB);
            this.Controls.Add(this.txtCuitC);
            this.Controls.Add(this.txtNombre);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(390, 474);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(390, 474);
            this.Name = "frmABM_Lab";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar Laboratorio";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmABM_Lab_FormClosing);
            this.Load += new System.EventHandler(this.frmABM_Lab_Load);
            this.grpOpciones.ResumeLayout(false);
            this.grpOpciones.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCuitC;
        private System.Windows.Forms.TextBox txtCuitB;
        private System.Windows.Forms.TextBox txtCuitA;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.ListBox lstLab;
        private System.Windows.Forms.GroupBox grpOpciones;
        private System.Windows.Forms.RadioButton radEliminar;
        private System.Windows.Forms.RadioButton radModificar;
        private System.Windows.Forms.RadioButton radCrear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Timer timBotones;
    }
}