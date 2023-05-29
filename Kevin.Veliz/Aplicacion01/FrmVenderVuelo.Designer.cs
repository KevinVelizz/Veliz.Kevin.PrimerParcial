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
            chkComida = new CheckBox();
            chkInternet = new CheckBox();
            lblInfoAvion = new Label();
            btnVender = new Button();
            label1 = new Label();
            label2 = new Label();
            lblCosto = new Label();
            txtCostoBruto = new TextBox();
            txtCostoNeto = new TextBox();
            lblCostoNeto = new Label();
            dtgvPasajerosDisponibles = new DataGridView();
            dtgvVuelosDisponibles = new DataGridView();
            btnBuscarVuelo = new Button();
            lblDniBuscar = new Label();
            lblApellidoBuscar = new Label();
            lblNombreBuscar = new Label();
            txtBuscarDNI = new TextBox();
            txtBuscarApellido = new TextBox();
            btnBuscar = new Button();
            txtBuscarNombre = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dtgvPasajerosDisponibles).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtgvVuelosDisponibles).BeginInit();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.None;
            btnCancelar.Location = new Point(839, 486);
            // 
            // btnLimpiar
            // 
            btnLimpiar.Anchor = AnchorStyles.None;
            btnLimpiar.Font = new Font("Segoe UI Symbol", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            btnLimpiar.Location = new Point(749, 486);
            // 
            // chkComida
            // 
            chkComida.Anchor = AnchorStyles.None;
            chkComida.AutoSize = true;
            chkComida.Font = new Font("Segoe UI Symbol", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            chkComida.Location = new Point(711, 40);
            chkComida.Name = "chkComida";
            chkComida.Size = new Size(72, 21);
            chkComida.TabIndex = 3;
            chkComida.Text = "Comida";
            chkComida.UseVisualStyleBackColor = true;
            chkComida.CheckedChanged += chkComida_CheckedChanged;
            // 
            // chkInternet
            // 
            chkInternet.Anchor = AnchorStyles.None;
            chkInternet.AutoSize = true;
            chkInternet.Font = new Font("Segoe UI Symbol", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            chkInternet.Location = new Point(789, 40);
            chkInternet.Name = "chkInternet";
            chkInternet.Size = new Size(71, 21);
            chkInternet.TabIndex = 4;
            chkInternet.Text = "Internet";
            chkInternet.UseVisualStyleBackColor = true;
            chkInternet.CheckedChanged += chkInternet_CheckedChanged;
            // 
            // lblInfoAvion
            // 
            lblInfoAvion.Anchor = AnchorStyles.None;
            lblInfoAvion.AutoSize = true;
            lblInfoAvion.Font = new Font("Segoe UI Symbol", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            lblInfoAvion.Location = new Point(469, 260);
            lblInfoAvion.Name = "lblInfoAvion";
            lblInfoAvion.Size = new Size(43, 17);
            lblInfoAvion.TabIndex = 5;
            lblInfoAvion.Text = "label1";
            lblInfoAvion.Visible = false;
            // 
            // btnVender
            // 
            btnVender.Anchor = AnchorStyles.None;
            btnVender.Font = new Font("Segoe UI Symbol", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            btnVender.Location = new Point(662, 486);
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
            label1.Location = new Point(12, 50);
            label1.Name = "label1";
            label1.Size = new Size(67, 17);
            label1.TabIndex = 7;
            label1.Text = "Pasajeros:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Symbol", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(496, 47);
            label2.Name = "label2";
            label2.Size = new Size(121, 17);
            label2.TabIndex = 8;
            label2.Text = "Vuelos disponibles:";
            // 
            // lblCosto
            // 
            lblCosto.Anchor = AnchorStyles.None;
            lblCosto.AutoSize = true;
            lblCosto.Font = new Font("Segoe UI Symbol", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            lblCosto.Location = new Point(711, 315);
            lblCosto.Name = "lblCosto";
            lblCosto.Size = new Size(85, 17);
            lblCosto.TabIndex = 9;
            lblCosto.Text = "Costo bruto: ";
            // 
            // txtCostoBruto
            // 
            txtCostoBruto.Anchor = AnchorStyles.None;
            txtCostoBruto.Enabled = false;
            txtCostoBruto.Font = new Font("Segoe UI Symbol", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            txtCostoBruto.Location = new Point(802, 307);
            txtCostoBruto.Name = "txtCostoBruto";
            txtCostoBruto.Size = new Size(112, 25);
            txtCostoBruto.TabIndex = 10;
            // 
            // txtCostoNeto
            // 
            txtCostoNeto.Anchor = AnchorStyles.None;
            txtCostoNeto.Enabled = false;
            txtCostoNeto.Font = new Font("Segoe UI Symbol", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            txtCostoNeto.Location = new Point(802, 361);
            txtCostoNeto.Name = "txtCostoNeto";
            txtCostoNeto.Size = new Size(112, 25);
            txtCostoNeto.TabIndex = 11;
            // 
            // lblCostoNeto
            // 
            lblCostoNeto.Anchor = AnchorStyles.None;
            lblCostoNeto.AutoSize = true;
            lblCostoNeto.Font = new Font("Segoe UI Symbol", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            lblCostoNeto.Location = new Point(711, 369);
            lblCostoNeto.Name = "lblCostoNeto";
            lblCostoNeto.Size = new Size(79, 17);
            lblCostoNeto.TabIndex = 12;
            lblCostoNeto.Text = "Costo neto: ";
            // 
            // dtgvPasajerosDisponibles
            // 
            dtgvPasajerosDisponibles.Anchor = AnchorStyles.None;
            dtgvPasajerosDisponibles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvPasajerosDisponibles.Location = new Point(12, 73);
            dtgvPasajerosDisponibles.MultiSelect = false;
            dtgvPasajerosDisponibles.Name = "dtgvPasajerosDisponibles";
            dtgvPasajerosDisponibles.ReadOnly = true;
            dtgvPasajerosDisponibles.RowTemplate.Height = 25;
            dtgvPasajerosDisponibles.Size = new Size(469, 178);
            dtgvPasajerosDisponibles.TabIndex = 13;
            dtgvPasajerosDisponibles.CellClick += dtgvPasajerosDisponibles_CellClick;
            // 
            // dtgvVuelosDisponibles
            // 
            dtgvVuelosDisponibles.Anchor = AnchorStyles.None;
            dtgvVuelosDisponibles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvVuelosDisponibles.Location = new Point(496, 67);
            dtgvVuelosDisponibles.MultiSelect = false;
            dtgvVuelosDisponibles.Name = "dtgvVuelosDisponibles";
            dtgvVuelosDisponibles.ReadOnly = true;
            dtgvVuelosDisponibles.RowTemplate.Height = 25;
            dtgvVuelosDisponibles.Size = new Size(445, 184);
            dtgvVuelosDisponibles.TabIndex = 14;
            dtgvVuelosDisponibles.CellClick += dtgvVuelosDisponibles_CellClick;
            // 
            // btnBuscarVuelo
            // 
            btnBuscarVuelo.Anchor = AnchorStyles.None;
            btnBuscarVuelo.Font = new Font("Segoe UI Symbol", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            btnBuscarVuelo.Location = new Point(866, 38);
            btnBuscarVuelo.Name = "btnBuscarVuelo";
            btnBuscarVuelo.Size = new Size(75, 23);
            btnBuscarVuelo.TabIndex = 15;
            btnBuscarVuelo.Text = "Buscar";
            btnBuscarVuelo.UseVisualStyleBackColor = true;
            btnBuscarVuelo.Click += btnBuscarVuelo_Click;
            // 
            // lblDniBuscar
            // 
            lblDniBuscar.AutoSize = true;
            lblDniBuscar.Font = new Font("Segoe UI Symbol", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            lblDniBuscar.Location = new Point(324, 21);
            lblDniBuscar.Name = "lblDniBuscar";
            lblDniBuscar.Size = new Size(38, 20);
            lblDniBuscar.TabIndex = 22;
            lblDniBuscar.Text = "DNI:";
            // 
            // lblApellidoBuscar
            // 
            lblApellidoBuscar.AutoSize = true;
            lblApellidoBuscar.Font = new Font("Segoe UI Symbol", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            lblApellidoBuscar.Location = new Point(206, 21);
            lblApellidoBuscar.Name = "lblApellidoBuscar";
            lblApellidoBuscar.Size = new Size(69, 20);
            lblApellidoBuscar.TabIndex = 21;
            lblApellidoBuscar.Text = "Apellido:";
            // 
            // lblNombreBuscar
            // 
            lblNombreBuscar.AutoSize = true;
            lblNombreBuscar.Font = new Font("Segoe UI Symbol", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            lblNombreBuscar.Location = new Point(102, 21);
            lblNombreBuscar.Name = "lblNombreBuscar";
            lblNombreBuscar.Size = new Size(67, 20);
            lblNombreBuscar.TabIndex = 20;
            lblNombreBuscar.Text = "Nombre:";
            // 
            // txtBuscarDNI
            // 
            txtBuscarDNI.Location = new Point(295, 44);
            txtBuscarDNI.Name = "txtBuscarDNI";
            txtBuscarDNI.Size = new Size(100, 23);
            txtBuscarDNI.TabIndex = 19;
            // 
            // txtBuscarApellido
            // 
            txtBuscarApellido.Location = new Point(192, 44);
            txtBuscarApellido.Name = "txtBuscarApellido";
            txtBuscarApellido.Size = new Size(100, 23);
            txtBuscarApellido.TabIndex = 18;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(401, 42);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(80, 25);
            btnBuscar.TabIndex = 17;
            btnBuscar.Text = "Filtrar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtBuscarNombre
            // 
            txtBuscarNombre.Location = new Point(86, 44);
            txtBuscarNombre.Name = "txtBuscarNombre";
            txtBuscarNombre.Size = new Size(100, 23);
            txtBuscarNombre.TabIndex = 16;
            // 
            // FrmVenderVuelo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(953, 535);
            Controls.Add(lblDniBuscar);
            Controls.Add(lblApellidoBuscar);
            Controls.Add(lblNombreBuscar);
            Controls.Add(txtBuscarDNI);
            Controls.Add(txtBuscarApellido);
            Controls.Add(btnBuscar);
            Controls.Add(txtBuscarNombre);
            Controls.Add(btnBuscarVuelo);
            Controls.Add(dtgvVuelosDisponibles);
            Controls.Add(dtgvPasajerosDisponibles);
            Controls.Add(lblCostoNeto);
            Controls.Add(txtCostoNeto);
            Controls.Add(txtCostoBruto);
            Controls.Add(lblCosto);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnVender);
            Controls.Add(lblInfoAvion);
            Controls.Add(chkInternet);
            Controls.Add(chkComida);
            Name = "FrmVenderVuelo";
            Text = "FrmVenderVuelo";
            Load += FrmVenderVuelo_Load;
            Controls.SetChildIndex(btnLimpiar, 0);
            Controls.SetChildIndex(chkComida, 0);
            Controls.SetChildIndex(chkInternet, 0);
            Controls.SetChildIndex(lblInfoAvion, 0);
            Controls.SetChildIndex(btnVender, 0);
            Controls.SetChildIndex(btnCancelar, 0);
            Controls.SetChildIndex(label1, 0);
            Controls.SetChildIndex(label2, 0);
            Controls.SetChildIndex(lblCosto, 0);
            Controls.SetChildIndex(txtCostoBruto, 0);
            Controls.SetChildIndex(txtCostoNeto, 0);
            Controls.SetChildIndex(lblCostoNeto, 0);
            Controls.SetChildIndex(dtgvPasajerosDisponibles, 0);
            Controls.SetChildIndex(dtgvVuelosDisponibles, 0);
            Controls.SetChildIndex(btnBuscarVuelo, 0);
            Controls.SetChildIndex(txtBuscarNombre, 0);
            Controls.SetChildIndex(btnBuscar, 0);
            Controls.SetChildIndex(txtBuscarApellido, 0);
            Controls.SetChildIndex(txtBuscarDNI, 0);
            Controls.SetChildIndex(lblNombreBuscar, 0);
            Controls.SetChildIndex(lblApellidoBuscar, 0);
            Controls.SetChildIndex(lblDniBuscar, 0);
            ((System.ComponentModel.ISupportInitialize)dtgvPasajerosDisponibles).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtgvVuelosDisponibles).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private CheckBox chkComida;
        private CheckBox chkInternet;
        private Label lblInfoAvion;
        private Button btnVender;
        private Label label1;
        private Label label2;
        private Label lblCosto;
        private TextBox txtCostoBruto;
        private TextBox txtCostoNeto;
        private Label lblCostoNeto;
        private DataGridView dtgvPasajerosDisponibles;
        private DataGridView dtgvVuelosDisponibles;
        private Button btnBuscarVuelo;
        private Label lblDniBuscar;
        private Label lblApellidoBuscar;
        private Label lblNombreBuscar;
        private TextBox txtBuscarDNI;
        private TextBox txtBuscarApellido;
        private Button btnBuscar;
        private TextBox txtBuscarNombre;
    }
}