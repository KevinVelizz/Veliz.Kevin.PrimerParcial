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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            txtCorreo = new TextBox();
            txtContraseña = new TextBox();
            lblCorreo = new Label();
            lblContraseña = new Label();
            pictureBox1 = new PictureBox();
            lblOlvidoContra = new Label();
            btnIngresar1 = new Guna.UI2.WinForms.Guna2Button();
            btnLimpiar1 = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
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
            lblCorreo.Font = new Font("Segoe UI Symbol", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            lblCorreo.Location = new Point(120, 130);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(52, 17);
            lblCorreo.TabIndex = 3;
            lblCorreo.Text = "Correo:";
            // 
            // lblContraseña
            // 
            lblContraseña.Anchor = AnchorStyles.None;
            lblContraseña.AutoSize = true;
            lblContraseña.Font = new Font("Segoe UI Symbol", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            lblContraseña.Location = new Point(96, 167);
            lblContraseña.Name = "lblContraseña";
            lblContraseña.Size = new Size(77, 17);
            lblContraseña.TabIndex = 4;
            lblContraseña.Text = "Contraseña:";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.BackColor = SystemColors.GradientInactiveCaption;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(198, 10);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(81, 71);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
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
            // btnIngresar1
            // 
            btnIngresar1.Anchor = AnchorStyles.None;
            btnIngresar1.Animated = true;
            btnIngresar1.CustomizableEdges = customizableEdges1;
            btnIngresar1.DisabledState.BorderColor = Color.DarkGray;
            btnIngresar1.DisabledState.CustomBorderColor = Color.DarkGray;
            btnIngresar1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnIngresar1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnIngresar1.FillColor = Color.FromArgb(255, 224, 192);
            btnIngresar1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnIngresar1.ForeColor = Color.Black;
            btnIngresar1.Location = new Point(188, 207);
            btnIngresar1.Name = "btnIngresar1";
            btnIngresar1.PressedColor = Color.IndianRed;
            btnIngresar1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnIngresar1.Size = new Size(100, 23);
            btnIngresar1.TabIndex = 14;
            btnIngresar1.Text = "Ingresar";
            btnIngresar1.Click += btnIngresar1_Click;
            // 
            // btnLimpiar1
            // 
            btnLimpiar1.Anchor = AnchorStyles.None;
            btnLimpiar1.Animated = true;
            btnLimpiar1.CustomizableEdges = customizableEdges3;
            btnLimpiar1.DisabledState.BorderColor = Color.DarkGray;
            btnLimpiar1.DisabledState.CustomBorderColor = Color.DarkGray;
            btnLimpiar1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnLimpiar1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnLimpiar1.FillColor = Color.FromArgb(255, 224, 192);
            btnLimpiar1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnLimpiar1.ForeColor = Color.Black;
            btnLimpiar1.Location = new Point(188, 236);
            btnLimpiar1.Name = "btnLimpiar1";
            btnLimpiar1.PressedColor = Color.IndianRed;
            btnLimpiar1.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnLimpiar1.Size = new Size(100, 26);
            btnLimpiar1.TabIndex = 15;
            btnLimpiar1.Text = "Limpiar";
            btnLimpiar1.Click += btnLimpiar1_Click;
            // 
            // IngresarUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(465, 318);
            Controls.Add(btnLimpiar1);
            Controls.Add(btnIngresar1);
            Controls.Add(lblOlvidoContra);
            Controls.Add(pictureBox1);
            Controls.Add(lblContraseña);
            Controls.Add(lblCorreo);
            Controls.Add(txtContraseña);
            Controls.Add(txtCorreo);
            MinimumSize = new Size(300, 350);
            Name = "IngresarUsuario";
            Text = " ";
            Load += IngresarUsuario_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtCorreo;
        private TextBox txtContraseña;
        private Label lblCorreo;
        private Label lblContraseña;
        private PictureBox pictureBox1;
        private Label lblOlvidoContra;
        protected Guna.UI2.WinForms.Guna2Button btnIngresar1;
        protected Guna.UI2.WinForms.Guna2Button btnLimpiar1;
    }
}