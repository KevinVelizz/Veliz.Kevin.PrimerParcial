using Entidades;

namespace Aplicacion01
{
    public partial class FrmAeronave : FrmBase
    {
        private Aeronave aeronave;
        private int cantidadBanios = 0;
        private int cantidadAsientos = 0;
        private double capacidadBodegas = 0;

        public FrmAeronave()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.btnAgregar1.Visible = true;
            this.btnModificar1.Visible = false;
        }

        public FrmAeronave(Aeronave aeronave) : this()
        {
            this.aeronave = aeronave;
            this.InicializarComponentesModificacion(aeronave);
            this.btnAgregar1.Visible = false;
            this.btnModificar1.Visible = true;
            this.txtMatricula.Enabled = false;
            this.btnLimpiar.Visible = false;
            this.btnModificar1.Location = new System.Drawing.Point(this.btnAgregar1.Location.X, this.btnAgregar1.Location.Y);
        }

        private void FrmAeronave_Load(object sender, EventArgs e)
        {
            //this.MinimumSize = new System.Drawing.Size()
        }

        private bool ValidarComponentes()
        {
            bool verificar = true;
            foreach (Control control in this.Controls)
            {
                if (control is TextBox textBox)
                {
                    if (textBox.Text == "")
                    {
                        MessageBox.Show("Complete todos los campos");
                        verificar = false;
                        break;
                    }
                }
            }

            if (int.TryParse(this.txtCantAsientos.Text, out int numero) && int.TryParse(this.txtCantBanios.Text, out int numero1) && double.TryParse(this.txtCapacidadBodega.Text, out double numero2))
            {
                this.cantidadAsientos = numero;
                this.cantidadBanios = numero1;
                this.capacidadBodegas = numero2;
            }
            else
            {
                MessageBox.Show("Ingrese valores númericos.");
                verificar = false;
            }
            return verificar;
        }


        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.Text = "";
                }
                else if (control is CheckBox checkBox)
                {
                    checkBox.Checked = false;
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void InicializarComponentesModificacion(Aeronave aeronave)
        {
            this.txtMatricula.Text = aeronave.Matricula;
            this.txtCantAsientos.Text = aeronave.CantidadAsientos.ToString();
            this.txtCantBanios.Text = aeronave.CantidadDeBanios.ToString();
            this.txtCapacidadBodega.Text = aeronave.CapacidadBodega.ToString();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar1_Click(object sender, EventArgs e)
        {
            if (this.ValidarComponentes())
            {
                this.aeronave = new Aeronave(this.txtMatricula.Text, cantidadAsientos, cantidadBanios, this.chkInternet.Checked, this.chkComida.Checked, capacidadBodegas);
                this.cerrar = true;
                this.DialogResult = DialogResult.OK;
            }
        }

        private void btnModificar1_Click(object sender, EventArgs e)
        {

            if (this.ValidarComponentes())
            {
                this.aeronave.CapacidadBodega = this.capacidadBodegas;
                this.aeronave.CantidadDeBanios = this.cantidadBanios;
                this.aeronave.CantidadAsientos = this.cantidadAsientos;
                this.aeronave.ServicioComida = this.chkComida.Checked;
                this.aeronave.ServicioInternet = this.chkInternet.Checked;
                this.cerrar = true;
                this.DialogResult = DialogResult.OK;
            }
        }

        public Aeronave Aeronave
        {
            get { return this.aeronave; }
            set { this.aeronave = value; }
        }
    }
}
