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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            txtMatricula = new TextBox();
            txtCantAsientos = new TextBox();
            txtCantBanios = new TextBox();
            lblMatricula = new Label();
            lblCantAsientos = new Label();
            lblCantBanios = new Label();
            chkInternet = new CheckBox();
            chkComida = new CheckBox();
            txtCapacidadBodega = new TextBox();
            lblCapacidadBodega = new Label();
            btnAgregar1 = new Guna.UI2.WinForms.Guna2Button();
            btnModificar1 = new Guna.UI2.WinForms.Guna2Button();
            SuspendLayout();
            // 
            // btnLimpiar
            // 
            btnLimpiar.DialogResult = DialogResult.None;
            btnLimpiar.DisabledState.BorderColor = Color.DarkGray;
            btnLimpiar.DisabledState.CustomBorderColor = Color.DarkGray;
            btnLimpiar.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnLimpiar.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnLimpiar.Location = new Point(143, 302);
            btnLimpiar.ShadowDecoration.CustomizableEdges = customizableEdges1;
            // 
            // btnSalir
            // 
            btnSalir.DialogResult = DialogResult.None;
            btnSalir.DisabledState.BorderColor = Color.DarkGray;
            btnSalir.DisabledState.CustomBorderColor = Color.DarkGray;
            btnSalir.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnSalir.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnSalir.Location = new Point(242, 302);
            btnSalir.ShadowDecoration.CustomizableEdges = customizableEdges2;
            // 
            // txtMatricula
            // 
            txtMatricula.Anchor = AnchorStyles.None;
            txtMatricula.Location = new Point(144, 28);
            txtMatricula.Name = "txtMatricula";
            txtMatricula.Size = new Size(100, 23);
            txtMatricula.TabIndex = 0;
            // 
            // txtCantAsientos
            // 
            txtCantAsientos.Anchor = AnchorStyles.None;
            txtCantAsientos.Location = new Point(144, 75);
            txtCantAsientos.Name = "txtCantAsientos";
            txtCantAsientos.Size = new Size(100, 23);
            txtCantAsientos.TabIndex = 1;
            // 
            // txtCantBanios
            // 
            txtCantBanios.Anchor = AnchorStyles.None;
            txtCantBanios.Location = new Point(144, 128);
            txtCantBanios.Name = "txtCantBanios";
            txtCantBanios.Size = new Size(100, 23);
            txtCantBanios.TabIndex = 2;
            // 
            // lblMatricula
            // 
            lblMatricula.Anchor = AnchorStyles.None;
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
            lblCantAsientos.Anchor = AnchorStyles.None;
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
            lblCantBanios.Anchor = AnchorStyles.None;
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
            chkInternet.Anchor = AnchorStyles.None;
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
            chkComida.Anchor = AnchorStyles.None;
            chkComida.AutoSize = true;
            chkComida.Location = new Point(143, 240);
            chkComida.Name = "chkComida";
            chkComida.Size = new Size(68, 19);
            chkComida.TabIndex = 14;
            chkComida.Text = "Comida";
            chkComida.UseVisualStyleBackColor = true;
            // 
            // txtCapacidadBodega
            // 
            txtCapacidadBodega.Anchor = AnchorStyles.None;
            txtCapacidadBodega.Location = new Point(144, 177);
            txtCapacidadBodega.Name = "txtCapacidadBodega";
            txtCapacidadBodega.Size = new Size(100, 23);
            txtCapacidadBodega.TabIndex = 17;
            // 
            // lblCapacidadBodega
            // 
            lblCapacidadBodega.Anchor = AnchorStyles.None;
            lblCapacidadBodega.AutoSize = true;
            lblCapacidadBodega.Location = new Point(-1, 185);
            lblCapacidadBodega.Name = "lblCapacidadBodega";
            lblCapacidadBodega.Size = new Size(125, 15);
            lblCapacidadBodega.TabIndex = 18;
            lblCapacidadBodega.Text = "Capacidad de bodega:";
            // 
            // btnAgregar1
            // 
            btnAgregar1.Anchor = AnchorStyles.None;
            btnAgregar1.Animated = true;
            btnAgregar1.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            btnAgregar1.CustomizableEdges = customizableEdges3;
            btnAgregar1.DisabledState.BorderColor = Color.DarkGray;
            btnAgregar1.DisabledState.CustomBorderColor = Color.DarkGray;
            btnAgregar1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnAgregar1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnAgregar1.FillColor = Color.FromArgb(255, 224, 192);
            btnAgregar1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnAgregar1.ForeColor = Color.Black;
            btnAgregar1.Location = new Point(49, 302);
            btnAgregar1.Name = "btnAgregar1";
            btnAgregar1.PressedColor = Color.IndianRed;
            btnAgregar1.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnAgregar1.Size = new Size(78, 23);
            btnAgregar1.TabIndex = 20;
            btnAgregar1.Text = "Agregar";
            btnAgregar1.Click += btnAgregar1_Click;
            // 
            // btnModificar1
            // 
            btnModificar1.Anchor = AnchorStyles.None;
            btnModificar1.Animated = true;
            btnModificar1.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            btnModificar1.CustomizableEdges = customizableEdges5;
            btnModificar1.DisabledState.BorderColor = Color.DarkGray;
            btnModificar1.DisabledState.CustomBorderColor = Color.DarkGray;
            btnModificar1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnModificar1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnModificar1.FillColor = Color.FromArgb(255, 224, 192);
            btnModificar1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnModificar1.ForeColor = Color.Black;
            btnModificar1.Location = new Point(49, 263);
            btnModificar1.Name = "btnModificar1";
            btnModificar1.PressedColor = Color.IndianRed;
            btnModificar1.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnModificar1.Size = new Size(78, 23);
            btnModificar1.TabIndex = 21;
            btnModificar1.Text = "Modificar";
            btnModificar1.Click += btnModificar1_Click;
            // 
            // FrmAeronave
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(348, 389);
            Controls.Add(btnModificar1);
            Controls.Add(btnAgregar1);
            Controls.Add(lblCapacidadBodega);
            Controls.Add(txtCapacidadBodega);
            Controls.Add(chkComida);
            Controls.Add(chkInternet);
            Controls.Add(lblCantBanios);
            Controls.Add(lblCantAsientos);
            Controls.Add(lblMatricula);
            Controls.Add(txtCantBanios);
            Controls.Add(txtCantAsientos);
            Controls.Add(txtMatricula);
            MinimumSize = new Size(364, 428);
            Name = "FrmAeronave";
            Text = "FrmAeronave";
            Load += FrmAeronave_Load;
            Controls.SetChildIndex(btnLimpiar, 0);
            Controls.SetChildIndex(btnSalir, 0);
            Controls.SetChildIndex(txtMatricula, 0);
            Controls.SetChildIndex(txtCantAsientos, 0);
            Controls.SetChildIndex(txtCantBanios, 0);
            Controls.SetChildIndex(lblMatricula, 0);
            Controls.SetChildIndex(lblCantAsientos, 0);
            Controls.SetChildIndex(lblCantBanios, 0);
            Controls.SetChildIndex(chkInternet, 0);
            Controls.SetChildIndex(chkComida, 0);
            Controls.SetChildIndex(txtCapacidadBodega, 0);
            Controls.SetChildIndex(lblCapacidadBodega, 0);
            Controls.SetChildIndex(btnAgregar1, 0);
            Controls.SetChildIndex(btnModificar1, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtMatricula;
        private TextBox txtCantAsientos;
        private TextBox txtCantBanios;
        private Label lblMatricula;
        private Label lblCantAsientos;
        private Label lblCantBanios;
        private CheckBox chkInternet;
        private CheckBox chkComida;
        private Label lblInternet;
        private Label lblComida;
        private TextBox txtCapacidadBodega;
        private Label lblCapacidadBodega;
        protected Guna.UI2.WinForms.Guna2Button btnAgregar1;
        protected Guna.UI2.WinForms.Guna2Button btnModificar1;
    }
}