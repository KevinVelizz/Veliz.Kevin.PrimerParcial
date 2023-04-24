namespace Aplicacion01
{
    partial class Aerolineas
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblInicio = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // lblInicio
            // 
            lblInicio.AutoSize = true;
            lblInicio.Location = new Point(333, 109);
            lblInicio.Name = "lblInicio";
            lblInicio.Size = new Size(87, 15);
            lblInicio.TabIndex = 0;
            lblInicio.Text = "Iniciaste Sesión";
            // 
            // button1
            // 
            button1.Location = new Point(333, 259);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // Aerolineas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(822, 492);
            Controls.Add(button1);
            Controls.Add(lblInicio);
            Name = "Aerolineas";
            Text = "Aerolineas";
            Load += Aerolineas_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblInicio;
        private Button button1;
    }
}