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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            btnCancelar = new Button();
            lblMatricula = new Label();
            lblCantAsientos = new Label();
            lblCantBanios = new Label();
            chkInternet = new CheckBox();
            chkComida = new CheckBox();
            btnAgregar = new Button();
            btnLimpiar = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(144, 28);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(144, 75);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(144, 128);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 2;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(230, 302);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // lblMatricula
            // 
            lblMatricula.AutoSize = true;
            lblMatricula.Location = new Point(54, 36);
            lblMatricula.Name = "lblMatricula";
            lblMatricula.Size = new Size(60, 15);
            lblMatricula.TabIndex = 8;
            lblMatricula.Text = "Matricula:";
            // 
            // lblCantAsientos
            // 
            lblCantAsientos.AutoSize = true;
            lblCantAsientos.Location = new Point(12, 83);
            lblCantAsientos.Name = "lblCantAsientos";
            lblCantAsientos.Size = new Size(104, 15);
            lblCantAsientos.TabIndex = 9;
            lblCantAsientos.Text = "Cantidad asientos:";
            // 
            // lblCantBanios
            // 
            lblCantBanios.AutoSize = true;
            lblCantBanios.Location = new Point(21, 136);
            lblCantBanios.Name = "lblCantBanios";
            lblCantBanios.Size = new Size(93, 15);
            lblCantBanios.TabIndex = 10;
            lblCantBanios.Text = "Cantidad baños:";
            // 
            // chkInternet
            // 
            chkInternet.AutoSize = true;
            chkInternet.Location = new Point(144, 178);
            chkInternet.Name = "chkInternet";
            chkInternet.Size = new Size(67, 19);
            chkInternet.TabIndex = 13;
            chkInternet.Text = "Internet";
            chkInternet.UseVisualStyleBackColor = true;
            // 
            // chkComida
            // 
            chkComida.AutoSize = true;
            chkComida.Location = new Point(144, 212);
            chkComida.Name = "chkComida";
            chkComida.Size = new Size(68, 19);
            chkComida.TabIndex = 14;
            chkComida.Text = "Comida";
            chkComida.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(54, 302);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 15;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(144, 302);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 16;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // FrmAeronave
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(332, 350);
            ControlBox = false;
            Controls.Add(btnLimpiar);
            Controls.Add(btnAgregar);
            Controls.Add(chkComida);
            Controls.Add(chkInternet);
            Controls.Add(lblCantBanios);
            Controls.Add(lblCantAsientos);
            Controls.Add(lblMatricula);
            Controls.Add(btnCancelar);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "FrmAeronave";
            Text = "FrmAeronave";
            Load += FrmAeronave_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Button button1;
        private Button button2;
        private Button btnCancelar;
        private Label lblMatricula;
        private Label lblCantAsientos;
        private Label lblCantBanios;
        private CheckBox chkInternet;
        private CheckBox chkComida;
        private Label lblInternet;
        private Label lblComida;
        private Button btnAgregar;
        private Button btnLimpiar;
    }
}