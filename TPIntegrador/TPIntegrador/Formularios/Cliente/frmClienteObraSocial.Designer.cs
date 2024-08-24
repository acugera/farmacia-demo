namespace TPIntegrador
{
    partial class frmClienteObraSocial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClienteObraSocial));
            this.txtNroObraD = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNroObraC = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNroObraB = new System.Windows.Forms.TextBox();
            this.cmbTipoObra = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNroObraA = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNroObraD
            // 
            this.txtNroObraD.Location = new System.Drawing.Point(226, 33);
            this.txtNroObraD.MaxLength = 3;
            this.txtNroObraD.Name = "txtNroObraD";
            this.txtNroObraD.Size = new System.Drawing.Size(31, 20);
            this.txtNroObraD.TabIndex = 61;
            this.txtNroObraD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNroObraD_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(210, 36);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(12, 13);
            this.label9.TabIndex = 60;
            this.label9.Text = "/";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(155, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(10, 13);
            this.label8.TabIndex = 59;
            this.label8.Text = "-";
            // 
            // txtNroObraC
            // 
            this.txtNroObraC.Location = new System.Drawing.Point(172, 33);
            this.txtNroObraC.MaxLength = 2;
            this.txtNroObraC.Name = "txtNroObraC";
            this.txtNroObraC.Size = new System.Drawing.Size(32, 20);
            this.txtNroObraC.TabIndex = 58;
            this.txtNroObraC.TextChanged += new System.EventHandler(this.txtNroObraC_TextChanged);
            this.txtNroObraC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNroObraC_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(65, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(10, 13);
            this.label7.TabIndex = 57;
            this.label7.Text = "-";
            // 
            // txtNroObraB
            // 
            this.txtNroObraB.Location = new System.Drawing.Point(82, 33);
            this.txtNroObraB.MaxLength = 8;
            this.txtNroObraB.Name = "txtNroObraB";
            this.txtNroObraB.Size = new System.Drawing.Size(67, 20);
            this.txtNroObraB.TabIndex = 56;
            this.txtNroObraB.TextChanged += new System.EventHandler(this.txtNroObraB_TextChanged);
            this.txtNroObraB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNroObraB_KeyPress);
            // 
            // cmbTipoObra
            // 
            this.cmbTipoObra.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoObra.FormattingEnabled = true;
            this.cmbTipoObra.Location = new System.Drawing.Point(27, 78);
            this.cmbTipoObra.Name = "cmbTipoObra";
            this.cmbTipoObra.Size = new System.Drawing.Size(230, 21);
            this.cmbTipoObra.TabIndex = 55;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 54;
            this.label4.Text = "Obra Social (*)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 53;
            this.label3.Text = "Nro. Obra Social (*)";
            // 
            // txtNroObraA
            // 
            this.txtNroObraA.Location = new System.Drawing.Point(27, 33);
            this.txtNroObraA.MaxLength = 1;
            this.txtNroObraA.Name = "txtNroObraA";
            this.txtNroObraA.Size = new System.Drawing.Size(32, 20);
            this.txtNroObraA.TabIndex = 52;
            this.txtNroObraA.TextChanged += new System.EventHandler(this.txtNroObraA_TextChanged);
            this.txtNroObraA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNroObraA_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(78, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 13);
            this.label6.TabIndex = 51;
            this.label6.Text = "Campos Obligatorios (*)";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(84, 165);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(101, 31);
            this.btnCancelar.TabIndex = 49;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(84, 128);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(101, 31);
            this.btnConfirmar.TabIndex = 48;
            this.btnConfirmar.Text = "Guardar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // frmClienteObraSocial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 203);
            this.ControlBox = false;
            this.Controls.Add(this.txtNroObraD);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtNroObraC);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtNroObraB);
            this.Controls.Add(this.cmbTipoObra);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNroObraA);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnConfirmar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(293, 242);
            this.MinimumSize = new System.Drawing.Size(293, 242);
            this.Name = "frmClienteObraSocial";
            this.Text = "Obra Social:";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmClienteObraSocial_FormClosing);
            this.Load += new System.EventHandler(this.frmClienteObraSocial_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNroObraD;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNroObraC;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNroObraB;
        private System.Windows.Forms.ComboBox cmbTipoObra;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNroObraA;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnConfirmar;
    }
}