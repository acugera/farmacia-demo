namespace TPIntegrador
{
    partial class frmEmpleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmpleado));
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.dgvModificar = new System.Windows.Forms.DataGridView();
            this.idEmpleadoModificar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreEmpleadoModificar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoEmpleadoModificar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCancelarModificar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.cmbPerfilModificar = new System.Windows.Forms.ComboBox();
            this.txtContrRepModificar = new System.Windows.Forms.TextBox();
            this.txtContraseñaModificar = new System.Windows.Forms.TextBox();
            this.txtUsuarioModificar = new System.Windows.Forms.TextBox();
            this.txtApellidoModificar = new System.Windows.Forms.TextBox();
            this.txtNombreModificar = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbpNuevo = new System.Windows.Forms.TabPage();
            this.dgvCrear = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.txtContraseñaRepetida = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.cmbPerfil = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.tbpBuscar = new System.Windows.Forms.TabPage();
            this.dgvBusqueda = new System.Windows.Forms.DataGridView();
            this.idEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perfil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarioEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.cmbBuscar = new System.Windows.Forms.ComboBox();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModificar)).BeginInit();
            this.tbpNuevo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCrear)).BeginInit();
            this.tbpBuscar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBusqueda)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.DarkGray;
            this.tabPage1.Controls.Add(this.btnEliminar);
            this.tabPage1.Controls.Add(this.dgvModificar);
            this.tabPage1.Controls.Add(this.btnCancelarModificar);
            this.tabPage1.Controls.Add(this.btnModificar);
            this.tabPage1.Controls.Add(this.cmbPerfilModificar);
            this.tabPage1.Controls.Add(this.txtContrRepModificar);
            this.tabPage1.Controls.Add(this.txtContraseñaModificar);
            this.tabPage1.Controls.Add(this.txtUsuarioModificar);
            this.tabPage1.Controls.Add(this.txtApellidoModificar);
            this.tabPage1.Controls.Add(this.txtNombreModificar);
            this.tabPage1.Controls.Add(this.label15);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(673, 324);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Modificar";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Enabled = false;
            this.btnEliminar.Location = new System.Drawing.Point(122, 259);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 17;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // dgvModificar
            // 
            this.dgvModificar.AllowUserToAddRows = false;
            this.dgvModificar.AllowUserToDeleteRows = false;
            this.dgvModificar.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvModificar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvModificar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idEmpleadoModificar,
            this.nombreEmpleadoModificar,
            this.apellidoEmpleadoModificar});
            this.dgvModificar.Location = new System.Drawing.Point(293, 43);
            this.dgvModificar.Name = "dgvModificar";
            this.dgvModificar.ReadOnly = true;
            this.dgvModificar.Size = new System.Drawing.Size(372, 239);
            this.dgvModificar.TabIndex = 16;
            this.dgvModificar.SelectionChanged += new System.EventHandler(this.dgvModificar_SelectionChanged);
            // 
            // idEmpleadoModificar
            // 
            this.idEmpleadoModificar.HeaderText = "Nro.de Empleado";
            this.idEmpleadoModificar.Name = "idEmpleadoModificar";
            this.idEmpleadoModificar.ReadOnly = true;
            // 
            // nombreEmpleadoModificar
            // 
            this.nombreEmpleadoModificar.HeaderText = "Nombre";
            this.nombreEmpleadoModificar.Name = "nombreEmpleadoModificar";
            this.nombreEmpleadoModificar.ReadOnly = true;
            // 
            // apellidoEmpleadoModificar
            // 
            this.apellidoEmpleadoModificar.HeaderText = "Apellido";
            this.apellidoEmpleadoModificar.Name = "apellidoEmpleadoModificar";
            this.apellidoEmpleadoModificar.ReadOnly = true;
            // 
            // btnCancelarModificar
            // 
            this.btnCancelarModificar.Enabled = false;
            this.btnCancelarModificar.Location = new System.Drawing.Point(203, 259);
            this.btnCancelarModificar.Name = "btnCancelarModificar";
            this.btnCancelarModificar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarModificar.TabIndex = 15;
            this.btnCancelarModificar.Text = "Cancelar";
            this.btnCancelarModificar.UseVisualStyleBackColor = true;
            this.btnCancelarModificar.Click += new System.EventHandler(this.btnCancelarModificar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Enabled = false;
            this.btnModificar.Location = new System.Drawing.Point(45, 259);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 14;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // cmbPerfilModificar
            // 
            this.cmbPerfilModificar.Enabled = false;
            this.cmbPerfilModificar.FormattingEnabled = true;
            this.cmbPerfilModificar.Location = new System.Drawing.Point(110, 170);
            this.cmbPerfilModificar.Name = "cmbPerfilModificar";
            this.cmbPerfilModificar.Size = new System.Drawing.Size(168, 21);
            this.cmbPerfilModificar.TabIndex = 13;
            // 
            // txtContrRepModificar
            // 
            this.txtContrRepModificar.Enabled = false;
            this.txtContrRepModificar.Location = new System.Drawing.Point(110, 144);
            this.txtContrRepModificar.Name = "txtContrRepModificar";
            this.txtContrRepModificar.Size = new System.Drawing.Size(168, 20);
            this.txtContrRepModificar.TabIndex = 11;
            this.txtContrRepModificar.UseSystemPasswordChar = true;
            // 
            // txtContraseñaModificar
            // 
            this.txtContraseñaModificar.Enabled = false;
            this.txtContraseñaModificar.Location = new System.Drawing.Point(110, 118);
            this.txtContraseñaModificar.Name = "txtContraseñaModificar";
            this.txtContraseñaModificar.Size = new System.Drawing.Size(168, 20);
            this.txtContraseñaModificar.TabIndex = 10;
            this.txtContraseñaModificar.UseSystemPasswordChar = true;
            // 
            // txtUsuarioModificar
            // 
            this.txtUsuarioModificar.Enabled = false;
            this.txtUsuarioModificar.Location = new System.Drawing.Point(109, 92);
            this.txtUsuarioModificar.Name = "txtUsuarioModificar";
            this.txtUsuarioModificar.Size = new System.Drawing.Size(169, 20);
            this.txtUsuarioModificar.TabIndex = 9;
            // 
            // txtApellidoModificar
            // 
            this.txtApellidoModificar.Enabled = false;
            this.txtApellidoModificar.Location = new System.Drawing.Point(110, 66);
            this.txtApellidoModificar.Name = "txtApellidoModificar";
            this.txtApellidoModificar.Size = new System.Drawing.Size(168, 20);
            this.txtApellidoModificar.TabIndex = 8;
            // 
            // txtNombreModificar
            // 
            this.txtNombreModificar.Enabled = false;
            this.txtNombreModificar.Location = new System.Drawing.Point(110, 40);
            this.txtNombreModificar.Name = "txtNombreModificar";
            this.txtNombreModificar.Size = new System.Drawing.Size(168, 20);
            this.txtNombreModificar.TabIndex = 7;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(74, 173);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(30, 13);
            this.label15.TabIndex = 6;
            this.label15.Text = "Perfil";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 147);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(97, 13);
            this.label13.TabIndex = 4;
            this.label13.Text = "Repetir contraseña";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(42, 121);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 13);
            this.label12.TabIndex = 3;
            this.label12.Text = "Contraseña";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(60, 95);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Usuario";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(59, 69);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Apellido";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(60, 43);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Nombre";
            // 
            // tbpNuevo
            // 
            this.tbpNuevo.BackColor = System.Drawing.Color.DarkGray;
            this.tbpNuevo.Controls.Add(this.dgvCrear);
            this.tbpNuevo.Controls.Add(this.label8);
            this.tbpNuevo.Controls.Add(this.txtContraseñaRepetida);
            this.tbpNuevo.Controls.Add(this.txtUsuario);
            this.tbpNuevo.Controls.Add(this.txtApellido);
            this.tbpNuevo.Controls.Add(this.txtNombre);
            this.tbpNuevo.Controls.Add(this.txtContraseña);
            this.tbpNuevo.Controls.Add(this.cmbPerfil);
            this.tbpNuevo.Controls.Add(this.label7);
            this.tbpNuevo.Controls.Add(this.label6);
            this.tbpNuevo.Controls.Add(this.label5);
            this.tbpNuevo.Controls.Add(this.label4);
            this.tbpNuevo.Controls.Add(this.label3);
            this.tbpNuevo.Controls.Add(this.btnCancelar);
            this.tbpNuevo.Controls.Add(this.btnGuardar);
            this.tbpNuevo.Location = new System.Drawing.Point(4, 22);
            this.tbpNuevo.Name = "tbpNuevo";
            this.tbpNuevo.Padding = new System.Windows.Forms.Padding(3);
            this.tbpNuevo.Size = new System.Drawing.Size(673, 324);
            this.tbpNuevo.TabIndex = 1;
            this.tbpNuevo.Text = "Nuevo";
            // 
            // dgvCrear
            // 
            this.dgvCrear.AllowUserToAddRows = false;
            this.dgvCrear.AllowUserToDeleteRows = false;
            this.dgvCrear.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvCrear.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCrear.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dgvCrear.Location = new System.Drawing.Point(293, 31);
            this.dgvCrear.Name = "dgvCrear";
            this.dgvCrear.ReadOnly = true;
            this.dgvCrear.Size = new System.Drawing.Size(372, 239);
            this.dgvCrear.TabIndex = 17;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Nro.de Empleado";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Apellido";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 149);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Repetir contraseña";
            // 
            // txtContraseñaRepetida
            // 
            this.txtContraseñaRepetida.Location = new System.Drawing.Point(111, 146);
            this.txtContraseñaRepetida.Name = "txtContraseñaRepetida";
            this.txtContraseñaRepetida.Size = new System.Drawing.Size(153, 20);
            this.txtContraseñaRepetida.TabIndex = 4;
            this.txtContraseñaRepetida.UseSystemPasswordChar = true;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(111, 94);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(153, 20);
            this.txtUsuario.TabIndex = 2;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(111, 68);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(153, 20);
            this.txtApellido.TabIndex = 1;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(111, 42);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(153, 20);
            this.txtNombre.TabIndex = 0;
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(111, 120);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(153, 20);
            this.txtContraseña.TabIndex = 3;
            this.txtContraseña.UseSystemPasswordChar = true;
            // 
            // cmbPerfil
            // 
            this.cmbPerfil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPerfil.FormattingEnabled = true;
            this.cmbPerfil.Location = new System.Drawing.Point(111, 175);
            this.cmbPerfil.Name = "cmbPerfil";
            this.cmbPerfil.Size = new System.Drawing.Size(153, 21);
            this.cmbPerfil.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(75, 178);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Perfil";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(44, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Contraseña";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(62, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Usuario";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Apellido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Nombre";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(189, 224);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(108, 224);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 6;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // tbpBuscar
            // 
            this.tbpBuscar.Controls.Add(this.dgvBusqueda);
            this.tbpBuscar.Controls.Add(this.label1);
            this.tbpBuscar.Controls.Add(this.btnBuscar);
            this.tbpBuscar.Controls.Add(this.cmbBuscar);
            this.tbpBuscar.Controls.Add(this.txtBuscar);
            this.tbpBuscar.Location = new System.Drawing.Point(4, 22);
            this.tbpBuscar.Name = "tbpBuscar";
            this.tbpBuscar.Padding = new System.Windows.Forms.Padding(3);
            this.tbpBuscar.Size = new System.Drawing.Size(673, 324);
            this.tbpBuscar.TabIndex = 0;
            this.tbpBuscar.Text = "Buscar";
            this.tbpBuscar.UseVisualStyleBackColor = true;
            // 
            // dgvBusqueda
            // 
            this.dgvBusqueda.AllowUserToAddRows = false;
            this.dgvBusqueda.AllowUserToDeleteRows = false;
            this.dgvBusqueda.AllowUserToResizeColumns = false;
            this.dgvBusqueda.AllowUserToResizeRows = false;
            this.dgvBusqueda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBusqueda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idEmpleado,
            this.perfil,
            this.nombreEmpleado,
            this.apellidoEmpleado,
            this.usuarioEmpleado});
            this.dgvBusqueda.Location = new System.Drawing.Point(6, 59);
            this.dgvBusqueda.Name = "dgvBusqueda";
            this.dgvBusqueda.ReadOnly = true;
            this.dgvBusqueda.Size = new System.Drawing.Size(661, 262);
            this.dgvBusqueda.TabIndex = 4;
            // 
            // idEmpleado
            // 
            this.idEmpleado.HeaderText = "Nro. Empleado";
            this.idEmpleado.Name = "idEmpleado";
            this.idEmpleado.ReadOnly = true;
            // 
            // perfil
            // 
            this.perfil.HeaderText = "Perfil";
            this.perfil.Name = "perfil";
            this.perfil.ReadOnly = true;
            // 
            // nombreEmpleado
            // 
            this.nombreEmpleado.HeaderText = "Nombre";
            this.nombreEmpleado.Name = "nombreEmpleado";
            this.nombreEmpleado.ReadOnly = true;
            // 
            // apellidoEmpleado
            // 
            this.apellidoEmpleado.HeaderText = "Apellido";
            this.apellidoEmpleado.Name = "apellidoEmpleado";
            this.apellidoEmpleado.ReadOnly = true;
            // 
            // usuarioEmpleado
            // 
            this.usuarioEmpleado.HeaderText = "Usuario";
            this.usuarioEmpleado.Name = "usuarioEmpleado";
            this.usuarioEmpleado.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Buscar por: ";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(531, 8);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(134, 23);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // cmbBuscar
            // 
            this.cmbBuscar.DisplayMember = "6";
            this.cmbBuscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBuscar.FormattingEnabled = true;
            this.cmbBuscar.Items.AddRange(new object[] {
            "Número de Empleado",
            "Perfil",
            "Nombre",
            "Apellido",
            "Usuario",
            "Todos"});
            this.cmbBuscar.Location = new System.Drawing.Point(78, 10);
            this.cmbBuscar.Name = "cmbBuscar";
            this.cmbBuscar.Size = new System.Drawing.Size(168, 21);
            this.cmbBuscar.TabIndex = 0;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(252, 10);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(273, 20);
            this.txtBuscar.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbpBuscar);
            this.tabControl1.Controls.Add(this.tbpNuevo);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(0, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(681, 350);
            this.tabControl1.TabIndex = 2;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(594, 357);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 18;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 386);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(697, 425);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(697, 425);
            this.Name = "frmEmpleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Empleados";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmEmpleado_FormClosing);
            this.Load += new System.EventHandler(this.frmEmpleado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModificar)).EndInit();
            this.tbpNuevo.ResumeLayout(false);
            this.tbpNuevo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCrear)).EndInit();
            this.tbpBuscar.ResumeLayout(false);
            this.tbpBuscar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBusqueda)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridView dgvModificar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEmpleadoModificar;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreEmpleadoModificar;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoEmpleadoModificar;
        private System.Windows.Forms.Button btnCancelarModificar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.ComboBox cmbPerfilModificar;
        private System.Windows.Forms.TextBox txtContrRepModificar;
        private System.Windows.Forms.TextBox txtContraseñaModificar;
        private System.Windows.Forms.TextBox txtUsuarioModificar;
        private System.Windows.Forms.TextBox txtApellidoModificar;
        private System.Windows.Forms.TextBox txtNombreModificar;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TabPage tbpNuevo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtContraseñaRepetida;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.ComboBox cmbPerfil;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TabPage tbpBuscar;
        private System.Windows.Forms.DataGridView dgvBusqueda;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn perfil;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuarioEmpleado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ComboBox cmbBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridView dgvCrear;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}