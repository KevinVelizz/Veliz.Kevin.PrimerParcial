namespace Aplicacion01
{
    partial class FrmAerolinea
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAerolinea));
            menuAerolinea = new MenuStrip();
            stripInicio = new ToolStripMenuItem();
            stripPasajero = new ToolStripMenuItem();
            stripVuelo = new ToolStripMenuItem();
            stripVender = new ToolStripMenuItem();
            stripAeronave = new ToolStripMenuItem();
            stripEstadistica = new ToolStripMenuItem();
            StripEstadisticaViajes = new ToolStripMenuItem();
            StripTxtHora = new ToolStripTextBox();
            StripNombreOperador = new ToolStripTextBox();
            StripCuenta = new ToolStripMenuItem();
            StripCerrarSesion = new ToolStripMenuItem();
            panelModificar = new Panel();
            dtgvElementos = new DataGridView();
            lblDniBuscar = new Label();
            lblApellidoBuscar = new Label();
            lblNombreBuscar = new Label();
            panelInicio = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            btnMostrarPasajeros = new Button();
            txtBuscarDNI = new TextBox();
            txtBuscarApellido = new TextBox();
            btnBuscar = new Button();
            txtBuscarNombre = new TextBox();
            lblNombreSeccion = new Label();
            btnModificar = new Button();
            btnEliminar = new Button();
            btnAgregar = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            menuAerolinea.SuspendLayout();
            panelModificar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvElementos).BeginInit();
            panelInicio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // menuAerolinea
            // 
            menuAerolinea.AutoSize = false;
            menuAerolinea.BackColor = SystemColors.ActiveCaption;
            menuAerolinea.Font = new Font("Segoe UI Symbol", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            menuAerolinea.GripStyle = ToolStripGripStyle.Visible;
            menuAerolinea.Items.AddRange(new ToolStripItem[] { stripInicio, stripPasajero, stripVuelo, stripVender, stripAeronave, stripEstadistica, StripTxtHora, StripNombreOperador, StripCuenta });
            menuAerolinea.Location = new Point(0, 0);
            menuAerolinea.Margin = new Padding(10, 11, 10, 11);
            menuAerolinea.Name = "menuAerolinea";
            menuAerolinea.Padding = new Padding(6, 11, 0, 11);
            menuAerolinea.Size = new Size(1441, 46);
            menuAerolinea.TabIndex = 2;
            menuAerolinea.Text = "menuAerolinea";
            // 
            // stripInicio
            // 
            stripInicio.AutoSize = false;
            stripInicio.Name = "stripInicio";
            stripInicio.Size = new Size(50, 40);
            stripInicio.Text = "Inicio";
            stripInicio.Click += stripInicio_Click;
            // 
            // stripPasajero
            // 
            stripPasajero.AutoSize = false;
            stripPasajero.BackColor = SystemColors.ActiveCaption;
            stripPasajero.ForeColor = SystemColors.ControlText;
            stripPasajero.Name = "stripPasajero";
            stripPasajero.Size = new Size(90, 40);
            stripPasajero.Text = "Pasajeros";
            stripPasajero.Click += stripPasajero_Click;
            // 
            // stripVuelo
            // 
            stripVuelo.AutoSize = false;
            stripVuelo.Name = "stripVuelo";
            stripVuelo.Size = new Size(59, 40);
            stripVuelo.Text = "Vuelos";
            stripVuelo.Click += stripVuelo_Click;
            // 
            // stripVender
            // 
            stripVender.AutoSize = false;
            stripVender.Name = "stripVender";
            stripVender.Size = new Size(97, 40);
            stripVender.Text = "Vender vuelo";
            stripVender.Visible = false;
            stripVender.Click += stripVender_Click;
            // 
            // stripAeronave
            // 
            stripAeronave.AutoSize = false;
            stripAeronave.Name = "stripAeronave";
            stripAeronave.Size = new Size(81, 40);
            stripAeronave.Text = "Aeronaves";
            stripAeronave.Click += stripAeronave_Click;
            // 
            // stripEstadistica
            // 
            stripEstadistica.AutoSize = false;
            stripEstadistica.DropDownItems.AddRange(new ToolStripItem[] { StripEstadisticaViajes });
            stripEstadistica.Name = "stripEstadistica";
            stripEstadistica.Size = new Size(87, 40);
            stripEstadistica.Text = "Estadisticas";
            stripEstadistica.Click += stripEstadistica_Click;
            // 
            // StripEstadisticaViajes
            // 
            StripEstadisticaViajes.Name = "StripEstadisticaViajes";
            StripEstadisticaViajes.Size = new Size(110, 22);
            StripEstadisticaViajes.Text = "Viajes";
            StripEstadisticaViajes.Click += StripEstadisticaViajes_Click;
            // 
            // StripTxtHora
            // 
            StripTxtHora.Alignment = ToolStripItemAlignment.Right;
            StripTxtHora.Enabled = false;
            StripTxtHora.Font = new Font("Segoe UI Symbol", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            StripTxtHora.Name = "StripTxtHora";
            StripTxtHora.Size = new Size(100, 24);
            // 
            // StripNombreOperador
            // 
            StripNombreOperador.Alignment = ToolStripItemAlignment.Right;
            StripNombreOperador.Font = new Font("Segoe UI Symbol", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            StripNombreOperador.Name = "StripNombreOperador";
            StripNombreOperador.Size = new Size(100, 24);
            // 
            // StripCuenta
            // 
            StripCuenta.Alignment = ToolStripItemAlignment.Right;
            StripCuenta.DropDownItems.AddRange(new ToolStripItem[] { StripCerrarSesion });
            StripCuenta.Name = "StripCuenta";
            StripCuenta.Size = new Size(60, 24);
            StripCuenta.Text = "Cuenta";
            // 
            // StripCerrarSesion
            // 
            StripCerrarSesion.Name = "StripCerrarSesion";
            StripCerrarSesion.Size = new Size(155, 22);
            StripCerrarSesion.Text = "Cerrar Sesión";
            StripCerrarSesion.Click += StripCerrarSesion_Click;
            // 
            // panelModificar
            // 
            panelModificar.Anchor = AnchorStyles.None;
            panelModificar.BackColor = SystemColors.AppWorkspace;
            panelModificar.Controls.Add(dtgvElementos);
            panelModificar.Controls.Add(lblDniBuscar);
            panelModificar.Controls.Add(lblApellidoBuscar);
            panelModificar.Controls.Add(lblNombreBuscar);
            panelModificar.Controls.Add(panelInicio);
            panelModificar.Controls.Add(btnMostrarPasajeros);
            panelModificar.Controls.Add(txtBuscarDNI);
            panelModificar.Controls.Add(txtBuscarApellido);
            panelModificar.Controls.Add(btnBuscar);
            panelModificar.Controls.Add(txtBuscarNombre);
            panelModificar.Controls.Add(lblNombreSeccion);
            panelModificar.Controls.Add(btnModificar);
            panelModificar.Controls.Add(btnEliminar);
            panelModificar.Controls.Add(btnAgregar);
            panelModificar.Location = new Point(0, 43);
            panelModificar.Name = "panelModificar";
            panelModificar.Size = new Size(1441, 678);
            panelModificar.TabIndex = 3;
            panelModificar.Visible = false;
            panelModificar.Paint += panelModificar_Paint;
            // 
            // dtgvElementos
            // 
            dtgvElementos.Anchor = AnchorStyles.None;
            dtgvElementos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvElementos.Location = new Point(27, 99);
            dtgvElementos.Name = "dtgvElementos";
            dtgvElementos.ReadOnly = true;
            dtgvElementos.RowTemplate.Height = 25;
            dtgvElementos.Size = new Size(1321, 415);
            dtgvElementos.TabIndex = 14;
            dtgvElementos.CellClick += dtgvElementos_CellClick;
            // 
            // lblDniBuscar
            // 
            lblDniBuscar.AutoSize = true;
            lblDniBuscar.Font = new Font("Segoe UI Symbol", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            lblDniBuscar.Location = new Point(269, 45);
            lblDniBuscar.Name = "lblDniBuscar";
            lblDniBuscar.Size = new Size(38, 20);
            lblDniBuscar.TabIndex = 13;
            lblDniBuscar.Text = "DNI:";
            // 
            // lblApellidoBuscar
            // 
            lblApellidoBuscar.AutoSize = true;
            lblApellidoBuscar.Font = new Font("Segoe UI Symbol", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            lblApellidoBuscar.Location = new Point(148, 45);
            lblApellidoBuscar.Name = "lblApellidoBuscar";
            lblApellidoBuscar.Size = new Size(69, 20);
            lblApellidoBuscar.TabIndex = 12;
            lblApellidoBuscar.Text = "Apellido:";
            // 
            // lblNombreBuscar
            // 
            lblNombreBuscar.AutoSize = true;
            lblNombreBuscar.Font = new Font("Segoe UI Symbol", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            lblNombreBuscar.Location = new Point(40, 45);
            lblNombreBuscar.Name = "lblNombreBuscar";
            lblNombreBuscar.Size = new Size(67, 20);
            lblNombreBuscar.TabIndex = 11;
            lblNombreBuscar.Text = "Nombre:";
            // 
            // panelInicio
            // 
            panelInicio.Controls.Add(label1);
            panelInicio.Controls.Add(pictureBox1);
            panelInicio.Location = new Point(1385, 5);
            panelInicio.Name = "panelInicio";
            panelInicio.Size = new Size(53, 56);
            panelInicio.TabIndex = 5;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Symbol", 24F, FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(-77, 46);
            label1.Name = "label1";
            label1.Size = new Size(220, 45);
            label1.TabIndex = 5;
            label1.Text = "BIENVENIDO!!";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.BackColor = SystemColors.ActiveCaption;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-18, -88);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(103, 116);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // btnMostrarPasajeros
            // 
            btnMostrarPasajeros.Location = new Point(1354, 287);
            btnMostrarPasajeros.Name = "btnMostrarPasajeros";
            btnMostrarPasajeros.Size = new Size(75, 52);
            btnMostrarPasajeros.TabIndex = 10;
            btnMostrarPasajeros.Text = "Mostrar pasajeros";
            btnMostrarPasajeros.UseVisualStyleBackColor = true;
            btnMostrarPasajeros.Visible = false;
            btnMostrarPasajeros.Click += btnMostrarPasajeros_Click;
            // 
            // txtBuscarDNI
            // 
            txtBuscarDNI.Location = new Point(239, 67);
            txtBuscarDNI.Name = "txtBuscarDNI";
            txtBuscarDNI.Size = new Size(100, 25);
            txtBuscarDNI.TabIndex = 9;
            txtBuscarDNI.Visible = false;
            // 
            // txtBuscarApellido
            // 
            txtBuscarApellido.Location = new Point(133, 67);
            txtBuscarApellido.Name = "txtBuscarApellido";
            txtBuscarApellido.Size = new Size(100, 25);
            txtBuscarApellido.TabIndex = 8;
            txtBuscarApellido.Visible = false;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(364, 67);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(80, 25);
            btnBuscar.TabIndex = 7;
            btnBuscar.Text = "Filtrar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Visible = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtBuscarNombre
            // 
            txtBuscarNombre.Location = new Point(27, 68);
            txtBuscarNombre.Name = "txtBuscarNombre";
            txtBuscarNombre.Size = new Size(100, 25);
            txtBuscarNombre.TabIndex = 6;
            txtBuscarNombre.Visible = false;
            // 
            // lblNombreSeccion
            // 
            lblNombreSeccion.AutoSize = true;
            lblNombreSeccion.Font = new Font("Segoe UI Symbol", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            lblNombreSeccion.Location = new Point(556, 52);
            lblNombreSeccion.Name = "lblNombreSeccion";
            lblNombreSeccion.Size = new Size(50, 20);
            lblNombreSeccion.TabIndex = 4;
            lblNombreSeccion.Text = "label1";
            // 
            // btnModificar
            // 
            btnModificar.Anchor = AnchorStyles.None;
            btnModificar.Location = new Point(1354, 223);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(75, 58);
            btnModificar.TabIndex = 2;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Anchor = AnchorStyles.None;
            btnEliminar.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnEliminar.ForeColor = Color.Red;
            btnEliminar.Location = new Point(1354, 160);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 57);
            btnEliminar.TabIndex = 1;
            btnEliminar.Text = "-";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Anchor = AnchorStyles.None;
            btnAgregar.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnAgregar.ForeColor = Color.LimeGreen;
            btnAgregar.Location = new Point(1354, 98);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 56);
            btnAgregar.TabIndex = 0;
            btnAgregar.Text = "+";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // FrmAerolinea
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1441, 711);
            Controls.Add(panelModificar);
            Controls.Add(menuAerolinea);
            Font = new Font("Segoe UI Symbol", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            MainMenuStrip = menuAerolinea;
            Name = "FrmAerolinea";
            Text = "Aerolineas";
            Load += Aerolineas_Load;
            menuAerolinea.ResumeLayout(false);
            menuAerolinea.PerformLayout();
            panelModificar.ResumeLayout(false);
            panelModificar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvElementos).EndInit();
            panelInicio.ResumeLayout(false);
            panelInicio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private ToolStripMenuItem stripInicio;
        private ToolStripMenuItem stripPasajero;
        private ToolStripMenuItem stripVuelo;
        private ToolStripMenuItem stripEstadistica;
        private Button btnModificar;
        private Button btnEliminar;
        private Button btnAgregar;
        private ToolStripMenuItem stripAeronave;
        private Label lblNombreSeccion;
        private PictureBox pictureBox1;
        private Label label1;
        private ToolStripMenuItem stripVender;
        private ToolStripMenuItem StripCuenta;
        private ToolStripMenuItem StripCerrarSesion;
        private System.Windows.Forms.Timer timer1;
        private ToolStripTextBox StripTxtHora;
        private ToolStripMenuItem StripEstadisticaViajes;
        protected MenuStrip menuAerolinea;
        protected Panel panelModificar;
        protected Panel panelInicio;
        private TextBox txtBuscarDNI;
        private TextBox txtBuscarApellido;
        private Button btnBuscar;
        private TextBox txtBuscarNombre;
        private Button btnMostrarPasajeros;
        private Label lblDniBuscar;
        private Label lblApellidoBuscar;
        private Label lblNombreBuscar;
        private ToolStripTextBox StripNombreOperador;
        private DataGridView dtgvElementos;
    }
}