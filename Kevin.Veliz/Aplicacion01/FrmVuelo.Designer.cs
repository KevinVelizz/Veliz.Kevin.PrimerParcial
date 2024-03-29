﻿namespace Aplicacion01
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
            btnAgregar = new Button();
            txtCostoTurista = new TextBox();
            cboTipoVuelo = new ComboBox();
            lblTipoVuelo = new Label();
            lblPartida = new Label();
            lblDestino = new Label();
            lblFechaVuelo = new Label();
            cboPartida = new ComboBox();
            cboDestino = new ComboBox();
            dtmVuelo = new DateTimePicker();
            lblCostoTurista = new Label();
            lblLLegada = new Label();
            lblHoraVuelo = new Label();
            lblDuracionVuelo = new Label();
            lblHoraSalida = new Label();
            txtCostoPremium = new TextBox();
            lblCostoPremium = new Label();
            label1 = new Label();
            cboAeronave = new ComboBox();
            lblInfoAeronave = new Label();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(252, 559);
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(141, 559);
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(41, 559);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 0;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // txtCostoTurista
            // 
            txtCostoTurista.Location = new Point(141, 319);
            txtCostoTurista.Name = "txtCostoTurista";
            txtCostoTurista.Size = new Size(104, 23);
            txtCostoTurista.TabIndex = 3;
            // 
            // cboTipoVuelo
            // 
            cboTipoVuelo.FormattingEnabled = true;
            cboTipoVuelo.Location = new Point(141, 20);
            cboTipoVuelo.Name = "cboTipoVuelo";
            cboTipoVuelo.Size = new Size(104, 23);
            cboTipoVuelo.TabIndex = 6;
            cboTipoVuelo.Text = "--Seleccione--";
            cboTipoVuelo.SelectedIndexChanged += cboTipoVuelo_SelectedIndexChanged;
            cboTipoVuelo.SelectionChangeCommitted += cboTipoVuelo_SelectionChangeCommitted;
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
            lblPartida.Location = new Point(2, 74);
            lblPartida.Name = "lblPartida";
            lblPartida.Size = new Size(117, 17);
            lblPartida.TabIndex = 8;
            lblPartida.Text = "Ciudad de partida:";
            // 
            // lblDestino
            // 
            lblDestino.AutoSize = true;
            lblDestino.Font = new Font("Segoe UI Symbol", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            lblDestino.Location = new Point(3, 126);
            lblDestino.Name = "lblDestino";
            lblDestino.Size = new Size(116, 17);
            lblDestino.TabIndex = 9;
            lblDestino.Text = "ciudad de destino:";
            // 
            // lblFechaVuelo
            // 
            lblFechaVuelo.AutoSize = true;
            lblFechaVuelo.Font = new Font("Segoe UI Symbol", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            lblFechaVuelo.Location = new Point(21, 181);
            lblFechaVuelo.Name = "lblFechaVuelo";
            lblFechaVuelo.Size = new Size(98, 17);
            lblFechaVuelo.TabIndex = 10;
            lblFechaVuelo.Text = "Fecha de vuelo:";
            // 
            // cboPartida
            // 
            cboPartida.FormattingEnabled = true;
            cboPartida.Location = new Point(141, 68);
            cboPartida.Name = "cboPartida";
            cboPartida.Size = new Size(104, 23);
            cboPartida.TabIndex = 11;
            cboPartida.Text = "--Seleccione--";
            cboPartida.SelectedIndexChanged += cboPartida_SelectedIndexChanged;
            // 
            // cboDestino
            // 
            cboDestino.FormattingEnabled = true;
            cboDestino.Location = new Point(141, 120);
            cboDestino.Name = "cboDestino";
            cboDestino.Size = new Size(104, 23);
            cboDestino.TabIndex = 12;
            cboDestino.Text = "--Seleccione--";
            cboDestino.SelectedIndexChanged += cboDestino_SelectedIndexChanged;
            // 
            // dtmVuelo
            // 
            dtmVuelo.Checked = false;
            dtmVuelo.Enabled = false;
            dtmVuelo.Location = new Point(141, 175);
            dtmVuelo.MaxDate = new DateTime(2023, 12, 31, 0, 0, 0, 0);
            dtmVuelo.MinDate = new DateTime(2023, 1, 1, 0, 0, 0, 0);
            dtmVuelo.Name = "dtmVuelo";
            dtmVuelo.Size = new Size(228, 23);
            dtmVuelo.TabIndex = 13;
            dtmVuelo.ValueChanged += dtmVuelo_ValueChanged;
            // 
            // lblCostoTurista
            // 
            lblCostoTurista.AutoSize = true;
            lblCostoTurista.Font = new Font("Segoe UI Symbol", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            lblCostoTurista.Location = new Point(31, 325);
            lblCostoTurista.Name = "lblCostoTurista";
            lblCostoTurista.Size = new Size(85, 17);
            lblCostoTurista.TabIndex = 14;
            lblCostoTurista.Text = "Costo turista:";
            // 
            // lblLLegada
            // 
            lblLLegada.AutoSize = true;
            lblLLegada.Font = new Font("Segoe UI Symbol", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            lblLLegada.Location = new Point(59, 279);
            lblLLegada.Name = "lblLLegada";
            lblLLegada.Size = new Size(60, 17);
            lblLLegada.TabIndex = 15;
            lblLLegada.Text = "LLegada:";
            // 
            // lblHoraVuelo
            // 
            lblHoraVuelo.AutoSize = true;
            lblHoraVuelo.Location = new Point(141, 229);
            lblHoraVuelo.Name = "lblHoraVuelo";
            lblHoraVuelo.Size = new Size(38, 15);
            lblHoraVuelo.TabIndex = 17;
            lblHoraVuelo.Text = "label1";
            // 
            // lblDuracionVuelo
            // 
            lblDuracionVuelo.AutoSize = true;
            lblDuracionVuelo.Location = new Point(141, 281);
            lblDuracionVuelo.Name = "lblDuracionVuelo";
            lblDuracionVuelo.Size = new Size(38, 15);
            lblDuracionVuelo.TabIndex = 18;
            lblDuracionVuelo.Text = "label1";
            // 
            // lblHoraSalida
            // 
            lblHoraSalida.AutoSize = true;
            lblHoraSalida.Font = new Font("Segoe UI Symbol", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            lblHoraSalida.Location = new Point(70, 229);
            lblHoraSalida.Name = "lblHoraSalida";
            lblHoraSalida.Size = new Size(46, 17);
            lblHoraSalida.TabIndex = 19;
            lblHoraSalida.Text = "Salida:";
            // 
            // txtCostoPremium
            // 
            txtCostoPremium.Location = new Point(141, 373);
            txtCostoPremium.Name = "txtCostoPremium";
            txtCostoPremium.Size = new Size(104, 23);
            txtCostoPremium.TabIndex = 21;
            // 
            // lblCostoPremium
            // 
            lblCostoPremium.AutoSize = true;
            lblCostoPremium.Font = new Font("Segoe UI Symbol", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            lblCostoPremium.Location = new Point(15, 379);
            lblCostoPremium.Name = "lblCostoPremium";
            lblCostoPremium.Size = new Size(101, 17);
            lblCostoPremium.TabIndex = 22;
            lblCostoPremium.Text = "Costo premium:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Symbol", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(50, 431);
            label1.Name = "label1";
            label1.Size = new Size(66, 17);
            label1.TabIndex = 23;
            label1.Text = "Aeronave:";
            // 
            // cboAeronave
            // 
            cboAeronave.FormattingEnabled = true;
            cboAeronave.Location = new Point(141, 425);
            cboAeronave.Name = "cboAeronave";
            cboAeronave.Size = new Size(104, 23);
            cboAeronave.TabIndex = 24;
            cboAeronave.Text = "--Seleccione--";
            cboAeronave.SelectedIndexChanged += cboAeronave_SelectedIndexChanged;
            cboAeronave.Click += cboAeronave_Click;
            // 
            // lblInfoAeronave
            // 
            lblInfoAeronave.AutoSize = true;
            lblInfoAeronave.Location = new Point(141, 451);
            lblInfoAeronave.Name = "lblInfoAeronave";
            lblInfoAeronave.Size = new Size(38, 15);
            lblInfoAeronave.TabIndex = 25;
            lblInfoAeronave.Text = "label2";
            lblInfoAeronave.Visible = false;
            // 
            // FrmVuelo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(393, 598);
            Controls.Add(lblInfoAeronave);
            Controls.Add(cboAeronave);
            Controls.Add(label1);
            Controls.Add(lblCostoPremium);
            Controls.Add(txtCostoPremium);
            Controls.Add(lblHoraSalida);
            Controls.Add(lblDuracionVuelo);
            Controls.Add(lblHoraVuelo);
            Controls.Add(lblLLegada);
            Controls.Add(lblCostoTurista);
            Controls.Add(dtmVuelo);
            Controls.Add(cboDestino);
            Controls.Add(cboPartida);
            Controls.Add(lblFechaVuelo);
            Controls.Add(lblDestino);
            Controls.Add(lblPartida);
            Controls.Add(lblTipoVuelo);
            Controls.Add(cboTipoVuelo);
            Controls.Add(txtCostoTurista);
            Controls.Add(btnAgregar);
            Name = "FrmVuelo";
            Text = "FrmVuelo";
            Load += FrmVuelo_Load;
            Controls.SetChildIndex(btnCancelar, 0);
            Controls.SetChildIndex(btnLimpiar, 0);
            Controls.SetChildIndex(btnAgregar, 0);
            Controls.SetChildIndex(txtCostoTurista, 0);
            Controls.SetChildIndex(cboTipoVuelo, 0);
            Controls.SetChildIndex(lblTipoVuelo, 0);
            Controls.SetChildIndex(lblPartida, 0);
            Controls.SetChildIndex(lblDestino, 0);
            Controls.SetChildIndex(lblFechaVuelo, 0);
            Controls.SetChildIndex(cboPartida, 0);
            Controls.SetChildIndex(cboDestino, 0);
            Controls.SetChildIndex(dtmVuelo, 0);
            Controls.SetChildIndex(lblCostoTurista, 0);
            Controls.SetChildIndex(lblLLegada, 0);
            Controls.SetChildIndex(lblHoraVuelo, 0);
            Controls.SetChildIndex(lblDuracionVuelo, 0);
            Controls.SetChildIndex(lblHoraSalida, 0);
            Controls.SetChildIndex(txtCostoPremium, 0);
            Controls.SetChildIndex(lblCostoPremium, 0);
            Controls.SetChildIndex(label1, 0);
            Controls.SetChildIndex(cboAeronave, 0);
            Controls.SetChildIndex(lblInfoAeronave, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAgregar;
        private TextBox txtCostoTurista;
        private TextBox textBox3;
        private ComboBox cboTipoVuelo;
        private Label lblTipoVuelo;
        private Label lblPartida;
        private Label lblDestino;
        private Label lblFechaVuelo;
        private ComboBox cboPartida;
        private ComboBox cboDestino;
        private DateTimePicker dtmVuelo;
        private Label lblCostoTurista;
        private Label lblLLegada;
        private Label lblHoraVuelo;
        private Label lblDuracionVuelo;
        private Label lblHoraSalida;
        private TextBox txtCostoPremium;
        private Label lblCostoPremium;
        private Label label1;
        private ComboBox cboAeronave;
        private Label lblInfoAeronave;
    }
}