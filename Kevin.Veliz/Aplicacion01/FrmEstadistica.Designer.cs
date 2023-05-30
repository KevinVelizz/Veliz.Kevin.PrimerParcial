namespace Aplicacion01
{
    partial class FrmEstadistica
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
            lblTitulo = new Label();
            btnCalcular = new Button();
            lblMontoTotal = new Label();
            textBox1 = new TextBox();
            dtgvViajes = new DataGridView();
            Partida = new DataGridViewTextBoxColumn();
            Destino = new DataGridViewTextBoxColumn();
            FechaSalida = new DataGridViewTextBoxColumn();
            FechaLlegada = new DataGridViewTextBoxColumn();
            Avion = new DataGridViewTextBoxColumn();
            CantAsientosPremium = new DataGridViewTextBoxColumn();
            CantAsientosTurista = new DataGridViewTextBoxColumn();
            CostoClasePremium = new DataGridViewTextBoxColumn();
            CostoClaseTurista = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            RecaudacionTotal = new DataGridViewTextBoxColumn();
            label1 = new Label();
            dtgvMontoDestinos = new DataGridView();
            DestinoLugar = new DataGridViewTextBoxColumn();
            MontoDestino = new DataGridViewTextBoxColumn();
            lblDestinoFavorito = new Label();
            lblDestino = new Label();
            ((System.ComponentModel.ISupportInitialize)dtgvViajes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtgvMontoDestinos).BeginInit();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.None;
            btnCancelar.Location = new Point(755, 519);
            btnCancelar.Text = "Salir";
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Anchor = AnchorStyles.None;
            btnLimpiar.Location = new Point(661, 519);
            btnLimpiar.Visible = false;
            // 
            // lblTitulo
            // 
            lblTitulo.Anchor = AnchorStyles.None;
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI Symbol", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            lblTitulo.Location = new Point(12, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(109, 17);
            lblTitulo.TabIndex = 5;
            lblTitulo.Text = "Viajes Realizados";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnCalcular
            // 
            btnCalcular.Anchor = AnchorStyles.None;
            btnCalcular.Font = new Font("Segoe UI Symbol", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            btnCalcular.Location = new Point(755, 29);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 6;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // lblMontoTotal
            // 
            lblMontoTotal.Anchor = AnchorStyles.None;
            lblMontoTotal.AutoSize = true;
            lblMontoTotal.Font = new Font("Segoe UI Symbol", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            lblMontoTotal.Location = new Point(510, 37);
            lblMontoTotal.Name = "lblMontoTotal";
            lblMontoTotal.Size = new Size(120, 17);
            lblMontoTotal.TabIndex = 7;
            lblMontoTotal.Text = "Monto Recaudado:";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.None;
            textBox1.Enabled = false;
            textBox1.Font = new Font("Segoe UI Symbol", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            textBox1.Location = new Point(636, 29);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 25);
            textBox1.TabIndex = 8;
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // dtgvViajes
            // 
            dtgvViajes.Anchor = AnchorStyles.None;
            dtgvViajes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvViajes.Columns.AddRange(new DataGridViewColumn[] { Partida, Destino, FechaSalida, FechaLlegada, Avion, CantAsientosPremium, CantAsientosTurista, CostoClasePremium, CostoClaseTurista, Estado, RecaudacionTotal });
            dtgvViajes.Location = new Point(12, 29);
            dtgvViajes.MultiSelect = false;
            dtgvViajes.Name = "dtgvViajes";
            dtgvViajes.RowTemplate.Height = 25;
            dtgvViajes.Size = new Size(444, 239);
            dtgvViajes.TabIndex = 9;
            // 
            // Partida
            // 
            Partida.HeaderText = "Lugar de partida";
            Partida.Name = "Partida";
            // 
            // Destino
            // 
            Destino.HeaderText = "Lugar de destino";
            Destino.Name = "Destino";
            // 
            // FechaSalida
            // 
            FechaSalida.HeaderText = "Fecha salida";
            FechaSalida.Name = "FechaSalida";
            // 
            // FechaLlegada
            // 
            FechaLlegada.HeaderText = "Fecha Llegada";
            FechaLlegada.Name = "FechaLlegada";
            // 
            // Avion
            // 
            Avion.HeaderText = "Avion";
            Avion.Name = "Avion";
            // 
            // CantAsientosPremium
            // 
            CantAsientosPremium.HeaderText = "Asientos premium";
            CantAsientosPremium.Name = "CantAsientosPremium";
            // 
            // CantAsientosTurista
            // 
            CantAsientosTurista.HeaderText = "Asientos turistas";
            CantAsientosTurista.Name = "CantAsientosTurista";
            // 
            // CostoClasePremium
            // 
            CostoClasePremium.HeaderText = "Costo premium";
            CostoClasePremium.Name = "CostoClasePremium";
            // 
            // CostoClaseTurista
            // 
            CostoClaseTurista.HeaderText = "Costo turista";
            CostoClaseTurista.Name = "CostoClaseTurista";
            // 
            // Estado
            // 
            Estado.HeaderText = "Estado";
            Estado.Name = "Estado";
            // 
            // RecaudacionTotal
            // 
            RecaudacionTotal.HeaderText = "Recaudacion";
            RecaudacionTotal.Name = "RecaudacionTotal";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Symbol", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(12, 303);
            label1.Name = "label1";
            label1.Size = new Size(148, 17);
            label1.TabIndex = 11;
            label1.Text = "Monto de cada destino:";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dtgvMontoDestinos
            // 
            dtgvMontoDestinos.Anchor = AnchorStyles.None;
            dtgvMontoDestinos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvMontoDestinos.Columns.AddRange(new DataGridViewColumn[] { DestinoLugar, MontoDestino });
            dtgvMontoDestinos.Location = new Point(12, 323);
            dtgvMontoDestinos.MultiSelect = false;
            dtgvMontoDestinos.Name = "dtgvMontoDestinos";
            dtgvMontoDestinos.RowTemplate.Height = 25;
            dtgvMontoDestinos.Size = new Size(240, 150);
            dtgvMontoDestinos.TabIndex = 12;
            // 
            // DestinoLugar
            // 
            DestinoLugar.HeaderText = "Destino";
            DestinoLugar.Name = "DestinoLugar";
            // 
            // MontoDestino
            // 
            MontoDestino.HeaderText = "Monto";
            MontoDestino.Name = "MontoDestino";
            // 
            // lblDestinoFavorito
            // 
            lblDestinoFavorito.Anchor = AnchorStyles.None;
            lblDestinoFavorito.AutoSize = true;
            lblDestinoFavorito.Font = new Font("Segoe UI Symbol", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            lblDestinoFavorito.Location = new Point(281, 323);
            lblDestinoFavorito.Name = "lblDestinoFavorito";
            lblDestinoFavorito.Size = new Size(106, 17);
            lblDestinoFavorito.TabIndex = 13;
            lblDestinoFavorito.Text = "Destino Favorito:";
            // 
            // lblDestino
            // 
            lblDestino.Anchor = AnchorStyles.None;
            lblDestino.AutoSize = true;
            lblDestino.Font = new Font("Segoe UI Symbol", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            lblDestino.Location = new Point(281, 365);
            lblDestino.Name = "lblDestino";
            lblDestino.Size = new Size(15, 17);
            lblDestino.TabIndex = 14;
            lblDestino.Text = "a";
            // 
            // FrmEstadistica
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(856, 554);
            ControlBox = false;
            Controls.Add(lblDestino);
            Controls.Add(lblDestinoFavorito);
            Controls.Add(dtgvMontoDestinos);
            Controls.Add(label1);
            Controls.Add(dtgvViajes);
            Controls.Add(textBox1);
            Controls.Add(lblMontoTotal);
            Controls.Add(btnCalcular);
            Controls.Add(lblTitulo);
            Name = "FrmEstadistica";
            Text = "Estadisticas";
            Load += FrmEstadisticaBase_Load;
            Controls.SetChildIndex(btnCancelar, 0);
            Controls.SetChildIndex(btnLimpiar, 0);
            Controls.SetChildIndex(lblTitulo, 0);
            Controls.SetChildIndex(btnCalcular, 0);
            Controls.SetChildIndex(lblMontoTotal, 0);
            Controls.SetChildIndex(textBox1, 0);
            Controls.SetChildIndex(dtgvViajes, 0);
            Controls.SetChildIndex(label1, 0);
            Controls.SetChildIndex(dtgvMontoDestinos, 0);
            Controls.SetChildIndex(lblDestinoFavorito, 0);
            Controls.SetChildIndex(lblDestino, 0);
            ((System.ComponentModel.ISupportInitialize)dtgvViajes).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtgvMontoDestinos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblTitulo;
        private Button btnCalcular;
        private Label lblMontoTotal;
        private TextBox textBox1;
        private DataGridView dtgvViajes;
        private Label label1;
        private DataGridView dtgvMontoDestinos;
        private DataGridViewTextBoxColumn DestinoLugar;
        private DataGridViewTextBoxColumn MontoDestino;
        private DataGridViewTextBoxColumn Partida;
        private DataGridViewTextBoxColumn Destino;
        private DataGridViewTextBoxColumn FechaSalida;
        private DataGridViewTextBoxColumn FechaLlegada;
        private DataGridViewTextBoxColumn Avion;
        private DataGridViewTextBoxColumn CantAsientosPremium;
        private DataGridViewTextBoxColumn CantAsientosTurista;
        private DataGridViewTextBoxColumn CostoClasePremium;
        private DataGridViewTextBoxColumn CostoClaseTurista;
        private DataGridViewTextBoxColumn Estado;
        private DataGridViewTextBoxColumn RecaudacionTotal;
        private Label lblDestinoFavorito;
        private Label lblDestino;
    }
}