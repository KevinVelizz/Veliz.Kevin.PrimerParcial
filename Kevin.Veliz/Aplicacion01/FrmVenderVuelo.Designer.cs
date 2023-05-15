namespace Aplicacion01
{
    partial class FrmVenderVuelo
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
            cboPasajeros = new ComboBox();
            cboViajes = new ComboBox();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            lblInfoAvion = new Label();
            SuspendLayout();
            // 
            // cboPasajeros
            // 
            cboPasajeros.Font = new Font("Segoe UI Symbol", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            cboPasajeros.FormattingEnabled = true;
            cboPasajeros.Location = new Point(163, 12);
            cboPasajeros.Name = "cboPasajeros";
            cboPasajeros.Size = new Size(174, 25);
            cboPasajeros.TabIndex = 0;
            cboPasajeros.Text = "--Seleccione--";
            // 
            // cboViajes
            // 
            cboViajes.Font = new Font("Segoe UI Symbol", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            cboViajes.FormattingEnabled = true;
            cboViajes.Location = new Point(343, 12);
            cboViajes.Name = "cboViajes";
            cboViajes.Size = new Size(177, 25);
            cboViajes.TabIndex = 1;
            cboViajes.Text = "--Seleccione--";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Segoe UI Symbol", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            checkBox1.Location = new Point(41, 16);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(72, 21);
            checkBox1.TabIndex = 3;
            checkBox1.Text = "Comida";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Font = new Font("Segoe UI Symbol", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            checkBox2.Location = new Point(41, 43);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(71, 21);
            checkBox2.TabIndex = 4;
            checkBox2.Text = "Internet";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // lblInfoAvion
            // 
            lblInfoAvion.AutoSize = true;
            lblInfoAvion.Font = new Font("Segoe UI Symbol", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            lblInfoAvion.Location = new Point(526, 17);
            lblInfoAvion.Name = "lblInfoAvion";
            lblInfoAvion.Size = new Size(43, 17);
            lblInfoAvion.TabIndex = 5;
            lblInfoAvion.Text = "label1";
            // 
            // FrmVenderVuelo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(607, 293);
            Controls.Add(lblInfoAvion);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(cboViajes);
            Controls.Add(cboPasajeros);
            Name = "FrmVenderVuelo";
            Text = "FrmVenderVuelo";
            Load += FrmVenderVuelo_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cboPasajeros;
        private ComboBox cboViajes;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private Label lblInfoAvion;
    }
}