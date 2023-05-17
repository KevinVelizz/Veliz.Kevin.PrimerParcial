namespace Aplicacion01
{
    partial class FrmEstadisticaBase
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
            ((System.ComponentModel.ISupportInitialize)dtgvViajes).BeginInit();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(679, 400);
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(583, 400);
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI Symbol", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            lblTitulo.Location = new Point(12, 59);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(109, 17);
            lblTitulo.TabIndex = 5;
            lblTitulo.Text = "Viajes Realizados";
            // 
            // btnCalcular
            // 
            btnCalcular.Font = new Font("Segoe UI Symbol", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            btnCalcular.Location = new Point(626, 183);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 6;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // lblMontoTotal
            // 
            lblMontoTotal.AutoSize = true;
            lblMontoTotal.Location = new Point(487, 83);
            lblMontoTotal.Name = "lblMontoTotal";
            lblMontoTotal.Size = new Size(108, 15);
            lblMontoTotal.TabIndex = 7;
            lblMontoTotal.Text = "Monto Recaudado:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(601, 75);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 8;
            // 
            // dtgvViajes
            // 
            dtgvViajes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvViajes.Columns.AddRange(new DataGridViewColumn[] { Partida, Destino, FechaSalida });
            dtgvViajes.Location = new Point(12, 94);
            dtgvViajes.Name = "dtgvViajes";
            dtgvViajes.RowTemplate.Height = 25;
            dtgvViajes.Size = new Size(440, 239);
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
            // FrmEstadisticaBase
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dtgvViajes);
            Controls.Add(textBox1);
            Controls.Add(lblMontoTotal);
            Controls.Add(btnCalcular);
            Controls.Add(lblTitulo);
            Name = "FrmEstadisticaBase";
            Text = "FrmEstadisticaBase";
            Load += FrmEstadisticaBase_Load;
            Controls.SetChildIndex(btnCancelar, 0);
            Controls.SetChildIndex(btnLimpiar, 0);
            Controls.SetChildIndex(lblTitulo, 0);
            Controls.SetChildIndex(btnCalcular, 0);
            Controls.SetChildIndex(lblMontoTotal, 0);
            Controls.SetChildIndex(textBox1, 0);
            Controls.SetChildIndex(dtgvViajes, 0);
            ((System.ComponentModel.ISupportInitialize)dtgvViajes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblTitulo;
        private Button btnCalcular;
        private Label lblMontoTotal;
        private TextBox textBox1;
        private DataGridView dtgvViajes;
        private DataGridViewTextBoxColumn Partida;
        private DataGridViewTextBoxColumn Destino;
        private DataGridViewTextBoxColumn FechaSalida;
    }
}