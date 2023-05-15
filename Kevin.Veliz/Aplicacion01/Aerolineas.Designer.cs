namespace Aplicacion01
{
    partial class Aerolineas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Aerolineas));
            menuAerolinea = new MenuStrip();
            stripInicio = new ToolStripMenuItem();
            stripPasajero = new ToolStripMenuItem();
            stripVuelo = new ToolStripMenuItem();
            stripVender = new ToolStripMenuItem();
            stripAeronave = new ToolStripMenuItem();
            stripEstadistica = new ToolStripMenuItem();
            panelModificar = new Panel();
            lblNombreSeccion = new Label();
            lstListaElementos = new ListBox();
            btnModificar = new Button();
            btnEliminar = new Button();
            btnAgregar = new Button();
            pictureBox1 = new PictureBox();
            panelInicio = new Panel();
            label1 = new Label();
            menuAerolinea.SuspendLayout();
            panelModificar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelInicio.SuspendLayout();
            SuspendLayout();
            // 
            // menuAerolinea
            // 
            menuAerolinea.AutoSize = false;
            menuAerolinea.BackColor = SystemColors.ActiveCaption;
            menuAerolinea.Font = new Font("Segoe UI Symbol", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            menuAerolinea.Items.AddRange(new ToolStripItem[] { stripInicio, stripPasajero, stripVuelo, stripVender, stripAeronave, stripEstadistica });
            menuAerolinea.Location = new Point(0, 0);
            menuAerolinea.Margin = new Padding(10);
            menuAerolinea.Name = "menuAerolinea";
            menuAerolinea.Padding = new Padding(6, 10, 0, 10);
            menuAerolinea.Size = new Size(1280, 41);
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
            stripEstadistica.Name = "stripEstadistica";
            stripEstadistica.Size = new Size(87, 40);
            stripEstadistica.Text = "Estadisticas";
            stripEstadistica.Click += stripEstadistica_Click;
            // 
            // panelModificar
            // 
            panelModificar.Anchor = AnchorStyles.None;
            panelModificar.BackColor = SystemColors.AppWorkspace;
            panelModificar.Controls.Add(lblNombreSeccion);
            panelModificar.Controls.Add(lstListaElementos);
            panelModificar.Controls.Add(btnModificar);
            panelModificar.Controls.Add(btnEliminar);
            panelModificar.Controls.Add(btnAgregar);
            panelModificar.Location = new Point(12, 84);
            panelModificar.Name = "panelModificar";
            panelModificar.Size = new Size(1256, 523);
            panelModificar.TabIndex = 3;
            panelModificar.Visible = false;
            // 
            // lblNombreSeccion
            // 
            lblNombreSeccion.AutoSize = true;
            lblNombreSeccion.Font = new Font("Segoe UI Symbol", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            lblNombreSeccion.Location = new Point(538, 25);
            lblNombreSeccion.Name = "lblNombreSeccion";
            lblNombreSeccion.Size = new Size(50, 20);
            lblNombreSeccion.TabIndex = 4;
            lblNombreSeccion.Text = "label1";
            // 
            // lstListaElementos
            // 
            lstListaElementos.Anchor = AnchorStyles.None;
            lstListaElementos.FormattingEnabled = true;
            lstListaElementos.ItemHeight = 15;
            lstListaElementos.Location = new Point(3, 59);
            lstListaElementos.Name = "lstListaElementos";
            lstListaElementos.Size = new Size(1158, 424);
            lstListaElementos.TabIndex = 3;
            // 
            // btnModificar
            // 
            btnModificar.Anchor = AnchorStyles.None;
            btnModificar.Location = new Point(1167, 214);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(75, 51);
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
            btnEliminar.Location = new Point(1167, 137);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 50);
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
            btnAgregar.Location = new Point(1167, 59);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 49);
            btnAgregar.TabIndex = 0;
            btnAgregar.Text = "+";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.BackColor = SystemColors.ActiveCaption;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-18, -78);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(103, 102);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // panelInicio
            // 
            panelInicio.Controls.Add(label1);
            panelInicio.Controls.Add(pictureBox1);
            panelInicio.Location = new Point(12, 54);
            panelInicio.Name = "panelInicio";
            panelInicio.Size = new Size(53, 49);
            panelInicio.TabIndex = 5;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Symbol", 24F, FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(-77, 41);
            label1.Name = "label1";
            label1.Size = new Size(220, 45);
            label1.TabIndex = 5;
            label1.Text = "BIENVENIDO!!";
            // 
            // Aerolineas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1280, 627);
            Controls.Add(panelInicio);
            Controls.Add(panelModificar);
            Controls.Add(menuAerolinea);
            MainMenuStrip = menuAerolinea;
            Name = "Aerolineas";
            Text = "Aerolineas";
            Load += Aerolineas_Load;
            menuAerolinea.ResumeLayout(false);
            menuAerolinea.PerformLayout();
            panelModificar.ResumeLayout(false);
            panelModificar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelInicio.ResumeLayout(false);
            panelInicio.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private MenuStrip menuAerolinea;
        private ToolStripMenuItem stripInicio;
        private ToolStripMenuItem stripPasajero;
        private ToolStripMenuItem stripVuelo;
        private ToolStripMenuItem stripEstadistica;
        private Panel panelModificar;
        private Button btnModificar;
        private Button btnEliminar;
        private Button btnAgregar;
        private ListBox lstListaElementos;
        private ToolStripMenuItem stripAeronave;
        private Label lblNombreSeccion;
        private PictureBox pictureBox1;
        private Panel panelInicio;
        private Label label1;
        private ToolStripMenuItem stripVender;
    }
}