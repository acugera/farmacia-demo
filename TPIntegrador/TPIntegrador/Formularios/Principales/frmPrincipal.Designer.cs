namespace TPIntegrador
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnEmpleado = new System.Windows.Forms.ToolStripMenuItem();
            this.transaccionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarVentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notaDePedidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevaNotaDePedidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarNotasDePedidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estadísticaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosMásVendidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasDeEmpleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCrea_Modifica = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnModiLab = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoDeUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.laboratorioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarLaboratoriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.laboratorioToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.medicamentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.obraSocialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarStockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblusuario = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnEmpleado,
            this.transaccionesToolStripMenuItem,
            this.estadísticaToolStripMenuItem,
            this.btnCrea_Modifica,
            this.laboratorioToolStripMenuItem,
            this.modificarStockToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(957, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnEmpleado
            // 
            this.btnEmpleado.Image = global::TPIntegrador.Properties.Resources.chico;
            this.btnEmpleado.Name = "btnEmpleado";
            this.btnEmpleado.Size = new System.Drawing.Size(93, 20);
            this.btnEmpleado.Text = "Empleados";
            this.btnEmpleado.Click += new System.EventHandler(this.usuarioToolStripMenuItem_Click);
            // 
            // transaccionesToolStripMenuItem
            // 
            this.transaccionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ventaToolStripMenuItem,
            this.notaDePedidoToolStripMenuItem});
            this.transaccionesToolStripMenuItem.Image = global::TPIntegrador.Properties.Resources.flechas;
            this.transaccionesToolStripMenuItem.Name = "transaccionesToolStripMenuItem";
            this.transaccionesToolStripMenuItem.Size = new System.Drawing.Size(109, 20);
            this.transaccionesToolStripMenuItem.Text = "Transacciones";
            // 
            // ventaToolStripMenuItem
            // 
            this.ventaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearToolStripMenuItem,
            this.consultarVentasToolStripMenuItem});
            this.ventaToolStripMenuItem.Name = "ventaToolStripMenuItem";
            this.ventaToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.ventaToolStripMenuItem.Text = "Venta";
            // 
            // crearToolStripMenuItem
            // 
            this.crearToolStripMenuItem.Name = "crearToolStripMenuItem";
            this.crearToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.crearToolStripMenuItem.Text = "Nueva Venta";
            this.crearToolStripMenuItem.Click += new System.EventHandler(this.crearToolStripMenuItem_Click);
            // 
            // consultarVentasToolStripMenuItem
            // 
            this.consultarVentasToolStripMenuItem.Name = "consultarVentasToolStripMenuItem";
            this.consultarVentasToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.consultarVentasToolStripMenuItem.Text = "Consultar Ventas";
            this.consultarVentasToolStripMenuItem.Click += new System.EventHandler(this.consultarVentasToolStripMenuItem_Click);
            // 
            // notaDePedidoToolStripMenuItem
            // 
            this.notaDePedidoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevaNotaDePedidoToolStripMenuItem,
            this.consultarNotasDePedidoToolStripMenuItem});
            this.notaDePedidoToolStripMenuItem.Name = "notaDePedidoToolStripMenuItem";
            this.notaDePedidoToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.notaDePedidoToolStripMenuItem.Text = "Nota De Pedido";
            // 
            // nuevaNotaDePedidoToolStripMenuItem
            // 
            this.nuevaNotaDePedidoToolStripMenuItem.Name = "nuevaNotaDePedidoToolStripMenuItem";
            this.nuevaNotaDePedidoToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.nuevaNotaDePedidoToolStripMenuItem.Text = "Nueva Nota De Pedido";
            this.nuevaNotaDePedidoToolStripMenuItem.Click += new System.EventHandler(this.nuevaNotaDePedidoToolStripMenuItem_Click);
            // 
            // consultarNotasDePedidoToolStripMenuItem
            // 
            this.consultarNotasDePedidoToolStripMenuItem.Name = "consultarNotasDePedidoToolStripMenuItem";
            this.consultarNotasDePedidoToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.consultarNotasDePedidoToolStripMenuItem.Text = "Consultar Notas de Pedido";
            this.consultarNotasDePedidoToolStripMenuItem.Click += new System.EventHandler(this.consultarNotasDePedidoToolStripMenuItem_Click);
            // 
            // estadísticaToolStripMenuItem
            // 
            this.estadísticaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productosMásVendidosToolStripMenuItem,
            this.ventasDeEmpleadosToolStripMenuItem});
            this.estadísticaToolStripMenuItem.Image = global::TPIntegrador.Properties.Resources.reportar;
            this.estadísticaToolStripMenuItem.Name = "estadísticaToolStripMenuItem";
            this.estadísticaToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.estadísticaToolStripMenuItem.Text = "Estadística";
            // 
            // productosMásVendidosToolStripMenuItem
            // 
            this.productosMásVendidosToolStripMenuItem.Name = "productosMásVendidosToolStripMenuItem";
            this.productosMásVendidosToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.productosMásVendidosToolStripMenuItem.Text = "Productos Vendidos";
            this.productosMásVendidosToolStripMenuItem.Click += new System.EventHandler(this.productosMásVendidosToolStripMenuItem_Click);
            // 
            // ventasDeEmpleadosToolStripMenuItem
            // 
            this.ventasDeEmpleadosToolStripMenuItem.Name = "ventasDeEmpleadosToolStripMenuItem";
            this.ventasDeEmpleadosToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.ventasDeEmpleadosToolStripMenuItem.Text = "Ventas de Empleados";
            this.ventasDeEmpleadosToolStripMenuItem.Click += new System.EventHandler(this.ventasDeEmpleadosToolStripMenuItem_Click);
            // 
            // btnCrea_Modifica
            // 
            this.btnCrea_Modifica.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.btnModiLab,
            this.toolStripMenuItem5,
            this.toolStripMenuItem6,
            this.tipoDeUsuarioToolStripMenuItem});
            this.btnCrea_Modifica.Image = global::TPIntegrador.Properties.Resources.escritura__2_;
            this.btnCrea_Modifica.Name = "btnCrea_Modifica";
            this.btnCrea_Modifica.Size = new System.Drawing.Size(126, 20);
            this.btnCrea_Modifica.Text = "Crear y Modificar";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(157, 22);
            this.toolStripMenuItem2.Text = "Cliente";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(157, 22);
            this.toolStripMenuItem3.Text = "Descuento";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // btnModiLab
            // 
            this.btnModiLab.Name = "btnModiLab";
            this.btnModiLab.Size = new System.Drawing.Size(157, 22);
            this.btnModiLab.Text = "Laboratorio";
            this.btnModiLab.Click += new System.EventHandler(this.btnModiLab_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(157, 22);
            this.toolStripMenuItem5.Text = "Medicamentos";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.toolStripMenuItem5_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(157, 22);
            this.toolStripMenuItem6.Text = "Obra Social";
            this.toolStripMenuItem6.Click += new System.EventHandler(this.toolStripMenuItem6_Click);
            // 
            // tipoDeUsuarioToolStripMenuItem
            // 
            this.tipoDeUsuarioToolStripMenuItem.Name = "tipoDeUsuarioToolStripMenuItem";
            this.tipoDeUsuarioToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.tipoDeUsuarioToolStripMenuItem.Text = "Tipo de Usuario";
            this.tipoDeUsuarioToolStripMenuItem.Click += new System.EventHandler(this.tipoDeUsuarioToolStripMenuItem_Click);
            // 
            // laboratorioToolStripMenuItem
            // 
            this.laboratorioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editarLaboratoriosToolStripMenuItem,
            this.laboratorioToolStripMenuItem1,
            this.medicamentosToolStripMenuItem,
            this.obraSocialToolStripMenuItem});
            this.laboratorioToolStripMenuItem.Image = global::TPIntegrador.Properties.Resources.search_icon_icons_com_74448__1_;
            this.laboratorioToolStripMenuItem.Name = "laboratorioToolStripMenuItem";
            this.laboratorioToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.laboratorioToolStripMenuItem.Text = "Consultar";
            // 
            // editarLaboratoriosToolStripMenuItem
            // 
            this.editarLaboratoriosToolStripMenuItem.Name = "editarLaboratoriosToolStripMenuItem";
            this.editarLaboratoriosToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.editarLaboratoriosToolStripMenuItem.Text = "Cliente";
            this.editarLaboratoriosToolStripMenuItem.Click += new System.EventHandler(this.editarLaboratoriosToolStripMenuItem_Click);
            // 
            // laboratorioToolStripMenuItem1
            // 
            this.laboratorioToolStripMenuItem1.Name = "laboratorioToolStripMenuItem1";
            this.laboratorioToolStripMenuItem1.Size = new System.Drawing.Size(153, 22);
            this.laboratorioToolStripMenuItem1.Text = "Laboratorio";
            this.laboratorioToolStripMenuItem1.Click += new System.EventHandler(this.laboratorioToolStripMenuItem1_Click);
            // 
            // medicamentosToolStripMenuItem
            // 
            this.medicamentosToolStripMenuItem.Name = "medicamentosToolStripMenuItem";
            this.medicamentosToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.medicamentosToolStripMenuItem.Text = "Medicamentos";
            this.medicamentosToolStripMenuItem.Click += new System.EventHandler(this.medicamentosToolStripMenuItem_Click);
            // 
            // obraSocialToolStripMenuItem
            // 
            this.obraSocialToolStripMenuItem.Name = "obraSocialToolStripMenuItem";
            this.obraSocialToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.obraSocialToolStripMenuItem.Text = "Obra Social";
            this.obraSocialToolStripMenuItem.Click += new System.EventHandler(this.obraSocialToolStripMenuItem_Click);
            // 
            // modificarStockToolStripMenuItem
            // 
            this.modificarStockToolStripMenuItem.Image = global::TPIntegrador.Properties.Resources.almacen;
            this.modificarStockToolStripMenuItem.Name = "modificarStockToolStripMenuItem";
            this.modificarStockToolStripMenuItem.Size = new System.Drawing.Size(118, 20);
            this.modificarStockToolStripMenuItem.Text = "Modificar Stock";
            this.modificarStockToolStripMenuItem.Click += new System.EventHandler(this.modificarStockToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblusuario);
            this.panel1.Controls.Add(this.lblApellido);
            this.panel1.Controls.Add(this.lblNombre);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(957, 51);
            this.panel1.TabIndex = 1;
            // 
            // lblusuario
            // 
            this.lblusuario.AutoSize = true;
            this.lblusuario.Location = new System.Drawing.Point(821, 10);
            this.lblusuario.Name = "lblusuario";
            this.lblusuario.Size = new System.Drawing.Size(43, 13);
            this.lblusuario.TabIndex = 2;
            this.lblusuario.Text = "Usuario";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(16, 29);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(44, 13);
            this.lblApellido.TabIndex = 1;
            this.lblApellido.Text = "Apellido";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(16, 10);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(870, 452);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 487);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(973, 526);
            this.MinimumSize = new System.Drawing.Size(973, 526);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menú Principal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPrincipal_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmPrincipal_FormClosed);
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblusuario;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.ToolStripMenuItem btnEmpleado;
        private System.Windows.Forms.ToolStripMenuItem transaccionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarVentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem notaDePedidoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevaNotaDePedidoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarNotasDePedidoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estadísticaToolStripMenuItem;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ToolStripMenuItem laboratorioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarLaboratoriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem laboratorioToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem medicamentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem obraSocialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnCrea_Modifica;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem btnModiLab;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem tipoDeUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarStockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productosMásVendidosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventasDeEmpleadosToolStripMenuItem;
    }
}

