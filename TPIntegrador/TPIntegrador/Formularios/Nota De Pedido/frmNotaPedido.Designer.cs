namespace TPIntegrador
{
    partial class frmNotaPedido
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNotaPedido));
            this.cmbLaboratorio = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFechaPedido = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLaboratorio = new System.Windows.Forms.Button();
            this.panelMedicamento = new System.Windows.Forms.Panel();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbMedicamento = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvMedicamento = new System.Windows.Forms.DataGridView();
            this.medicamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idMedicamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnConfirmarNota = new System.Windows.Forms.Button();
            this.btnCancelarVenta = new System.Windows.Forms.Button();
            this.panelGrilla = new System.Windows.Forms.Panel();
            this.btnModificarCantidad = new System.Windows.Forms.Button();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnConfirmarLaboratorio = new System.Windows.Forms.Button();
            this.panelEncabezado = new System.Windows.Forms.Panel();
            this.timAux = new System.Windows.Forms.Timer(this.components);
            this.panelMedicamento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicamento)).BeginInit();
            this.panelGrilla.SuspendLayout();
            this.panelEncabezado.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbLaboratorio
            // 
            this.cmbLaboratorio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLaboratorio.FormattingEnabled = true;
            this.cmbLaboratorio.Location = new System.Drawing.Point(72, 40);
            this.cmbLaboratorio.Name = "cmbLaboratorio";
            this.cmbLaboratorio.Size = new System.Drawing.Size(109, 21);
            this.cmbLaboratorio.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Laboratorio:";
            // 
            // dtpFechaPedido
            // 
            this.dtpFechaPedido.Enabled = false;
            this.dtpFechaPedido.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaPedido.Location = new System.Drawing.Point(100, 3);
            this.dtpFechaPedido.Name = "dtpFechaPedido";
            this.dtpFechaPedido.Size = new System.Drawing.Size(81, 20);
            this.dtpFechaPedido.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fecha de Pedido:";
            // 
            // btnLaboratorio
            // 
            this.btnLaboratorio.Location = new System.Drawing.Point(187, 42);
            this.btnLaboratorio.Name = "btnLaboratorio";
            this.btnLaboratorio.Size = new System.Drawing.Size(59, 19);
            this.btnLaboratorio.TabIndex = 0;
            this.btnLaboratorio.Text = "Confirmar";
            this.btnLaboratorio.UseVisualStyleBackColor = true;
            this.btnLaboratorio.Click += new System.EventHandler(this.btnConfirmarLaboratorio_Click);
            // 
            // panelMedicamento
            // 
            this.panelMedicamento.Controls.Add(this.btnAgregar);
            this.panelMedicamento.Controls.Add(this.txtCantidad);
            this.panelMedicamento.Controls.Add(this.label4);
            this.panelMedicamento.Controls.Add(this.cmbMedicamento);
            this.panelMedicamento.Controls.Add(this.label3);
            this.panelMedicamento.Enabled = false;
            this.panelMedicamento.Location = new System.Drawing.Point(16, 87);
            this.panelMedicamento.Name = "panelMedicamento";
            this.panelMedicamento.Size = new System.Drawing.Size(240, 60);
            this.panelMedicamento.TabIndex = 1;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(144, 30);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(69, 27);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(83, 34);
            this.txtCantidad.MaxLength = 3;
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(44, 20);
            this.txtCantidad.TabIndex = 1;
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Cantidad:";
            // 
            // cmbMedicamento
            // 
            this.cmbMedicamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMedicamento.FormattingEnabled = true;
            this.cmbMedicamento.Location = new System.Drawing.Point(83, 7);
            this.cmbMedicamento.Name = "cmbMedicamento";
            this.cmbMedicamento.Size = new System.Drawing.Size(130, 21);
            this.cmbMedicamento.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Medicamento:";
            // 
            // dgvMedicamento
            // 
            this.dgvMedicamento.AllowUserToAddRows = false;
            this.dgvMedicamento.AllowUserToDeleteRows = false;
            this.dgvMedicamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedicamento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.medicamento,
            this.cantidad,
            this.idMedicamento});
            this.dgvMedicamento.Location = new System.Drawing.Point(6, 42);
            this.dgvMedicamento.Name = "dgvMedicamento";
            this.dgvMedicamento.ReadOnly = true;
            this.dgvMedicamento.Size = new System.Drawing.Size(250, 150);
            this.dgvMedicamento.TabIndex = 6;
            this.dgvMedicamento.SelectionChanged += new System.EventHandler(this.dgvMedicamento_SelectionChanged);
            // 
            // medicamento
            // 
            this.medicamento.HeaderText = "Medicamento";
            this.medicamento.Name = "medicamento";
            this.medicamento.ReadOnly = true;
            // 
            // cantidad
            // 
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.Name = "cantidad";
            this.cantidad.ReadOnly = true;
            // 
            // idMedicamento
            // 
            this.idMedicamento.HeaderText = "idMedicamento";
            this.idMedicamento.Name = "idMedicamento";
            this.idMedicamento.ReadOnly = true;
            this.idMedicamento.Visible = false;
            // 
            // btnConfirmarNota
            // 
            this.btnConfirmarNota.Enabled = false;
            this.btnConfirmarNota.Location = new System.Drawing.Point(197, 354);
            this.btnConfirmarNota.Name = "btnConfirmarNota";
            this.btnConfirmarNota.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmarNota.TabIndex = 3;
            this.btnConfirmarNota.Text = "Confirmar";
            this.btnConfirmarNota.UseVisualStyleBackColor = true;
            this.btnConfirmarNota.Click += new System.EventHandler(this.btnConfirmarNota_Click);
            // 
            // btnCancelarVenta
            // 
            this.btnCancelarVenta.Location = new System.Drawing.Point(116, 354);
            this.btnCancelarVenta.Name = "btnCancelarVenta";
            this.btnCancelarVenta.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarVenta.TabIndex = 4;
            this.btnCancelarVenta.Text = "Cancelar";
            this.btnCancelarVenta.UseVisualStyleBackColor = true;
            this.btnCancelarVenta.Click += new System.EventHandler(this.btnCancelarVenta_Click);
            // 
            // panelGrilla
            // 
            this.panelGrilla.Controls.Add(this.btnModificarCantidad);
            this.panelGrilla.Controls.Add(this.btnQuitar);
            this.panelGrilla.Controls.Add(this.dgvMedicamento);
            this.panelGrilla.Enabled = false;
            this.panelGrilla.Location = new System.Drawing.Point(16, 153);
            this.panelGrilla.Name = "panelGrilla";
            this.panelGrilla.Size = new System.Drawing.Size(273, 195);
            this.panelGrilla.TabIndex = 2;
            // 
            // btnModificarCantidad
            // 
            this.btnModificarCantidad.Enabled = false;
            this.btnModificarCantidad.Location = new System.Drawing.Point(133, 3);
            this.btnModificarCantidad.Name = "btnModificarCantidad";
            this.btnModificarCantidad.Size = new System.Drawing.Size(133, 23);
            this.btnModificarCantidad.TabIndex = 1;
            this.btnModificarCantidad.Text = "Modificar Cantidad";
            this.btnModificarCantidad.UseVisualStyleBackColor = true;
            this.btnModificarCantidad.Click += new System.EventHandler(this.btnModificarCantidad_Click);
            // 
            // btnQuitar
            // 
            this.btnQuitar.Enabled = false;
            this.btnQuitar.Location = new System.Drawing.Point(6, 3);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(121, 23);
            this.btnQuitar.TabIndex = 0;
            this.btnQuitar.Text = "Quitar Medicamento";
            this.btnQuitar.UseVisualStyleBackColor = true;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(72, 40);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(109, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Laboratorio:";
            // 
            // btnConfirmarLaboratorio
            // 
            this.btnConfirmarLaboratorio.Location = new System.Drawing.Point(187, 42);
            this.btnConfirmarLaboratorio.Name = "btnConfirmarLaboratorio";
            this.btnConfirmarLaboratorio.Size = new System.Drawing.Size(59, 19);
            this.btnConfirmarLaboratorio.TabIndex = 0;
            this.btnConfirmarLaboratorio.Text = "Confirmar";
            this.btnConfirmarLaboratorio.UseVisualStyleBackColor = true;
            this.btnConfirmarLaboratorio.Click += new System.EventHandler(this.btnConfirmarLaboratorio_Click);
            // 
            // panelEncabezado
            // 
            this.panelEncabezado.Controls.Add(this.label5);
            this.panelEncabezado.Controls.Add(this.cmbLaboratorio);
            this.panelEncabezado.Controls.Add(this.label1);
            this.panelEncabezado.Controls.Add(this.comboBox1);
            this.panelEncabezado.Controls.Add(this.btnConfirmarLaboratorio);
            this.panelEncabezado.Controls.Add(this.label2);
            this.panelEncabezado.Controls.Add(this.dtpFechaPedido);
            this.panelEncabezado.Controls.Add(this.btnLaboratorio);
            this.panelEncabezado.Location = new System.Drawing.Point(16, 9);
            this.panelEncabezado.Name = "panelEncabezado";
            this.panelEncabezado.Size = new System.Drawing.Size(266, 72);
            this.panelEncabezado.TabIndex = 5;
            // 
            // timAux
            // 
            this.timAux.Tick += new System.EventHandler(this.timAux_Tick);
            // 
            // frmNotaPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 389);
            this.Controls.Add(this.panelEncabezado);
            this.Controls.Add(this.panelGrilla);
            this.Controls.Add(this.btnCancelarVenta);
            this.Controls.Add(this.btnConfirmarNota);
            this.Controls.Add(this.panelMedicamento);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(310, 428);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(310, 428);
            this.Name = "frmNotaPedido";
            this.Text = "Nota de Pedido";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmNotaPedido_FormClosing);
            this.Load += new System.EventHandler(this.frmNotaPedido_Load);
            this.panelMedicamento.ResumeLayout(false);
            this.panelMedicamento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicamento)).EndInit();
            this.panelGrilla.ResumeLayout(false);
            this.panelEncabezado.ResumeLayout(false);
            this.panelEncabezado.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbLaboratorio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFechaPedido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLaboratorio;
        private System.Windows.Forms.Panel panelMedicamento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbMedicamento;
        private System.Windows.Forms.DataGridView dgvMedicamento;
        private System.Windows.Forms.Button btnConfirmarNota;
        private System.Windows.Forms.Button btnCancelarVenta;
        private System.Windows.Forms.Panel panelGrilla;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Button btnModificarCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn medicamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMedicamento;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnConfirmarLaboratorio;
        private System.Windows.Forms.Panel panelEncabezado;
        private System.Windows.Forms.Timer timAux;
    }
}