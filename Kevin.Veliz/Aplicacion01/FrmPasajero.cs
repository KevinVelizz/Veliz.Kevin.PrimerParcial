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

        public FrmPasajero()
        {
            InitializeComponent();
            this.equipajes = new List<Equipaje>();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        public FrmPasajero(Pasajero pasajero) :this()
        {
            this.InicializarComponentesModificacion(pasajero);
        }

        private void FrmPasajero_Load(object sender, EventArgs e)
        {
            string auxEquipaje;
            string auxClase;
            foreach (EnumEquipaje equipaje in Enum.GetValues(typeof(EnumEquipaje)))
            {
                auxEquipaje = equipaje.ToString();
                auxEquipaje = auxEquipaje.Replace("_", " ");
                this.cboEquipaje.Items.Add(auxEquipaje);
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
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            bool verificar = true;
            bool premium = false;
            
            string equipajeSeleccionado;
            int edad = 0;
            int dni = 0;

            foreach (Control control in this.Controls)
            {
                if (control is TextBox textBox)
                {
                    if (textBox.Text == "" || this.cboEquipaje.SelectedItem is null || this.cboClase.SelectedItem is null)
                    {
                        MessageBox.Show("Complete todos los campos.");
                        verificar = false;
                        break;
                    }
                }
            }

            if (this.cboClase.SelectedItem != null && this.txtPesoEquipaje.Text != "")
            {
                equipajeSeleccionado = (string)this.cboEquipaje.SelectedItem;
                this.peso = double.Parse(this.txtPesoEquipaje.Text);
                Equipaje equipaje = new Equipaje();
                equipaje.Tipo = equipajeSeleccionado;
                equipaje.Peso = this.peso;
                this.equipajes.Add(equipaje);

                if ((string)this.cboClase.SelectedItem == "Premium")
                {
                    premium = true;
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
                this.pasajero = new Pasajero(this.txtNombre.Text, this.txtApellido.Text, dni, edad, this.equipajes, premium);
                this.DialogResult = DialogResult.OK;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public Pasajero Pasajero { get { return this.pasajero; } }


        private void InicializarComponentesModificacion(Pasajero pasajero)
        {
            this.txtApellido.Text = pasajero.Apellido;
            this.txtNombre.Text = pasajero.Nombre;
            this.txtDNI.Text = pasajero.Dni.ToString();
            this.txtEdad.Text = pasajero.Edad.ToString();
            this.txtPesoEquipaje.Text = this.peso.ToString();
        }
    }
}
