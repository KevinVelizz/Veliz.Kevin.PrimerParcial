using Entidades;
using Newtonsoft.Json.Linq;
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
    public partial class FrmAeronave : Form
    {

        private Aeronave aeronave;

        public FrmAeronave()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        public FrmAeronave(Aeronave aeronave, string accion):this()
        {
            this.InicializarComponentesModificacion(aeronave);
            this.btnAgregar.Text = accion;
        }

        private void FrmAeronave_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int cantidadBanios = 0;
            int cantidadAsientos = 0;
            double capacidadBodegas = 0;
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
                cantidadAsientos = numero;
                cantidadBanios = numero1;
                capacidadBodegas = numero2;
            }
            else
            {
                MessageBox.Show("Ingrese valores númericos.");
                verificar = false;
            }

            if (verificar)
            {
                this.aeronave = new Aeronave(this.txtMatricula.Text, cantidadAsientos, cantidadBanios, this.chkInternet.Checked, this.chkComida.Checked, capacidadBodegas);
                this.DialogResult = DialogResult.OK;
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

        public Aeronave Aeronave 
        { 
            get { return this.aeronave; } 
            set { this.aeronave = value; }
        }
    }
}
