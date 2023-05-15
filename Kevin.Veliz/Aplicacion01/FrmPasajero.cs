using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicacion01
{
    public partial class FrmPasajero : Form
    {
        private double peso;
        private Pasajero pasajero;
        private List<Equipaje> equipajes;
        private string claseSeleccionada;
        private int pesoEquipaje1;
        private int pesoEquipaje2;
        private List<Vuelo> vuelos;
        private int indexVueloSeleccionado;

        public FrmPasajero()
        {
            InitializeComponent();
            this.equipajes = new List<Equipaje>();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.pesoEquipaje1 = 0;
            this.pesoEquipaje2 = 0;
            this.txtPesoEquipaje.Text = "0";
            this.txtPesoEquipaje2.Text = "0";
        }

        public FrmPasajero(List<Vuelo> vuelos) : this()
        {
            this.vuelos = vuelos;
        }

        public FrmPasajero(Pasajero pasajero, string accion) : this()
        {
            this.InicializarComponentesModificacion(pasajero);
            this.btnAgregar.Text = accion;
        }

        private void FrmPasajero_Load(object sender, EventArgs e)
        {
            string auxEquipaje;
            string auxClase;
            foreach (Vuelo vuelo in this.vuelos)
            {
                this.cboVuelosDisponibles.Items.Add(vuelo.Informacion());
            }

            foreach (EnumClase clase in Enum.GetValues(typeof(EnumClase)))
            {
                auxClase = clase.ToString();
                auxClase = auxClase.Replace('_', ' ');
                this.cboClase.Items.Add(auxClase);
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
            this.txtPesoEquipaje.Text = "0";
            this.txtPesoEquipaje2.Text = "0";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            bool verificar = true;
            bool premium = false;
            bool equipajeMano = chkEquipajeMano.Checked;
            string equipajeSeleccionado;
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

            if (this.cboClase.SelectedItem != null && this.txtPesoEquipaje.Text != "" && this.txtPesoEquipaje2.Text != "")
            {
                if (double.TryParse(this.txtPesoEquipaje.Text, out double peso1) && double.TryParse(this.txtPesoEquipaje2.Text, out double peso2))
                {
                    Equipaje equipaje = new Equipaje("De bodega", peso1);
                    this.equipajes.Add(equipaje);
                    if (this.claseSeleccionada == "Premium")
                    {
                        Equipaje equipaje1 = new Equipaje("De bodega", peso2);
                        equipaje1.Peso = peso2;
                        this.equipajes.Add(equipaje1);
                        premium = true;
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese un valores númericos");
                    verificar = false;
                }
            }

            if (int.TryParse(this.txtDNI.Text, out int numero) && int.TryParse(this.txtEdad.Text, out int numero1))
            {
                dni = numero;
                edad = numero1;
            }
            else
            {
                MessageBox.Show("Ingrese valores númericos");
                verificar = false;
            }

            if (verificar)
            {
                this.pasajero = new Pasajero(this.txtNombre.Text, this.txtApellido.Text, dni, edad, this.equipajes, premium, equipajeMano);
                this.DialogResult = DialogResult.OK;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public Pasajero Pasajero
        {
            get { return this.pasajero; }
            set { this.pasajero = value; }
        }

        private void InicializarComponentesModificacion(Pasajero pasajero)
        {
            this.txtApellido.Text = pasajero.Apellido;
            this.txtNombre.Text = pasajero.Nombre;
            this.txtDNI.Text = pasajero.Dni.ToString();
            this.txtEdad.Text = pasajero.Edad.ToString();
            if (pasajero.Premium)
            {
                this.cboClase.Text = "Premium";
            }
            else
            {
                this.cboClase.Text = "Turista";
            }

            this.txtPesoEquipaje.Text = pasajero.Equipajes[0].Peso.ToString();
            if (pasajero.Equipajes.Count > 1)
            {
                this.txtPesoEquipaje2.Text = pasajero.Equipajes[1].Peso.ToString();
            }
            else
            {
                this.txtPesoEquipaje2.Text = "0";
            }
        }

        private void cboClase_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.claseSeleccionada = cboClase.SelectedItem.ToString();

            if (this.claseSeleccionada == "Turista")
            {
                this.txtPesoEquipaje.Enabled = true;
                this.txtPesoEquipaje2.Enabled = false;
            }
            else if (this.claseSeleccionada == "Premium")
            {
                this.txtPesoEquipaje.Enabled = true;
                this.txtPesoEquipaje2.Enabled = true;
            }
        }

        private void FrmPasajero_Click(object sender, EventArgs e)
        {

        }

        private void cboVuelosDisponibles_Click(object sender, EventArgs e)
        {
            
        }

        private void cboVuelosDisponibles_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.indexVueloSeleccionado = cboVuelosDisponibles.SelectedIndex;
            this.lblInformacion.Visible = true;
            this.lblInformacion.Text = this.vuelos[this.indexVueloSeleccionado].Avion.ToString();



        }
    }
}
