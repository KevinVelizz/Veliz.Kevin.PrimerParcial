namespace Aplicacion01
{
    partial class FrmPasajerosDelVuelo
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
            dtgvPasajerosDelVuelo = new DataGridView();
            lblNombre = new Label();
            ((System.ComponentModel.ISupportInitialize)dtgvPasajerosDelVuelo).BeginInit();
            SuspendLayout();
            // 
            // btnLimpiar
            // 
            btnLimpiar.DialogResult = DialogResult.None;
            btnLimpiar.DisabledState.BorderColor = Color.DarkGray;
            btnLimpiar.DisabledState.CustomBorderColor = Color.DarkGray;
            btnLimpiar.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnLimpiar.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnLimpiar.Location = new Point(363, 312);
            btnLimpiar.ShadowDecoration.CustomizableEdges = customizableEdges1;
            // 
            // btnSalir
            // 
            btnSalir.DialogResult = DialogResult.None;
            btnSalir.DisabledState.BorderColor = Color.DarkGray;
            btnSalir.DisabledState.CustomBorderColor = Color.DarkGray;
            btnSalir.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnSalir.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnSalir.Location = new Point(447, 312);
            btnSalir.ShadowDecoration.CustomizableEdges = customizableEdges2;
            // 
            // dtgvPasajerosDelVuelo
            // 
            dtgvPasajerosDelVuelo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvPasajerosDelVuelo.Location = new Point(12, 38);
            dtgvPasajerosDelVuelo.MultiSelect = false;
            dtgvPasajerosDelVuelo.Name = "dtgvPasajerosDelVuelo";
            dtgvPasajerosDelVuelo.ReadOnly = true;
            dtgvPasajerosDelVuelo.RowTemplate.Height = 25;
            dtgvPasajerosDelVuelo.Size = new Size(513, 239);
            dtgvPasajerosDelVuelo.TabIndex = 0;
            // 
            // lblNombre
            // 
            lblNombre.Anchor = AnchorStyles.None;
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(227, 18);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(64, 17);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Pasajeros";
            // 
            // FrmPasajerosDelVuelo
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(537, 347);
            Controls.Add(lblNombre);
            Controls.Add(dtgvPasajerosDelVuelo);
            Font = new Font("Segoe UI Symbol", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            Name = "FrmPasajerosDelVuelo";
            Text = "FrmModificaPasajero";
            Load += FrmPasajerosDelVuelo_Load;
            Controls.SetChildIndex(btnLimpiar, 0);
            Controls.SetChildIndex(btnSalir, 0);
            Controls.SetChildIndex(dtgvPasajerosDelVuelo, 0);
            Controls.SetChildIndex(lblNombre, 0);
            ((System.ComponentModel.ISupportInitialize)dtgvPasajerosDelVuelo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtgvPasajerosDelVuelo;
        private Label lblNombre;
    }
}