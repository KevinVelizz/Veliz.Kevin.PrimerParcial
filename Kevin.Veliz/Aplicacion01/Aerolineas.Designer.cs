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
            agregarPasajeroToolStripMenuItem = new ToolStripMenuItem();
            venderVueloToolStripMenuItem = new ToolStripMenuItem();
            comboBox1 = new ComboBox();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { inicioToolStripMenuItem, pasajeroToolStripMenuItem, venderVueloToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(822, 24);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // inicioToolStripMenuItem
            // 
            inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            inicioToolStripMenuItem.Size = new Size(48, 20);
            inicioToolStripMenuItem.Text = "Inicio";
            // 
            // pasajeroToolStripMenuItem
            // 
            pasajeroToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { agregarPasajeroToolStripMenuItem });
            pasajeroToolStripMenuItem.Name = "pasajeroToolStripMenuItem";
            pasajeroToolStripMenuItem.Size = new Size(61, 20);
            pasajeroToolStripMenuItem.Text = "Clientes";
            // 
            // agregarPasajeroToolStripMenuItem
            // 
            agregarPasajeroToolStripMenuItem.Name = "agregarPasajeroToolStripMenuItem";
            agregarPasajeroToolStripMenuItem.Size = new Size(180, 22);
            agregarPasajeroToolStripMenuItem.Text = "Agregar pasajero";
            // 
            // venderVueloToolStripMenuItem
            // 
            venderVueloToolStripMenuItem.Name = "venderVueloToolStripMenuItem";
            venderVueloToolStripMenuItem.Size = new Size(88, 20);
            venderVueloToolStripMenuItem.Text = "Vender Vuelo";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(346, 141);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 3;
            // 
            // Aerolineas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(822, 492);
            Controls.Add(comboBox1);
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
        private ToolStripMenuItem agregarPasajeroToolStripMenuItem;
        private ToolStripMenuItem venderVueloToolStripMenuItem;
        private ComboBox comboBox1;
    }
}