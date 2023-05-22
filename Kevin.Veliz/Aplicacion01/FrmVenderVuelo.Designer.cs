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
            chkComida = new CheckBox();
            chkInternet = new CheckBox();
            lblInfoAvion = new Label();
            btnVender = new Button();
            label1 = new Label();
            label2 = new Label();
            lblCosto = new Label();
            txtCosto = new TextBox();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(580, 236);
            // 
            // btnLimpiar
            // 
            btnLimpiar.Font = new Font("Segoe UI Symbol", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            btnLimpiar.Location = new Point(472, 236);
            // 
            // cboPasajeros
            // 
            cboPasajeros.Font = new Font("Segoe UI Symbol", 8.25F, FontStyle.Italic, GraphicsUnit.Point);
            cboPasajeros.FormattingEnabled = true;
            cboPasajeros.Location = new Point(252, 12);
            cboPasajeros.Name = "cboPasajeros";
            cboPasajeros.Size = new Size(325, 21);
            cboPasajeros.TabIndex = 0;
            cboPasajeros.Text = "--Seleccione--";
            cboPasajeros.SelectedIndexChanged += cboPasajeros_SelectedIndexChanged;
            cboPasajeros.Click += cboPasajeros_Click;
            // 
            // cboViajes
            // 
            cboViajes.Font = new Font("Segoe UI Symbol", 8.25F, FontStyle.Italic, GraphicsUnit.Point);
            cboViajes.FormattingEnabled = true;
            cboViajes.Location = new Point(252, 66);
            cboViajes.Name = "cboViajes";
            cboViajes.Size = new Size(403, 21);
            cboViajes.TabIndex = 1;
            cboViajes.Text = "--Seleccione--";
            cboViajes.SelectedIndexChanged += cboViajes_SelectedIndexChanged;
            cboViajes.Click += cboViajes_Click;
            // 
            // chkComida
            // 
            chkComida.AutoSize = true;
            chkComida.Font = new Font("Segoe UI Symbol", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            chkComida.Location = new Point(41, 16);
            chkComida.Name = "chkComida";
            chkComida.Size = new Size(72, 21);
            chkComida.TabIndex = 3;
            chkComida.Text = "Comida";
            chkComida.UseVisualStyleBackColor = true;
            chkComida.CheckedChanged += chkComida_CheckedChanged;
            // 
            // chkInternet
            // 
            chkInternet.AutoSize = true;
            chkInternet.Font = new Font("Segoe UI Symbol", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            chkInternet.Location = new Point(41, 69);
            chkInternet.Name = "chkInternet";
            chkInternet.Size = new Size(71, 21);
            chkInternet.TabIndex = 4;
            chkInternet.Text = "Internet";
            chkInternet.UseVisualStyleBackColor = true;
            chkInternet.CheckedChanged += chkInternet_CheckedChanged;
            // 
            // lblInfoAvion
            // 
            lblInfoAvion.AutoSize = true;
            lblInfoAvion.Font = new Font("Segoe UI Symbol", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            lblInfoAvion.Location = new Point(252, 90);
            lblInfoAvion.Name = "lblInfoAvion";
            lblInfoAvion.Size = new Size(43, 17);
            lblInfoAvion.TabIndex = 5;
            lblInfoAvion.Text = "label1";
            lblInfoAvion.Visible = false;
            // 
            // btnVender
            // 
            btnVender.Font = new Font("Segoe UI Symbol", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            btnVender.Location = new Point(356, 236);
            btnVender.Name = "btnVender";
            btnVender.Size = new Size(75, 23);
            btnVender.TabIndex = 6;
            btnVender.Text = "Vender";
            btnVender.UseVisualStyleBackColor = true;
            btnVender.Click += btnVender_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Symbol", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(179, 16);
            label1.Name = "label1";
            label1.Size = new Size(67, 17);
            label1.TabIndex = 7;
            label1.Text = "Pasajeros:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Symbol", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(125, 70);
            label2.Name = "label2";
            label2.Size = new Size(121, 17);
            label2.TabIndex = 8;
            label2.Text = "Vuelos disponibles:";
            // 
            // lblCosto
            // 
            lblCosto.AutoSize = true;
            lblCosto.Font = new Font("Segoe UI Symbol", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            lblCosto.Location = new Point(488, 99);
            lblCosto.Name = "lblCosto";
            lblCosto.Size = new Size(49, 17);
            lblCosto.TabIndex = 9;
            lblCosto.Text = "Costo: ";
            // 
            // txtCosto
            // 
            txtCosto.Enabled = false;
            txtCosto.Font = new Font("Segoe UI Symbol", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            txtCosto.Location = new Point(543, 93);
            txtCosto.Name = "txtCosto";
            txtCosto.Size = new Size(112, 25);
            txtCosto.TabIndex = 10;
            // 
            // FrmVenderVuelo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(668, 285);
            Controls.Add(txtCosto);
            Controls.Add(lblCosto);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnVender);
            Controls.Add(lblInfoAvion);
            Controls.Add(chkInternet);
            Controls.Add(chkComida);
            Controls.Add(cboViajes);
            Controls.Add(cboPasajeros);
            Name = "FrmVenderVuelo";
            Text = "FrmVenderVuelo";
            Load += FrmVenderVuelo_Load;
            Controls.SetChildIndex(btnLimpiar, 0);
            Controls.SetChildIndex(cboPasajeros, 0);
            Controls.SetChildIndex(cboViajes, 0);
            Controls.SetChildIndex(chkComida, 0);
            Controls.SetChildIndex(chkInternet, 0);
            Controls.SetChildIndex(lblInfoAvion, 0);
            Controls.SetChildIndex(btnVender, 0);
            Controls.SetChildIndex(btnCancelar, 0);
            Controls.SetChildIndex(label1, 0);
            Controls.SetChildIndex(label2, 0);
            Controls.SetChildIndex(lblCosto, 0);
            Controls.SetChildIndex(txtCosto, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cboPasajeros;
        private ComboBox cboViajes;
        private CheckBox chkComida;
        private CheckBox chkInternet;
        private Label lblInfoAvion;
        private Button btnVender;
        private Label label1;
        private Label label2;
        private Label lblCosto;
        private TextBox txtCosto;
    }
}