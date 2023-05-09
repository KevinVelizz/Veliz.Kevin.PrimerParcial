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
            stripAeronave = new ToolStripMenuItem();
            stripEstadistica = new ToolStripMenuItem();
            panelModificar = new Panel();
            lblNombreSeccion = new Label();
            Lista = new ListBox();
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
            menuAerolinea.Items.AddRange(new ToolStripItem[] { stripInicio, stripPasajero, stripVuelo, stripAeronave, stripEstadistica });
            menuAerolinea.Location = new Point(0, 0);
            menuAerolinea.Margin = new Padding(10);
            menuAerolinea.Name = "menuAerolinea";
            menuAerolinea.Padding = new Padding(6, 10, 0, 10);
            menuAerolinea.Size = new Size(951, 41);
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
            stripPasajero.Size = new Size(76, 40);
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
            panelModificar.Controls.Add(lblNombreSeccion);
            panelModificar.Controls.Add(Lista);
            panelModificar.Controls.Add(btnModificar);
            panelModificar.Controls.Add(btnEliminar);
            panelModificar.Controls.Add(btnAgregar);
            panelModificar.Location = new Point(865, 133);
            panelModificar.Name = "panelModificar";
            panelModificar.Size = new Size(74, 386);
            panelModificar.TabIndex = 3;
            panelModificar.Visible = false;
            // 
            // lblNombreSeccion
            // 
            lblNombreSeccion.AutoSize = true;
            lblNombreSeccion.Font = new Font("Segoe UI Symbol", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            lblNombreSeccion.Location = new Point(87, 8);
            lblNombreSeccion.Name = "lblNombreSeccion";
            lblNombreSeccion.Size = new Size(50, 20);
            lblNombreSeccion.TabIndex = 4;
            lblNombreSeccion.Text = "label1";
            // 
            // Lista
            // 
            Lista.Anchor = AnchorStyles.None;
            Lista.FormattingEnabled = true;
            Lista.ItemHeight = 15;
            Lista.Location = new Point(-334, 20);
            Lista.Name = "Lista";
            Lista.Size = new Size(686, 379);
            Lista.TabIndex = 3;
            Lista.SelectedIndexChanged += Lista_SelectedIndexChanged;
            // 
            // btnModificar
            // 
            btnModificar.Anchor = AnchorStyles.None;
            btnModificar.Location = new Point(368, 165);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(75, 51);
            btnModificar.TabIndex = 2;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Anchor = AnchorStyles.None;
            btnEliminar.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnEliminar.ForeColor = Color.Red;
            btnEliminar.Location = new Point(368, 93);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 50);
            btnEliminar.TabIndex = 1;
            btnEliminar.Text = "-";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            btnAgregar.Anchor = AnchorStyles.None;
            btnAgregar.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnAgregar.ForeColor = Color.LimeGreen;
            btnAgregar.Location = new Point(368, 20);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 49);
            btnAgregar.TabIndex = 0;
            btnAgregar.Text = "+";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ActiveCaption;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(255, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(103, 102);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // panelInicio
            // 
            panelInicio.Controls.Add(label1);
            panelInicio.Controls.Add(pictureBox1);
            panelInicio.Location = new Point(116, 153);
            panelInicio.Name = "panelInicio";
            panelInicio.Size = new Size(668, 355);
            panelInicio.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Symbol", 24F, FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(191, 108);
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
            ClientSize = new Size(951, 573);
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
        private ListBox Lista;
        private ToolStripMenuItem stripAeronave;
        private Label lblNombreSeccion;
        private PictureBox pictureBox1;
        private Panel panelInicio;
        private Label label1;
    }
}