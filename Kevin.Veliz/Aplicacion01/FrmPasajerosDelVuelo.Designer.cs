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
            dtgvPasajerosDelVuelo = new DataGridView();
            lblNombre = new Label();
            ((System.ComponentModel.ISupportInitialize)dtgvPasajerosDelVuelo).BeginInit();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(450, 311);
            btnCancelar.Text = "Salir";
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(369, 312);
            btnLimpiar.Visible = false;
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
            Controls.SetChildIndex(dtgvPasajerosDelVuelo, 0);
            Controls.SetChildIndex(lblNombre, 0);
            Controls.SetChildIndex(btnCancelar, 0);
            Controls.SetChildIndex(btnLimpiar, 0);
            ((System.ComponentModel.ISupportInitialize)dtgvPasajerosDelVuelo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtgvPasajerosDelVuelo;
        private Label lblNombre;
    }
}