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

        private Pasajero pasajero;
        private Dictionary<string,double> equipaje;

        public FrmPasajero()
        {
            InitializeComponent();
            this.equipaje = new Dictionary<string,double>();
            this.StartPosition = FormStartPosition.CenterScreen;
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
            double peso;
            string equipajeSeleccionado;

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
                peso = double.Parse(this.txtPesoEquipaje.Text);
                this.equipaje.Add(equipajeSeleccionado, peso);
            }

            if (verificar)
            {
                this.pasajero = new Pasajero(this.txtNombre.Text,this.txtApellido.Text,this.txtDNI.Text,this.txtEdad.Text,this.equipaje,false);
                this.DialogResult = DialogResult.OK;
            }
        }
        public Pasajero Pasajero { get { return this.pasajero;} }
    }
}
