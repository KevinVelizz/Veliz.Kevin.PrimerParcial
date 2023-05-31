namespace Aplicacion01
{
    partial class FrmBase
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
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            btnLimpiar = new Guna.UI2.WinForms.Guna2Button();
            btnSalir = new Guna.UI2.WinForms.Guna2Button();
            guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(components);
            SuspendLayout();
            // 
            // btnLimpiar
            // 
            btnLimpiar.Anchor = AnchorStyles.None;
            btnLimpiar.Animated = true;
            btnLimpiar.CustomizableEdges = customizableEdges1;
            btnLimpiar.DisabledState.BorderColor = Color.DarkGray;
            btnLimpiar.DisabledState.CustomBorderColor = Color.DarkGray;
            btnLimpiar.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnLimpiar.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnLimpiar.FillColor = Color.FromArgb(255, 224, 192);
            btnLimpiar.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnLimpiar.ForeColor = Color.Black;
            btnLimpiar.Location = new Point(172, 268);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.PressedColor = Color.IndianRed;
            btnLimpiar.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnLimpiar.Size = new Size(78, 23);
            btnLimpiar.TabIndex = 4;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.Click += btnLimpiar_Click_1;
            // 
            // btnSalir
            // 
            btnSalir.Anchor = AnchorStyles.None;
            btnSalir.Animated = true;
            btnSalir.CustomizableEdges = customizableEdges3;
            btnSalir.DisabledState.BorderColor = Color.DarkGray;
            btnSalir.DisabledState.CustomBorderColor = Color.DarkGray;
            btnSalir.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnSalir.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnSalir.FillColor = Color.FromArgb(255, 224, 192);
            btnSalir.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnSalir.ForeColor = Color.Black;
            btnSalir.Location = new Point(273, 268);
            btnSalir.Name = "btnSalir";
            btnSalir.PressedColor = Color.IndianRed;
            btnSalir.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnSalir.Size = new Size(78, 23);
            btnSalir.TabIndex = 5;
            btnSalir.Text = "Salir";
            btnSalir.Click += btnSalir_Click;
            // 
            // guna2AnimateWindow1
            // 
            guna2AnimateWindow1.AnimationType = Guna.UI2.WinForms.Guna2AnimateWindow.AnimateWindowType.AW_VER_POSITIVE;
            // 
            // FrmBase
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(382, 314);
            Controls.Add(btnSalir);
            Controls.Add(btnLimpiar);
            Name = "FrmBase";
            Text = "FrmBase";
            FormClosing += FrmBase_FormClosing_1;
            Load += FrmBase_Load;
            ResumeLayout(false);
        }

        #endregion
        protected Guna.UI2.WinForms.Guna2Button btnLimpiar;
        protected Guna.UI2.WinForms.Guna2Button btnSalir;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
    }
}