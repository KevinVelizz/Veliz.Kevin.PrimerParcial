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
            cboEquipaje = new ComboBox();
            lblEquipaje = new Label();
            lblPeso = new Label();
            txtPesoEquipaje = new TextBox();
            btnLimpiar = new Button();
            cboClase = new ComboBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(7, 356);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 0;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(239, 356);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(122, 65);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(100, 23);
            txtApellido.TabIndex = 2;
            // 
            // txtDNI
            // 
            txtDNI.Location = new Point(122, 112);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(100, 23);
            txtDNI.TabIndex = 4;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(122, 23);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 5;
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(122, 154);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(100, 23);
            txtEdad.TabIndex = 6;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI Symbol", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            lblNombre.Location = new Point(28, 31);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(60, 17);
            lblNombre.TabIndex = 7;
            lblNombre.Text = "Nombre:";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Font = new Font("Segoe UI Symbol", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            lblApellido.Location = new Point(28, 73);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(59, 17);
            lblApellido.TabIndex = 8;
            lblApellido.Text = "Apellido:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Symbol", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(52, 120);
            label3.Name = "label3";
            label3.Size = new Size(33, 17);
            label3.TabIndex = 9;
            label3.Text = "DNI:";
            // 
            // lblEdad
            // 
            lblEdad.AutoSize = true;
            lblEdad.Font = new Font("Segoe UI Symbol", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            lblEdad.Location = new Point(46, 162);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new Size(41, 17);
            lblEdad.TabIndex = 10;
            lblEdad.Text = "Edad:";
            // 
            // cboEquipaje
            // 
            cboEquipaje.FormattingEnabled = true;
            cboEquipaje.Location = new Point(122, 195);
            cboEquipaje.Name = "cboEquipaje";
            cboEquipaje.Size = new Size(100, 23);
            cboEquipaje.TabIndex = 12;
            cboEquipaje.Text = "--Seleccione--";
            // 
            // lblEquipaje
            // 
            lblEquipaje.AutoSize = true;
            lblEquipaje.Font = new Font("Segoe UI Symbol", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            lblEquipaje.Location = new Point(27, 203);
            lblEquipaje.Name = "lblEquipaje";
            lblEquipaje.Size = new Size(61, 17);
            lblEquipaje.TabIndex = 13;
            lblEquipaje.Text = "Equipaje:";
            // 
            // lblPeso
            // 
            lblPeso.AutoSize = true;
            lblPeso.Font = new Font("Segoe UI Symbol", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            lblPeso.Location = new Point(-1, 244);
            lblPeso.Name = "lblPeso";
            lblPeso.Size = new Size(93, 17);
            lblPeso.TabIndex = 14;
            lblPeso.Text = "Peso equipaje:";
            // 
            // txtPesoEquipaje
            // 
            txtPesoEquipaje.Location = new Point(122, 241);
            txtPesoEquipaje.Name = "txtPesoEquipaje";
            txtPesoEquipaje.Size = new Size(100, 23);
            txtPesoEquipaje.TabIndex = 15;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(122, 356);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 16;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // cboClase
            // 
            cboClase.FormattingEnabled = true;
            cboClase.Location = new Point(122, 290);
            cboClase.Name = "cboClase";
            cboClase.Size = new Size(100, 23);
            cboClase.TabIndex = 19;
            cboClase.Text = "--Seleccione--";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Symbol", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(44, 298);
            label1.Name = "label1";
            label1.Size = new Size(42, 17);
            label1.TabIndex = 20;
            label1.Text = "Clase:";
            // 
            // FrmPasajero
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(326, 406);
            Controls.Add(label1);
            Controls.Add(cboClase);
            Controls.Add(btnLimpiar);
            Controls.Add(txtPesoEquipaje);
            Controls.Add(lblPeso);
            Controls.Add(lblEquipaje);
            Controls.Add(cboEquipaje);
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
        private ComboBox cboEquipaje;
        private Label lblEquipaje;
        private Label lblPeso;
        private TextBox txtPesoEquipaje;
        private Button btnLimpiar;
        private ComboBox cboClase;
        private Label label1;
    }
}