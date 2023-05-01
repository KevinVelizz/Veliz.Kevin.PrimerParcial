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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IngresarUsuario));
            btnIngresar = new Button();
            txtCorreo = new TextBox();
            txtContraseña = new TextBox();
            lblCorreo = new Label();
            lblContraseña = new Label();
            pictureBox1 = new PictureBox();
            btnLimpiar = new Button();
            lblOlvidoContra = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnIngresar
            // 
            btnIngresar.Anchor = AnchorStyles.None;
            btnIngresar.Location = new Point(188, 205);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(100, 25);
            btnIngresar.TabIndex = 0;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            btnIngresar.MouseHover += btnIngresar_MouseHover;
            // 
            // txtCorreo
            // 
            txtCorreo.Anchor = AnchorStyles.None;
            txtCorreo.Location = new Point(188, 127);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(100, 23);
            txtCorreo.TabIndex = 1;
            // 
            // txtContraseña
            // 
            txtContraseña.Anchor = AnchorStyles.None;
            txtContraseña.Location = new Point(188, 164);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.PasswordChar = '*';
            txtContraseña.Size = new Size(100, 23);
            txtContraseña.TabIndex = 2;
            // 
            // lblCorreo
            // 
            lblCorreo.Anchor = AnchorStyles.None;
            lblCorreo.AutoSize = true;
            lblCorreo.Location = new Point(120, 130);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(46, 15);
            lblCorreo.TabIndex = 3;
            lblCorreo.Text = "Correo:";
            // 
            // lblContraseña
            // 
            lblContraseña.Anchor = AnchorStyles.None;
            lblContraseña.AutoSize = true;
            lblContraseña.Location = new Point(96, 167);
            lblContraseña.Name = "lblContraseña";
            lblContraseña.Size = new Size(70, 15);
            lblContraseña.TabIndex = 4;
            lblContraseña.Text = "Contraseña:";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.BackColor = SystemColors.Control;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(198, 10);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(81, 71);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Anchor = AnchorStyles.None;
            btnLimpiar.Location = new Point(188, 236);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(100, 25);
            btnLimpiar.TabIndex = 12;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // lblOlvidoContra
            // 
            lblOlvidoContra.Anchor = AnchorStyles.None;
            lblOlvidoContra.AutoSize = true;
            lblOlvidoContra.Location = new Point(168, 282);
            lblOlvidoContra.Name = "lblOlvidoContra";
            lblOlvidoContra.Size = new Size(139, 15);
            lblOlvidoContra.TabIndex = 13;
            lblOlvidoContra.Text = "¿olvidaste tu contraseña?";
            // 
            // IngresarUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(465, 318);
            Controls.Add(lblOlvidoContra);
            Controls.Add(btnLimpiar);
            Controls.Add(pictureBox1);
            Controls.Add(lblContraseña);
            Controls.Add(lblCorreo);
            Controls.Add(txtContraseña);
            Controls.Add(txtCorreo);
            Controls.Add(btnIngresar);
            Name = "IngresarUsuario";
            Text = " ";
            Load += IngresarUsuario_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnIngresar;
        private TextBox txtCorreo;
        private TextBox txtContraseña;
        private Label lblCorreo;
        private Label lblContraseña;
        private PictureBox pictureBox1;
        private Button btnLimpiar;
        private Label lblOlvidoContra;
    }
}