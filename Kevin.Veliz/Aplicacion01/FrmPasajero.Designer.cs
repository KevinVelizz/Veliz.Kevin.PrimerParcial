namespace Aplicacion01
{
    partial class FrmPasajero
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
            btnAgregar = new Button();
            btnCancelar = new Button();
            txtApellido = new TextBox();
            txtDNI = new TextBox();
            txtNombre = new TextBox();
            txtEdad = new TextBox();
            lblNombre = new Label();
            lblApellido = new Label();
            label3 = new Label();
            lblEdad = new Label();
            btnLimpiar = new Button();
            lblPesoEquipaje2 = new Label();
            chkEquipajeMano = new CheckBox();
            label1 = new Label();
            cboClase = new ComboBox();
            lblPeso = new Label();
            nudPesoEquipaje1 = new NumericUpDown();
            nudPesoEquipaje2 = new NumericUpDown();
            btnModificar = new Button();
            chkVacunado = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)nudPesoEquipaje1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudPesoEquipaje2).BeginInit();
            SuspendLayout();
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(14, 415);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 0;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(222, 415);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(176, 62);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(100, 23);
            txtApellido.TabIndex = 2;
            // 
            // txtDNI
            // 
            txtDNI.Location = new Point(176, 109);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(100, 23);
            txtDNI.TabIndex = 4;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(176, 20);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 5;
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(176, 151);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(100, 23);
            txtEdad.TabIndex = 6;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI Symbol", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            lblNombre.Location = new Point(95, 26);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(60, 17);
            lblNombre.TabIndex = 7;
            lblNombre.Text = "Nombre:";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Font = new Font("Segoe UI Symbol", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            lblApellido.Location = new Point(96, 68);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(59, 17);
            lblApellido.TabIndex = 8;
            lblApellido.Text = "Apellido:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Symbol", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(122, 115);
            label3.Name = "label3";
            label3.Size = new Size(33, 17);
            label3.TabIndex = 9;
            label3.Text = "DNI:";
            // 
            // lblEdad
            // 
            lblEdad.AutoSize = true;
            lblEdad.Font = new Font("Segoe UI Symbol", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            lblEdad.Location = new Point(114, 157);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new Size(41, 17);
            lblEdad.TabIndex = 10;
            lblEdad.Text = "Edad:";
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(115, 415);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 16;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // lblPesoEquipaje2
            // 
            lblPesoEquipaje2.AutoSize = true;
            lblPesoEquipaje2.Font = new Font("Segoe UI Symbol", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            lblPesoEquipaje2.Location = new Point(3, 305);
            lblPesoEquipaje2.Name = "lblPesoEquipaje2";
            lblPesoEquipaje2.Size = new Size(154, 17);
            lblPesoEquipaje2.TabIndex = 56;
            lblPesoEquipaje2.Text = "Peso equipaje bodega 2:";
            // 
            // chkEquipajeMano
            // 
            chkEquipajeMano.AutoSize = true;
            chkEquipajeMano.Location = new Point(176, 348);
            chkEquipajeMano.Name = "chkEquipajeMano";
            chkEquipajeMano.Size = new Size(121, 19);
            chkEquipajeMano.TabIndex = 55;
            chkEquipajeMano.Text = "Equipaje de mano";
            chkEquipajeMano.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Symbol", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(115, 202);
            label1.Name = "label1";
            label1.Size = new Size(42, 17);
            label1.TabIndex = 54;
            label1.Text = "Clase:";
            // 
            // cboClase
            // 
            cboClase.FormattingEnabled = true;
            cboClase.Location = new Point(176, 196);
            cboClase.Name = "cboClase";
            cboClase.Size = new Size(100, 23);
            cboClase.TabIndex = 53;
            cboClase.Text = "--Seleccione--";
            cboClase.SelectedIndexChanged += cboClase_SelectedIndexChanged;
            // 
            // lblPeso
            // 
            lblPeso.AutoSize = true;
            lblPeso.Font = new Font("Segoe UI Symbol", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            lblPeso.Location = new Point(14, 256);
            lblPeso.Name = "lblPeso";
            lblPeso.Size = new Size(143, 17);
            lblPeso.TabIndex = 51;
            lblPeso.Text = "Peso equipaje bodega:";
            // 
            // nudPesoEquipaje1
            // 
            nudPesoEquipaje1.Font = new Font("Segoe UI Symbol", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            nudPesoEquipaje1.Location = new Point(176, 250);
            nudPesoEquipaje1.Maximum = new decimal(new int[] { 25, 0, 0, 0 });
            nudPesoEquipaje1.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudPesoEquipaje1.Name = "nudPesoEquipaje1";
            nudPesoEquipaje1.Size = new Size(100, 25);
            nudPesoEquipaje1.TabIndex = 57;
            nudPesoEquipaje1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // nudPesoEquipaje2
            // 
            nudPesoEquipaje2.Font = new Font("Segoe UI Symbol", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            nudPesoEquipaje2.Location = new Point(176, 299);
            nudPesoEquipaje2.Maximum = new decimal(new int[] { 21, 0, 0, 0 });
            nudPesoEquipaje2.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudPesoEquipaje2.Name = "nudPesoEquipaje2";
            nudPesoEquipaje2.Size = new Size(100, 25);
            nudPesoEquipaje2.TabIndex = 58;
            nudPesoEquipaje2.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(14, 386);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(75, 23);
            btnModificar.TabIndex = 59;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // chkVacunado
            // 
            chkVacunado.AutoSize = true;
            chkVacunado.Location = new Point(176, 373);
            chkVacunado.Name = "chkVacunado";
            chkVacunado.Size = new Size(64, 19);
            chkVacunado.TabIndex = 60;
            chkVacunado.Text = "Vacuna";
            chkVacunado.UseVisualStyleBackColor = true;
            // 
            // FrmPasajero
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(310, 450);
            Controls.Add(chkVacunado);
            Controls.Add(btnModificar);
            Controls.Add(nudPesoEquipaje2);
            Controls.Add(nudPesoEquipaje1);
            Controls.Add(lblPesoEquipaje2);
            Controls.Add(chkEquipajeMano);
            Controls.Add(label1);
            Controls.Add(cboClase);
            Controls.Add(lblPeso);
            Controls.Add(btnLimpiar);
            Controls.Add(lblEdad);
            Controls.Add(label3);
            Controls.Add(lblApellido);
            Controls.Add(lblNombre);
            Controls.Add(txtEdad);
            Controls.Add(txtNombre);
            Controls.Add(txtDNI);
            Controls.Add(txtApellido);
            Controls.Add(btnCancelar);
            Controls.Add(btnAgregar);
            Name = "FrmPasajero";
            Text = "FrmPasajero";
            Load += FrmPasajero_Load;
            ((System.ComponentModel.ISupportInitialize)nudPesoEquipaje1).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudPesoEquipaje2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAgregar;
        private Button btnCancelar;
        private TextBox txtApellido;
        private TextBox txtDNI;
        private TextBox txtNombre;
        private TextBox txtEdad;
        private Label lblNombre;
        private Label lblApellido;
        private Label label3;
        private Label lblEdad;
        private Button btnLimpiar;
        private Label lblPesoEquipaje2;
        private CheckBox chkEquipajeMano;
        private Label label1;
        private ComboBox cboClase;
        private TextBox txtPesoEquipaje;
        private Label lblPeso;
        private NumericUpDown numericUpDown1;
        private NumericUpDown nudEquipaje1;
        private NumericUpDown nudPesoEquipaje1;
        private NumericUpDown nudPesoEquipaje2;
        private Button btnModificar;
        private CheckBox chkVacunado;
    }
}