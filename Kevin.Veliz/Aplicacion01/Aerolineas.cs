using Newtonsoft.Json;
using System.Data;
using System.IO;
using System.Text.Json.Serialization;
using Entidades;

namespace Aplicacion01
{
    public partial class Aerolineas : Form
    {
        private Usuario usuario;
        private List<Pasajero> pasajeros;
        private List<Aeronave> aeronaves;
        private List<Vuelo> vuelos;
        private int index;

        public Aerolineas()
        {
            InitializeComponent();
            this.pasajeros = new List<Pasajero>();
            this.aeronaves = new List<Aeronave>();
            this.vuelos = new List<Vuelo>();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.panelModificar.Dock = DockStyle.Fill;
        }

        private void Aerolineas_Load(object sender, EventArgs e)
        {
            IngresarUsuario ingresarUsuario = new IngresarUsuario();
            ingresarUsuario.ShowDialog();
            if (ingresarUsuario.DialogResult == DialogResult.OK)
            {
                this.usuario = ingresarUsuario.Usuario;
                if (this.usuario.Perfil == "administrador" || this.usuario.Perfil == "supervisor")
                {
                    this.stripVuelo.Visible = false;
                    this.stripVuelo.Enabled = false;

                }
                else if (this.usuario.Perfil == "vendedor")
                {
                    this.stripVuelo.Visible = true;
                    this.stripVuelo.Enabled = true;
                }
            }
            else
            {
                this.Close();
            }
        }

        private void stripPasajero_Click(object sender, EventArgs e)
        {
            this.panelModificar.Visible = true;
            this.lblNombreSeccion.Text = "Pasajeros";
            this.index = 0;
            ModificarColor(this.index);
        }

        private void stripVuelo_Click(object sender, EventArgs e)
        {
            this.panelModificar.Visible = true;
            this.lblNombreSeccion.Text = "Vuelos";
            this.index = 1;
            this.ModificarColor(this.index);
        }

        private void stripAeronave_Click(object sender, EventArgs e)
        {
            this.panelModificar.Visible = true;
            this.lblNombreSeccion.Text = "Aeronaves";
            this.index = 2;
            ModificarColor(this.index);
        }

        private void stripEstadistica_Click(object sender, EventArgs e)
        {
            this.panelModificar.Visible = false;
            this.index = 3;
            ModificarColor(this.index);
        }

        private void stripInicio_Click(object sender, EventArgs e)
        {
            this.panelModificar.Visible = false;
            this.index = 4;
            ModificarColor(this.index);
        }

        private void ModificarColor(int index)
        {
            switch (index)
            {
                case 0:
                    this.stripPasajero.BackColor = Color.Aqua;
                    this.stripVuelo.BackColor = Color.FromArgb(153, 180, 209);
                    this.stripAeronave.BackColor = Color.FromArgb(153, 180, 209);
                    this.stripEstadistica.BackColor = Color.FromArgb(153, 180, 209);
                    this.stripInicio.BackColor = Color.FromArgb(153, 180, 209);
                    break;
                case 1:
                    this.stripVuelo.BackColor = Color.Aqua;
                    this.stripPasajero.BackColor = Color.FromArgb(153, 180, 209);
                    this.stripAeronave.BackColor = Color.FromArgb(153, 180, 209);
                    this.stripEstadistica.BackColor = Color.FromArgb(153, 180, 209);
                    this.stripInicio.BackColor = Color.FromArgb(153, 180, 209);
                    break;
                case 2:
                    this.stripAeronave.BackColor = Color.Aqua;
                    this.stripPasajero.BackColor = Color.FromArgb(153, 180, 209);
                    this.stripVuelo.BackColor = Color.FromArgb(153, 180, 209);
                    this.stripEstadistica.BackColor = Color.FromArgb(153, 180, 209);
                    this.stripInicio.BackColor = Color.FromArgb(153, 180, 209);
                    break;
                case 3:
                    this.stripEstadistica.BackColor = Color.Aqua;
                    this.stripPasajero.BackColor = Color.FromArgb(153, 180, 209);
                    this.stripAeronave.BackColor = Color.FromArgb(153, 180, 209);
                    this.stripVuelo.BackColor = Color.FromArgb(153, 180, 209);
                    this.stripInicio.BackColor = Color.FromArgb(153, 180, 209);
                    break;
                case 4:
                    this.stripInicio.BackColor = Color.Aqua;
                    this.stripPasajero.BackColor = Color.FromArgb(153, 180, 209);
                    this.stripAeronave.BackColor = Color.FromArgb(153, 180, 209);
                    this.stripVuelo.BackColor = Color.FromArgb(153, 180, 209);
                    this.stripEstadistica.BackColor = Color.FromArgb(153, 180, 209);
                    break;
            }
        }


        private void AgregarElementos(int index)
        {
            switch (index)
            {
                case 0:
                    FrmPasajero frmPasajero = new FrmPasajero();
                    frmPasajero.ShowDialog();

                    if (frmPasajero.DialogResult == DialogResult.OK)
                    {
                        this.pasajeros.Add(frmPasajero.Pasajero);

                        foreach (Pasajero pasajero in this.pasajeros)
                        {
                            MessageBox.Show(pasajero.ToString());
                        }
                    }
                    break;
                case 1:
                    break;

                case 2:
                    FrmAeronave frmAeronave = new FrmAeronave();
                    frmAeronave.ShowDialog();

                    if (frmAeronave.DialogResult == DialogResult.OK)
                    {
                        this.aeronaves.Add(frmAeronave.Aeronave);

                        foreach (Aeronave aeronave in this.aeronaves)
                        {
                            MessageBox.Show(aeronave.Matricula);
                        }
                    }
                    break;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            this.AgregarElementos(this.index);
        }

        private void Lista_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //private void ActualizarListaSupermercado()
        //{
        //    lstObjetos.DataSource = null;
        //    lstObjetos.DataSource = listaSupermercado;
        //}
    }
}