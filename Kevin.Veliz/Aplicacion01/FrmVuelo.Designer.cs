namespace Aplicacion01
{
    partial class FrmVuelo
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            txtCosto = new TextBox();
            cboTipoVuelo = new ComboBox();
            lblTipoVuelo = new Label();
            lblPartida = new Label();
            lblDestino = new Label();
            lblFechaVuelo = new Label();
            cboPartida = new ComboBox();
            cboDestino = new ComboBox();
            dtmVuelo = new DateTimePicker();
            lblCosto = new Label();
            lblLLegada = new Label();
            lblHoraVuelo = new Label();
            lblDuracionVuelo = new Label();
            lblHoraSalida = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(39, 464);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(129, 464);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 1;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(224, 464);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 2;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // txtCosto
            // 
            txtCosto.Location = new Point(141, 318);
            txtCosto.Name = "txtCosto";
            txtCosto.Size = new Size(104, 23);
            txtCosto.TabIndex = 3;
            // 
            // cboTipoVuelo
            // 
            cboTipoVuelo.FormattingEnabled = true;
            cboTipoVuelo.Location = new Point(141, 20);
            cboTipoVuelo.Name = "cboTipoVuelo";
            cboTipoVuelo.Size = new Size(104, 23);
            cboTipoVuelo.TabIndex = 6;
            cboTipoVuelo.Text = "--Seleccione--";
            // 
            // lblTipoVuelo
            // 
            lblTipoVuelo.AutoSize = true;
            lblTipoVuelo.Font = new Font("Segoe UI Symbol", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            lblTipoVuelo.Location = new Point(47, 26);
            lblTipoVuelo.Name = "lblTipoVuelo";
            lblTipoVuelo.Size = new Size(72, 17);
            lblTipoVuelo.TabIndex = 7;
            lblTipoVuelo.Text = "Tipo vuelo:";
            // 
            // lblPartida
            // 
            lblPartida.AutoSize = true;
            lblPartida.Font = new Font("Segoe UI Symbol", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            lblPartida.Location = new Point(6, 77);
            lblPartida.Name = "lblPartida";
            lblPartida.Size = new Size(117, 17);
            lblPartida.TabIndex = 8;
            lblPartida.Text = "Ciudad de partida:";
            // 
            // lblDestino
            // 
            lblDestino.AutoSize = true;
            lblDestino.Font = new Font("Segoe UI Symbol", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            lblDestino.Location = new Point(10, 128);
            lblDestino.Name = "lblDestino";
            lblDestino.Size = new Size(116, 17);
            lblDestino.TabIndex = 9;
            lblDestino.Text = "ciudad de destino:";
            // 
            // lblFechaVuelo
            // 
            lblFechaVuelo.AutoSize = true;
            lblFechaVuelo.Font = new Font("Segoe UI Symbol", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            lblFechaVuelo.Location = new Point(25, 175);
            lblFechaVuelo.Name = "lblFechaVuelo";
            lblFechaVuelo.Size = new Size(98, 17);
            lblFechaVuelo.TabIndex = 10;
            lblFechaVuelo.Text = "Fecha de vuelo:";
            // 
            // cboPartida
            // 
            cboPartida.FormattingEnabled = true;
            cboPartida.Location = new Point(141, 71);
            cboPartida.Name = "cboPartida";
            cboPartida.Size = new Size(104, 23);
            cboPartida.TabIndex = 11;
            cboPartida.Text = "--Seleccione--";
            // 
            // cboDestino
            // 
            cboDestino.FormattingEnabled = true;
            cboDestino.Location = new Point(141, 122);
            cboDestino.Name = "cboDestino";
            cboDestino.Size = new Size(104, 23);
            cboDestino.TabIndex = 12;
            cboDestino.Text = "--Seleccione--";
            // 
            // dtmVuelo
            // 
            dtmVuelo.Checked = false;
            dtmVuelo.Location = new Point(141, 169);
            dtmVuelo.MaxDate = new DateTime(2023, 12, 31, 0, 0, 0, 0);
            dtmVuelo.MinDate = new DateTime(2023, 1, 1, 0, 0, 0, 0);
            dtmVuelo.Name = "dtmVuelo";
            dtmVuelo.Size = new Size(216, 23);
            dtmVuelo.TabIndex = 13;
            dtmVuelo.ValueChanged += dtmVuelo_ValueChanged;
            // 
            // lblCosto
            // 
            lblCosto.AutoSize = true;
            lblCosto.Font = new Font("Segoe UI Symbol", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            lblCosto.Location = new Point(73, 324);
            lblCosto.Name = "lblCosto";
            lblCosto.Size = new Size(45, 17);
            lblCosto.TabIndex = 14;
            lblCosto.Text = "Costo:";
            // 
            // lblLLegada
            // 
            lblLLegada.AutoSize = true;
            lblLLegada.Font = new Font("Segoe UI Symbol", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            lblLLegada.Location = new Point(56, 256);
            lblLLegada.Name = "lblLLegada";
            lblLLegada.Size = new Size(60, 17);
            lblLLegada.TabIndex = 15;
            lblLLegada.Text = "LLegada:";
            // 
            // lblHoraVuelo
            // 
            lblHoraVuelo.AutoSize = true;
            lblHoraVuelo.Location = new Point(141, 205);
            lblHoraVuelo.Name = "lblHoraVuelo";
            lblHoraVuelo.Size = new Size(38, 15);
            lblHoraVuelo.TabIndex = 17;
            lblHoraVuelo.Text = "label1";
            // 
            // lblDuracionVuelo
            // 
            lblDuracionVuelo.AutoSize = true;
            lblDuracionVuelo.Location = new Point(141, 256);
            lblDuracionVuelo.Name = "lblDuracionVuelo";
            lblDuracionVuelo.Size = new Size(38, 15);
            lblDuracionVuelo.TabIndex = 18;
            lblDuracionVuelo.Text = "label1";
            // 
            // lblHoraSalida
            // 
            lblHoraSalida.AutoSize = true;
            lblHoraSalida.Font = new Font("Segoe UI Symbol", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            lblHoraSalida.Location = new Point(73, 205);
            lblHoraSalida.Name = "lblHoraSalida";
            lblHoraSalida.Size = new Size(46, 17);
            lblHoraSalida.TabIndex = 19;
            lblHoraSalida.Text = "Salida:";
            // 
            // FrmVuelo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(374, 509);
            Controls.Add(lblHoraSalida);
            Controls.Add(lblDuracionVuelo);
            Controls.Add(lblHoraVuelo);
            Controls.Add(lblLLegada);
            Controls.Add(lblCosto);
            Controls.Add(dtmVuelo);
            Controls.Add(cboDestino);
            Controls.Add(cboPartida);
            Controls.Add(lblFechaVuelo);
            Controls.Add(lblDestino);
            Controls.Add(lblPartida);
            Controls.Add(lblTipoVuelo);
            Controls.Add(cboTipoVuelo);
            Controls.Add(txtCosto);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "FrmVuelo";
            Text = "FrmVuelo";
            Load += FrmVuelo_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private TextBox txtCosto;
        private TextBox textBox3;
        private ComboBox cboTipoVuelo;
        private Label lblTipoVuelo;
        private Label lblPartida;
        private Label lblDestino;
        private Label lblFechaVuelo;
        private ComboBox cboPartida;
        private ComboBox cboDestino;
        private DateTimePicker dtmVuelo;
        private Label lblCosto;
        private Label lblLLegada;
        private Label lblHoraVuelo;
        private Label lblDuracionVuelo;
        private Label lblHoraSalida;
    }
}