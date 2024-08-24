namespace TPIntegrador
{
    partial class frmVenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVenta));
            this.dtpFechaEmision = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbTipoFac = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblVendedor = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.gbDatosFactura = new System.Windows.Forms.GroupBox();
            this.txtNombreCli = new System.Windows.Forms.TextBox();
            this.txtApellidoCli = new System.Windows.Forms.TextBox();
            this.btnAddCliente = new System.Windows.Forms.Button();
            this.panelCliente = new System.Windows.Forms.GroupBox();
            this.btnConfirmarCliente = new System.Windows.Forms.Button();
            this.cmbObra_Social = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.chkObraSocial = new System.Windows.Forms.CheckBox();
            this.grpProducto = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnModificarCantidad = new System.Windows.Forms.Button();
            this.btnDeleteProducto = new System.Windows.Forms.Button();
            this.btnAddProducto = new System.Windows.Forms.Button();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.idProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descuentoGrilla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnConfirmarVenta = new System.Windows.Forms.Button();
            this.btnCancelarVenta = new System.Windows.Forms.Button();
            this.tmrAuxiliar = new System.Windows.Forms.Timer(this.components);
            this.gbDatosFactura.SuspendLayout();
            this.panelCliente.SuspendLayout();
            this.grpProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpFechaEmision
            // 
            this.dtpFechaEmision.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaEmision.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.dtpFechaEmision.Enabled = false;
            this.dtpFechaEmision.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaEmision.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaEmision.Location = new System.Drawing.Point(184, 23);
            this.dtpFechaEmision.Name = "dtpFechaEmision";
            this.dtpFechaEmision.Size = new System.Drawing.Size(112, 26);
            this.dtpFechaEmision.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fecha de Emision:";
            // 
            // cmbTipoFac
            // 
            this.cmbTipoFac.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoFac.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipoFac.FormattingEnabled = true;
            this.cmbTipoFac.Items.AddRange(new object[] {
            "A",
            "B",
            "C"});
            this.cmbTipoFac.Location = new System.Drawing.Point(184, 55);
            this.cmbTipoFac.Name = "cmbTipoFac";
            this.cmbTipoFac.Size = new System.Drawing.Size(40, 28);
            this.cmbTipoFac.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tipo de Factura:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Vendedor:";
            // 
            // lblVendedor
            // 
            this.lblVendedor.AutoSize = true;
            this.lblVendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVendedor.Location = new System.Drawing.Point(101, 28);
            this.lblVendedor.Name = "lblVendedor";
            this.lblVendedor.Size = new System.Drawing.Size(139, 20);
            this.lblVendedor.TabIndex = 7;
            this.lblVendedor.Text = "Nombre Vendedor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Cliente:";
            // 
            // gbDatosFactura
            // 
            this.gbDatosFactura.Controls.Add(this.dtpFechaEmision);
            this.gbDatosFactura.Controls.Add(this.label2);
            this.gbDatosFactura.Controls.Add(this.label3);
            this.gbDatosFactura.Controls.Add(this.cmbTipoFac);
            this.gbDatosFactura.Location = new System.Drawing.Point(461, 12);
            this.gbDatosFactura.Name = "gbDatosFactura";
            this.gbDatosFactura.Size = new System.Drawing.Size(316, 127);
            this.gbDatosFactura.TabIndex = 9;
            this.gbDatosFactura.TabStop = false;
            this.gbDatosFactura.Text = "Datos de Factura";
            // 
            // txtNombreCli
            // 
            this.txtNombreCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreCli.Location = new System.Drawing.Point(99, 13);
            this.txtNombreCli.Name = "txtNombreCli";
            this.txtNombreCli.ReadOnly = true;
            this.txtNombreCli.Size = new System.Drawing.Size(141, 26);
            this.txtNombreCli.TabIndex = 10;
            // 
            // txtApellidoCli
            // 
            this.txtApellidoCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidoCli.Location = new System.Drawing.Point(246, 13);
            this.txtApellidoCli.Name = "txtApellidoCli";
            this.txtApellidoCli.ReadOnly = true;
            this.txtApellidoCli.Size = new System.Drawing.Size(141, 26);
            this.txtApellidoCli.TabIndex = 11;
            // 
            // btnAddCliente
            // 
            this.btnAddCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCliente.Location = new System.Drawing.Point(393, 13);
            this.btnAddCliente.Name = "btnAddCliente";
            this.btnAddCliente.Size = new System.Drawing.Size(31, 26);
            this.btnAddCliente.TabIndex = 12;
            this.btnAddCliente.Text = "...";
            this.btnAddCliente.UseVisualStyleBackColor = true;
            this.btnAddCliente.Click += new System.EventHandler(this.btnAddCliente_Click);
            // 
            // panelCliente
            // 
            this.panelCliente.Controls.Add(this.btnConfirmarCliente);
            this.panelCliente.Controls.Add(this.cmbObra_Social);
            this.panelCliente.Controls.Add(this.label6);
            this.panelCliente.Controls.Add(this.chkObraSocial);
            this.panelCliente.Controls.Add(this.label5);
            this.panelCliente.Controls.Add(this.btnAddCliente);
            this.panelCliente.Controls.Add(this.txtNombreCli);
            this.panelCliente.Controls.Add(this.txtApellidoCli);
            this.panelCliente.Location = new System.Drawing.Point(12, 59);
            this.panelCliente.Name = "panelCliente";
            this.panelCliente.Size = new System.Drawing.Size(439, 162);
            this.panelCliente.TabIndex = 13;
            this.panelCliente.TabStop = false;
            this.panelCliente.Text = "Cliente";
            // 
            // btnConfirmarCliente
            // 
            this.btnConfirmarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmarCliente.Location = new System.Drawing.Point(342, 126);
            this.btnConfirmarCliente.Name = "btnConfirmarCliente";
            this.btnConfirmarCliente.Size = new System.Drawing.Size(82, 30);
            this.btnConfirmarCliente.TabIndex = 15;
            this.btnConfirmarCliente.Text = "Confirmar";
            this.btnConfirmarCliente.UseVisualStyleBackColor = true;
            this.btnConfirmarCliente.Click += new System.EventHandler(this.btnConfirmarCliente_Click);
            // 
            // cmbObra_Social
            // 
            this.cmbObra_Social.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbObra_Social.Enabled = false;
            this.cmbObra_Social.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbObra_Social.FormattingEnabled = true;
            this.cmbObra_Social.ItemHeight = 20;
            this.cmbObra_Social.Location = new System.Drawing.Point(103, 70);
            this.cmbObra_Social.Name = "cmbObra_Social";
            this.cmbObra_Social.Size = new System.Drawing.Size(321, 28);
            this.cmbObra_Social.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Obra Social";
            // 
            // chkObraSocial
            // 
            this.chkObraSocial.AutoSize = true;
            this.chkObraSocial.Enabled = false;
            this.chkObraSocial.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkObraSocial.Location = new System.Drawing.Point(26, 45);
            this.chkObraSocial.Name = "chkObraSocial";
            this.chkObraSocial.Size = new System.Drawing.Size(105, 22);
            this.chkObraSocial.TabIndex = 13;
            this.chkObraSocial.Text = "Obra Social";
            this.chkObraSocial.UseVisualStyleBackColor = true;
            this.chkObraSocial.CheckedChanged += new System.EventHandler(this.chkObraSocial_CheckedChanged);
            // 
            // grpProducto
            // 
            this.grpProducto.Controls.Add(this.label7);
            this.grpProducto.Controls.Add(this.txtTotal);
            this.grpProducto.Controls.Add(this.btnModificarCantidad);
            this.grpProducto.Controls.Add(this.btnDeleteProducto);
            this.grpProducto.Controls.Add(this.btnAddProducto);
            this.grpProducto.Controls.Add(this.dgvProductos);
            this.grpProducto.Enabled = false;
            this.grpProducto.Location = new System.Drawing.Point(12, 227);
            this.grpProducto.Name = "grpProducto";
            this.grpProducto.Size = new System.Drawing.Size(780, 404);
            this.grpProducto.TabIndex = 14;
            this.grpProducto.TabStop = false;
            this.grpProducto.Text = "Productos";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(564, 375);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "TOTAL:";
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(633, 372);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(141, 26);
            this.txtTotal.TabIndex = 15;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnModificarCantidad
            // 
            this.btnModificarCantidad.Enabled = false;
            this.btnModificarCantidad.Location = new System.Drawing.Point(304, 19);
            this.btnModificarCantidad.Name = "btnModificarCantidad";
            this.btnModificarCantidad.Size = new System.Drawing.Size(143, 23);
            this.btnModificarCantidad.TabIndex = 3;
            this.btnModificarCantidad.Text = "Modificar Cantidad";
            this.btnModificarCantidad.UseVisualStyleBackColor = true;
            this.btnModificarCantidad.Click += new System.EventHandler(this.btnModificarCantidad_Click);
            // 
            // btnDeleteProducto
            // 
            this.btnDeleteProducto.Enabled = false;
            this.btnDeleteProducto.Location = new System.Drawing.Point(155, 19);
            this.btnDeleteProducto.Name = "btnDeleteProducto";
            this.btnDeleteProducto.Size = new System.Drawing.Size(143, 23);
            this.btnDeleteProducto.TabIndex = 2;
            this.btnDeleteProducto.Text = "Quitar Productos";
            this.btnDeleteProducto.UseVisualStyleBackColor = true;
            this.btnDeleteProducto.Click += new System.EventHandler(this.btnDeleteProducto_Click);
            // 
            // btnAddProducto
            // 
            this.btnAddProducto.Location = new System.Drawing.Point(6, 19);
            this.btnAddProducto.Name = "btnAddProducto";
            this.btnAddProducto.Size = new System.Drawing.Size(143, 23);
            this.btnAddProducto.TabIndex = 1;
            this.btnAddProducto.Text = "Añadir Productos";
            this.btnAddProducto.UseVisualStyleBackColor = true;
            this.btnAddProducto.Click += new System.EventHandler(this.btnAddProducto_Click);
            // 
            // dgvProductos
            // 
            this.dgvProductos.AllowUserToAddRows = false;
            this.dgvProductos.AllowUserToDeleteRows = false;
            this.dgvProductos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProducto,
            this.nombreProducto,
            this.cantidadProducto,
            this.precioUnitario,
            this.totalProducto,
            this.descuentoGrilla});
            this.dgvProductos.Location = new System.Drawing.Point(6, 48);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.ReadOnly = true;
            this.dgvProductos.Size = new System.Drawing.Size(768, 318);
            this.dgvProductos.TabIndex = 0;
            this.dgvProductos.SelectionChanged += new System.EventHandler(this.dgvProductos_SelectionChanged);
            // 
            // idProducto
            // 
            this.idProducto.HeaderText = "Nro. Producto";
            this.idProducto.Name = "idProducto";
            this.idProducto.ReadOnly = true;
            // 
            // nombreProducto
            // 
            this.nombreProducto.HeaderText = "Nombre del Producto";
            this.nombreProducto.Name = "nombreProducto";
            this.nombreProducto.ReadOnly = true;
            // 
            // cantidadProducto
            // 
            this.cantidadProducto.HeaderText = "Cantidad";
            this.cantidadProducto.Name = "cantidadProducto";
            this.cantidadProducto.ReadOnly = true;
            // 
            // precioUnitario
            // 
            this.precioUnitario.HeaderText = "Precio Unitario";
            this.precioUnitario.Name = "precioUnitario";
            this.precioUnitario.ReadOnly = true;
            // 
            // totalProducto
            // 
            this.totalProducto.HeaderText = "Total";
            this.totalProducto.Name = "totalProducto";
            this.totalProducto.ReadOnly = true;
            // 
            // descuentoGrilla
            // 
            this.descuentoGrilla.HeaderText = "Descuento";
            this.descuentoGrilla.Name = "descuentoGrilla";
            this.descuentoGrilla.ReadOnly = true;
            // 
            // btnConfirmarVenta
            // 
            this.btnConfirmarVenta.Enabled = false;
            this.btnConfirmarVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmarVenta.Location = new System.Drawing.Point(646, 637);
            this.btnConfirmarVenta.Name = "btnConfirmarVenta";
            this.btnConfirmarVenta.Size = new System.Drawing.Size(146, 33);
            this.btnConfirmarVenta.TabIndex = 15;
            this.btnConfirmarVenta.Text = "Confirmar Venta";
            this.btnConfirmarVenta.UseVisualStyleBackColor = true;
            this.btnConfirmarVenta.Click += new System.EventHandler(this.btnConfirmarVenta_Click);
            // 
            // btnCancelarVenta
            // 
            this.btnCancelarVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarVenta.Location = new System.Drawing.Point(494, 637);
            this.btnCancelarVenta.Name = "btnCancelarVenta";
            this.btnCancelarVenta.Size = new System.Drawing.Size(146, 33);
            this.btnCancelarVenta.TabIndex = 16;
            this.btnCancelarVenta.Text = "Cancelar Venta";
            this.btnCancelarVenta.UseVisualStyleBackColor = true;
            this.btnCancelarVenta.Click += new System.EventHandler(this.btnCancelarVenta_Click);
            // 
            // tmrAuxiliar
            // 
            this.tmrAuxiliar.Tick += new System.EventHandler(this.tmrAuxiliar_Tick);
            // 
            // frmVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 676);
            this.Controls.Add(this.btnCancelarVenta);
            this.Controls.Add(this.btnConfirmarVenta);
            this.Controls.Add(this.grpProducto);
            this.Controls.Add(this.panelCliente);
            this.Controls.Add(this.gbDatosFactura);
            this.Controls.Add(this.lblVendedor);
            this.Controls.Add(this.label4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(820, 715);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(820, 715);
            this.Name = "frmVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Venta";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmVenta_FormClosing);
            this.Load += new System.EventHandler(this.frmVenta_Load);
            this.gbDatosFactura.ResumeLayout(false);
            this.gbDatosFactura.PerformLayout();
            this.panelCliente.ResumeLayout(false);
            this.panelCliente.PerformLayout();
            this.grpProducto.ResumeLayout(false);
            this.grpProducto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpFechaEmision;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbTipoFac;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblVendedor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox gbDatosFactura;
        private System.Windows.Forms.TextBox txtNombreCli;
        private System.Windows.Forms.TextBox txtApellidoCli;
        private System.Windows.Forms.Button btnAddCliente;
        private System.Windows.Forms.GroupBox panelCliente;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chkObraSocial;
        private System.Windows.Forms.GroupBox grpProducto;
        private System.Windows.Forms.Button btnModificarCantidad;
        private System.Windows.Forms.Button btnDeleteProducto;
        private System.Windows.Forms.Button btnAddProducto;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.Button btnConfirmarVenta;
        private System.Windows.Forms.Button btnCancelarVenta;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.ComboBox cmbObra_Social;
        private System.Windows.Forms.Button btnConfirmarCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn descuentoGrilla;
        private System.Windows.Forms.Timer tmrAuxiliar;

    }
}