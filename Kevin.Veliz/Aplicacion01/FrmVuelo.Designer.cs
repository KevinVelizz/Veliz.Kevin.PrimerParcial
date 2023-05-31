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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
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
            btnModificar1 = new Guna.UI2.WinForms.Guna2Button();
            btnAgregar1 = new Guna.UI2.WinForms.Guna2Button();
            SuspendLayout();
            // 
            // btnLimpiar
            // 
            btnLimpiar.DialogResult = DialogResult.None;
            btnLimpiar.DisabledState.BorderColor = Color.DarkGray;
            btnLimpiar.DisabledState.CustomBorderColor = Color.DarkGray;
            btnLimpiar.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnLimpiar.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnLimpiar.Location = new Point(155, 559);
            btnLimpiar.ShadowDecoration.CustomizableEdges = customizableEdges1;
            // 
            // btnSalir
            // 
            btnSalir.DialogResult = DialogResult.None;
            btnSalir.DisabledState.BorderColor = Color.DarkGray;
            btnSalir.DisabledState.CustomBorderColor = Color.DarkGray;
            btnSalir.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnSalir.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnSalir.Location = new Point(275, 559);
            btnSalir.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnSalir.Text = "Cancelar";
            // 
            // txtCostoTurista
            // 
            txtCostoTurista.Anchor = AnchorStyles.None;
            txtCostoTurista.Location = new Point(141, 319);
            txtCostoTurista.Name = "txtCostoTurista";
            txtCostoTurista.Size = new Size(104, 23);
            txtCostoTurista.TabIndex = 3;
            // 
            // cboTipoVuelo
            // 
            cboTipoVuelo.Anchor = AnchorStyles.None;
            cboTipoVuelo.FormattingEnabled = true;
            cboTipoVuelo.Location = new Point(141, 20);
            cboTipoVuelo.Name = "cboTipoVuelo";
            cboTipoVuelo.Size = new Size(104, 23);
            cboTipoVuelo.TabIndex = 6;
            cboTipoVuelo.Text = "--Seleccione--";
            cboTipoVuelo.SelectedIndexChanged += cboTipoVuelo_SelectedIndexChanged;
            // 
            // lblTipoVuelo
            // 
            lblTipoVuelo.Anchor = AnchorStyles.None;
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
            lblPartida.Anchor = AnchorStyles.None;
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
            lblDestino.Anchor = AnchorStyles.None;
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
            lblFechaVuelo.Anchor = AnchorStyles.None;
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
            cboPartida.Anchor = AnchorStyles.None;
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
            cboDestino.Anchor = AnchorStyles.None;
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
            dtmVuelo.Anchor = AnchorStyles.None;
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
            lblCostoTurista.Anchor = AnchorStyles.None;
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
            lblLLegada.Anchor = AnchorStyles.None;
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
            lblHoraVuelo.Anchor = AnchorStyles.None;
            lblHoraVuelo.AutoSize = true;
            lblHoraVuelo.Location = new Point(141, 229);
            lblHoraVuelo.Name = "lblHoraVuelo";
            lblHoraVuelo.Size = new Size(38, 15);
            lblHoraVuelo.TabIndex = 17;
            lblHoraVuelo.Text = "label1";
            // 
            // lblDuracionVuelo
            // 
            lblDuracionVuelo.Anchor = AnchorStyles.None;
            lblDuracionVuelo.AutoSize = true;
            lblDuracionVuelo.Location = new Point(141, 281);
            lblDuracionVuelo.Name = "lblDuracionVuelo";
            lblDuracionVuelo.Size = new Size(38, 15);
            lblDuracionVuelo.TabIndex = 18;
            lblDuracionVuelo.Text = "label1";
            // 
            // lblHoraSalida
            // 
            lblHoraSalida.Anchor = AnchorStyles.None;
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
            txtCostoPremium.Anchor = AnchorStyles.None;
            txtCostoPremium.Location = new Point(141, 373);
            txtCostoPremium.Name = "txtCostoPremium";
            txtCostoPremium.Size = new Size(104, 23);
            txtCostoPremium.TabIndex = 21;
            // 
            // lblCostoPremium
            // 
            lblCostoPremium.Anchor = AnchorStyles.None;
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
            label1.Anchor = AnchorStyles.None;
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
            cboAeronave.Anchor = AnchorStyles.None;
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
            lblInfoAeronave.Anchor = AnchorStyles.None;
            lblInfoAeronave.AutoSize = true;
            lblInfoAeronave.Location = new Point(141, 451);
            lblInfoAeronave.Name = "lblInfoAeronave";
            lblInfoAeronave.Size = new Size(38, 15);
            lblInfoAeronave.TabIndex = 25;
            lblInfoAeronave.Text = "label2";
            lblInfoAeronave.Visible = false;
            // 
            // btnModificar1
            // 
            btnModificar1.Anchor = AnchorStyles.None;
            btnModificar1.Animated = true;
            btnModificar1.CustomizableEdges = customizableEdges3;
            btnModificar1.DisabledState.BorderColor = Color.DarkGray;
            btnModificar1.DisabledState.CustomBorderColor = Color.DarkGray;
            btnModificar1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnModificar1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnModificar1.FillColor = Color.FromArgb(255, 224, 192);
            btnModificar1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnModificar1.ForeColor = Color.Black;
            btnModificar1.Location = new Point(50, 520);
            btnModificar1.Name = "btnModificar1";
            btnModificar1.PressedColor = Color.IndianRed;
            btnModificar1.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnModificar1.Size = new Size(78, 23);
            btnModificar1.TabIndex = 28;
            btnModificar1.Text = "Modificar";
            btnModificar1.Click += btnModificar1_Click;
            // 
            // btnAgregar1
            // 
            btnAgregar1.Anchor = AnchorStyles.None;
            btnAgregar1.Animated = true;
            btnAgregar1.CustomizableEdges = customizableEdges5;
            btnAgregar1.DisabledState.BorderColor = Color.DarkGray;
            btnAgregar1.DisabledState.CustomBorderColor = Color.DarkGray;
            btnAgregar1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnAgregar1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnAgregar1.FillColor = Color.FromArgb(255, 224, 192);
            btnAgregar1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnAgregar1.ForeColor = Color.Black;
            btnAgregar1.Location = new Point(50, 559);
            btnAgregar1.Name = "btnAgregar1";
            btnAgregar1.PressedColor = Color.IndianRed;
            btnAgregar1.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnAgregar1.Size = new Size(78, 23);
            btnAgregar1.TabIndex = 27;
            btnAgregar1.Text = "Agregar";
            btnAgregar1.Click += btnAgregar1_Click;
            // 
            // FrmVuelo
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(393, 598);
            Controls.Add(btnModificar1);
            Controls.Add(btnAgregar1);
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
            Name = "FrmVuelo";
            Text = "FrmVuelo";
            Load += FrmVuelo_Load;
            Controls.SetChildIndex(btnLimpiar, 0);
            Controls.SetChildIndex(btnSalir, 0);
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
            Controls.SetChildIndex(btnAgregar1, 0);
            Controls.SetChildIndex(btnModificar1, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtCostoTurista;
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
        protected Guna.UI2.WinForms.Guna2Button btnModificar1;
        protected Guna.UI2.WinForms.Guna2Button btnAgregar1;
    }
}