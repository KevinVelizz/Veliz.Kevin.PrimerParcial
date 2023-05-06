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
            menuStrip1 = new MenuStrip();
            inicioToolStripMenuItem = new ToolStripMenuItem();
            pasajeroToolStripMenuItem = new ToolStripMenuItem();
            StripAgregarPasajero = new ToolStripMenuItem();
            verClientesToolStripMenuItem = new ToolStripMenuItem();
            StripVender = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.ActiveCaption;
            menuStrip1.Font = new Font("Segoe UI Symbol", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            menuStrip1.Items.AddRange(new ToolStripItem[] { inicioToolStripMenuItem, pasajeroToolStripMenuItem, StripVender });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(951, 25);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // inicioToolStripMenuItem
            // 
            inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            inicioToolStripMenuItem.Size = new Size(50, 21);
            inicioToolStripMenuItem.Text = "Inicio";
            // 
            // pasajeroToolStripMenuItem
            // 
            pasajeroToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { StripAgregarPasajero, verClientesToolStripMenuItem });
            pasajeroToolStripMenuItem.Name = "pasajeroToolStripMenuItem";
            pasajeroToolStripMenuItem.Size = new Size(76, 21);
            pasajeroToolStripMenuItem.Text = "Pasajeros";
            // 
            // StripAgregarPasajero
            // 
            StripAgregarPasajero.Name = "StripAgregarPasajero";
            StripAgregarPasajero.Size = new Size(180, 22);
            StripAgregarPasajero.Text = "Agregar pasajero";
            StripAgregarPasajero.Click += agregarPasajeroToolStripMenuItem_Click;
            // 
            // verClientesToolStripMenuItem
            // 
            verClientesToolStripMenuItem.Name = "verClientesToolStripMenuItem";
            verClientesToolStripMenuItem.Size = new Size(180, 22);
            verClientesToolStripMenuItem.Text = "Ver pasajeros";
            // 
            // StripVender
            // 
            StripVender.Name = "StripVender";
            StripVender.Size = new Size(99, 21);
            StripVender.Text = "Vender Vuelo";
            // 
            // Aerolineas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(951, 573);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Aerolineas";
            Text = "Aerolineas";
            Load += Aerolineas_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem inicioToolStripMenuItem;
        private ToolStripMenuItem pasajeroToolStripMenuItem;
        private ToolStripMenuItem StripAgregarPasajero;
        private ToolStripMenuItem StripVender;
        private ToolStripMenuItem verClientesToolStripMenuItem;
    }
}