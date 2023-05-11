namespace Aplicacion01
{
    partial class FrmAeronave
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
            txtMatricula = new TextBox();
            txtCantAsientos = new TextBox();
            txtCantBanios = new TextBox();
            btnCancelar = new Button();
            lblMatricula = new Label();
            lblCantAsientos = new Label();
            lblCantBanios = new Label();
            chkInternet = new CheckBox();
            chkComida = new CheckBox();
            btnAgregar = new Button();
            btnLimpiar = new Button();
            txtCapacidadBodega = new TextBox();
            lblCapacidadBodega = new Label();
            SuspendLayout();
            // 
            // txtMatricula
            // 
            txtMatricula.Location = new Point(144, 28);
            txtMatricula.Name = "txtMatricula";
            txtMatricula.Size = new Size(100, 23);
            txtMatricula.TabIndex = 0;
            // 
            // txtCantAsientos
            // 
            txtCantAsientos.Location = new Point(144, 75);
            txtCantAsientos.Name = "txtCantAsientos";
            txtCantAsientos.Size = new Size(100, 23);
            txtCantAsientos.TabIndex = 1;
            // 
            // txtCantBanios
            // 
            txtCantBanios.Location = new Point(144, 128);
            txtCantBanios.Name = "txtCantBanios";
            txtCantBanios.Size = new Size(100, 23);
            txtCantBanios.TabIndex = 2;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(230, 302);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // lblMatricula
            // 
            lblMatricula.AutoSize = true;
            lblMatricula.Font = new Font("Segoe UI Symbol", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            lblMatricula.Location = new Point(59, 34);
            lblMatricula.Name = "lblMatricula";
            lblMatricula.Size = new Size(65, 17);
            lblMatricula.TabIndex = 8;
            lblMatricula.Text = "Matricula:";
            // 
            // lblCantAsientos
            // 
            lblCantAsientos.AutoSize = true;
            lblCantAsientos.Font = new Font("Segoe UI Symbol", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            lblCantAsientos.Location = new Point(12, 83);
            lblCantAsientos.Name = "lblCantAsientos";
            lblCantAsientos.Size = new Size(115, 17);
            lblCantAsientos.TabIndex = 9;
            lblCantAsientos.Text = "Cantidad asientos:";
            // 
            // lblCantBanios
            // 
            lblCantBanios.AutoSize = true;
            lblCantBanios.Font = new Font("Segoe UI Symbol", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            lblCantBanios.Location = new Point(21, 136);
            lblCantBanios.Name = "lblCantBanios";
            lblCantBanios.Size = new Size(103, 17);
            lblCantBanios.TabIndex = 10;
            lblCantBanios.Text = "Cantidad baños:";
            // 
            // chkInternet
            // 
            chkInternet.AutoSize = true;
            chkInternet.Location = new Point(144, 206);
            chkInternet.Name = "chkInternet";
            chkInternet.Size = new Size(67, 19);
            chkInternet.TabIndex = 13;
            chkInternet.Text = "Internet";
            chkInternet.UseVisualStyleBackColor = true;
            // 
            // chkComida
            // 
            chkComida.AutoSize = true;
            chkComida.Location = new Point(143, 240);
            chkComida.Name = "chkComida";
            chkComida.Size = new Size(68, 19);
            chkComida.TabIndex = 14;
            chkComida.Text = "Comida";
            chkComida.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(54, 302);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 15;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(144, 302);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 16;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // txtCapacidadBodega
            // 
            txtCapacidadBodega.Location = new Point(144, 177);
            txtCapacidadBodega.Name = "txtCapacidadBodega";
            txtCapacidadBodega.Size = new Size(100, 23);
            txtCapacidadBodega.TabIndex = 17;
            // 
            // lblCapacidadBodega
            // 
            lblCapacidadBodega.AutoSize = true;
            lblCapacidadBodega.Location = new Point(-1, 185);
            lblCapacidadBodega.Name = "lblCapacidadBodega";
            lblCapacidadBodega.Size = new Size(125, 15);
            lblCapacidadBodega.TabIndex = 18;
            lblCapacidadBodega.Text = "Capacidad de bodega:";
            // 
            // FrmAeronave
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(332, 350);
            ControlBox = false;
            Controls.Add(lblCapacidadBodega);
            Controls.Add(txtCapacidadBodega);
            Controls.Add(btnLimpiar);
            Controls.Add(btnAgregar);
            Controls.Add(chkComida);
            Controls.Add(chkInternet);
            Controls.Add(lblCantBanios);
            Controls.Add(lblCantAsientos);
            Controls.Add(lblMatricula);
            Controls.Add(btnCancelar);
            Controls.Add(txtCantBanios);
            Controls.Add(txtCantAsientos);
            Controls.Add(txtMatricula);
            Name = "FrmAeronave";
            Text = "FrmAeronave";
            Load += FrmAeronave_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtMatricula;
        private TextBox txtCantAsientos;
        private TextBox txtCantBanios;
        private Button btnCancelar;
        private Label lblMatricula;
        private Label lblCantAsientos;
        private Label lblCantBanios;
        private CheckBox chkInternet;
        private CheckBox chkComida;
        private Label lblInternet;
        private Label lblComida;
        private Button btnAgregar;
        private Button btnLimpiar;
        private TextBox txtCapacidadBodega;
        private Label lblCapacidadBodega;
    }
}