namespace Aplicacion01
{
    partial class IngresarUsuario
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
            btnIngresar = new Button();
            txtNombre = new TextBox();
            txtClave = new TextBox();
            lblNombre = new Label();
            lblClave = new Label();
            chkAdministrador = new CheckBox();
            chkSupervisor = new CheckBox();
            chkVendedor = new CheckBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnIngresar
            // 
            btnIngresar.Location = new Point(271, 274);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(75, 23);
            btnIngresar.TabIndex = 0;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(246, 165);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 1;
            // 
            // txtClave
            // 
            txtClave.Location = new Point(246, 206);
            txtClave.Name = "txtClave";
            txtClave.Size = new Size(100, 23);
            txtClave.TabIndex = 2;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(169, 168);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 3;
            lblNombre.Text = "Nombre";
            // 
            // lblClave
            // 
            lblClave.AutoSize = true;
            lblClave.Location = new Point(169, 209);
            lblClave.Name = "lblClave";
            lblClave.Size = new Size(36, 15);
            lblClave.TabIndex = 4;
            lblClave.Text = "Clave";
            // 
            // chkAdministrador
            // 
            chkAdministrador.AutoSize = true;
            chkAdministrador.Location = new Point(87, 105);
            chkAdministrador.Name = "chkAdministrador";
            chkAdministrador.Size = new Size(102, 19);
            chkAdministrador.TabIndex = 5;
            chkAdministrador.Text = "Administrador";
            chkAdministrador.UseVisualStyleBackColor = true;
            // 
            // chkSupervisor
            // 
            chkSupervisor.AutoSize = true;
            chkSupervisor.Location = new Point(265, 105);
            chkSupervisor.Name = "chkSupervisor";
            chkSupervisor.Size = new Size(81, 19);
            chkSupervisor.TabIndex = 6;
            chkSupervisor.Text = "Supervisor";
            chkSupervisor.UseVisualStyleBackColor = true;
            // 
            // chkVendedor
            // 
            chkVendedor.AutoSize = true;
            chkVendedor.Location = new Point(457, 105);
            chkVendedor.Name = "chkVendedor";
            chkVendedor.Size = new Size(76, 19);
            chkVendedor.TabIndex = 7;
            chkVendedor.Text = "Vendedor";
            chkVendedor.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.abierto;
            pictureBox1.Location = new Point(228, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(118, 70);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // IngresarUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(582, 376);
            Controls.Add(pictureBox1);
            Controls.Add(chkVendedor);
            Controls.Add(chkSupervisor);
            Controls.Add(chkAdministrador);
            Controls.Add(lblClave);
            Controls.Add(lblNombre);
            Controls.Add(txtClave);
            Controls.Add(txtNombre);
            Controls.Add(btnIngresar);
            Name = "IngresarUsuario";
            Text = "Ingresar";
            Load += IngresarUsuario_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnIngresar;
        private TextBox txtNombre;
        private TextBox txtClave;
        private Label lblNombre;
        private Label lblClave;
        private CheckBox chkAdministrador;
        private CheckBox chkSupervisor;
        private CheckBox chkVendedor;
        private PictureBox pictureBox1;
    }
}