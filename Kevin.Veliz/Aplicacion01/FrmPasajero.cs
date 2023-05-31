using Entidades;

namespace Aplicacion01
{
    public partial class FrmPasajero : Form
    {
        private Pasajero pasajero;
        private List<Equipaje> equipajes;
        private string claseSeleccionada;
        private bool modifica;

        public FrmPasajero()
        {
            InitializeComponent();
            this.equipajes = new List<Equipaje>();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.btnModificar.Visible = false;
            this.btnAgregar.Visible = true;
            this.btnAgregar.Enabled = true;
            this.txtDNI.Enabled = true;
            this.modifica = false;
        }

        public FrmPasajero(Pasajero pasajero) : this()
        {
            this.pasajero = pasajero;
            this.txtDNI.Enabled = false;
            this.InicializarComponentesModificacion();
            this.btnModificar.Location = new System.Drawing.Point(this.btnAgregar.Location.X, this.btnAgregar.Location.Y);
            this.btnAgregar.Visible = false;
            this.btnAgregar.Enabled = false;
            this.modifica = true;
            this.btnModificar.Visible = true;
            this.btnLimpiar.Visible = false;
        }

        private void FrmPasajero_Load(object sender, EventArgs e)
        {
            string auxClase;

            foreach (EnumClase clase in Enum.GetValues(typeof(EnumClase)))
            {
                auxClase = clase.ToString();
                auxClase = auxClase.Replace('_', ' ');
                this.cboClase.Items.Add(auxClase);
            }

            if (modifica)
            {
                if (this.pasajero.Premium)
                {
                    this.cboClase.Text = "Premium";
                    this.cboClase.SelectedIndex = 1;
                }
                else
                {
                    this.cboClase.Text = "Turista";
                    this.cboClase.SelectedIndex = 0;
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.Text = "";
                }
                else if (control is ComboBox comboBox)
                {
                    comboBox.Text = "--Seleccione--";
                }
            }

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            bool verificar = true;
            bool premium = false;
            bool equipajeMano = chkEquipajeMano.Checked;
            int edad = 0;
            int dni = 0;

            foreach (Control control in this.Controls)
            {
                if (control is TextBox textBox)
                {
                    if (textBox.Text == "" || this.cboClase.SelectedItem is null)
                    {
                        MessageBox.Show("Complete todos los campos.");
                        verificar = false;
                        break;
                    }
                }
            }

            if (this.cboClase.SelectedItem != null)
            {
                Equipaje equipaje = new("De bodega", (double)this.nudPesoEquipaje1.Value);
                this.equipajes.Add(equipaje);
                if (this.claseSeleccionada == "Premium")
                {
                    Equipaje equipaje1 = new("De bodega", (double)this.nudPesoEquipaje2.Value);
                    this.equipajes.Add(equipaje1);
                    premium = true;
                }
            }

            if (int.TryParse(this.txtDNI.Text, out int numero) && int.TryParse(this.txtEdad.Text, out int numero1))
            {
                if (numero > 1000000 && numero1 >= 0)
                {
                    dni = numero;
                    edad = numero1;
                }
                else
                {
                    MessageBox.Show("Ingrese DNI o edad válido.");
                }
            }
            else
            {
                MessageBox.Show("Ingrese valores númericos.");
                verificar = false;
            }

            if (verificar)
            {
                this.pasajero = new Pasajero(this.txtNombre.Text, this.txtApellido.Text, dni, edad, this.equipajes, premium, equipajeMano, this.chkVacunado.Checked);
                this.DialogResult = DialogResult.OK;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void InicializarComponentesModificacion()
        {
            this.txtApellido.Text = this.pasajero.Apellido;
            this.txtNombre.Text = this.pasajero.Nombre;
            this.txtDNI.Text = this.pasajero.Dni.ToString();
            this.txtEdad.Text = this.pasajero.Edad.ToString();

            if (this.pasajero is not null && this.pasajero.Equipajes is not null)
            {
                this.nudPesoEquipaje1.Value = (decimal)this.pasajero.Equipajes[0].Peso;
            }

            if (pasajero?.Equipajes?.Count > 1)
            {
                this.nudPesoEquipaje2.Value = (decimal)this.pasajero.Equipajes[1].Peso;
            }
            else
            {
                this.nudPesoEquipaje2.Value = 1;
            }
        }

        private void cboClase_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.claseSeleccionada = cboClase.SelectedItem.ToString() ?? "";
            if (this.claseSeleccionada == "Turista")
            {
                this.nudPesoEquipaje1.Enabled = true;
                this.nudPesoEquipaje1.Maximum = 25;
                this.nudPesoEquipaje2.Enabled = false;
            }
            else if (this.claseSeleccionada == "Premium")
            {
                this.nudPesoEquipaje1.Enabled = true;
                this.nudPesoEquipaje1.Maximum = 21;
                this.nudPesoEquipaje2.Enabled = true;
                this.nudPesoEquipaje2.Maximum = 21;
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            bool verificar = true;
            foreach (Control control in this.Controls)
            {
                if (control is TextBox textBox)
                {
                    if (textBox.Text == "" || this.cboClase.SelectedItem is null)
                    {
                        MessageBox.Show("Complete todos los campos.");
                        verificar = false;
                        break;
                    }
                }
            }

            if (this.cboClase.SelectedItem != null)
            {
                Equipaje equipaje = new("De bodega", (double)this.nudPesoEquipaje1.Value);
                this.equipajes.Add(equipaje);
                if (this.claseSeleccionada == "Premium")
                {
                    Equipaje equipaje1 = new("De bodega", (double)this.nudPesoEquipaje2.Value);
                    this.equipajes.Add(equipaje1);
                    this.pasajero.Premium = true;
                }
                else
                {
                    this.pasajero.Premium = false;
                }
                this.pasajero.Equipajes = this.equipajes;
            }

            if (int.TryParse(this.txtDNI.Text, out int numero) && int.TryParse(this.txtEdad.Text, out int numero1))
            {

                this.pasajero.Dni = numero;
                this.pasajero.Edad = numero1;
            }
            else
            {
                MessageBox.Show("Ingrese valores númericos");
                verificar = false;
            }

            if (verificar)
            {
                this.pasajero.Nombre = txtNombre.Text;
                this.pasajero.Apellido = txtApellido.Text;
                this.DialogResult = DialogResult.OK;
            }
        }
        public Pasajero Pasajero
        {
            get { return this.pasajero; }
            set { this.pasajero = value; }
        }
    }
}
