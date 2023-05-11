using Newtonsoft.Json;
using System.Data;
using System.IO;
using System.Text.Json.Serialization;
using Entidades;
using System.Runtime.Intrinsics.X86;

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
            this.panelInicio.Dock = DockStyle.Fill;
        }

        private void Aerolineas_Load(object sender, EventArgs e)
        {

            this.pasajeros = Archivos.DeserealizarPasajeros();
            this.aeronaves = Archivos.DeserealizarAeronaves();

            IngresarUsuario ingresarUsuario = new IngresarUsuario();
            ingresarUsuario.ShowDialog();
            if (ingresarUsuario.DialogResult == DialogResult.OK)
            {
                this.usuario = ingresarUsuario.Usuario;
                if (this.usuario.Perfil == "administrador")
                {
                    this.index = 1;
                    this.VisualizacionDelUsuario(this.index, this.usuario.Perfil);
                }
                else if (this.usuario.Perfil == "supervisor")
                {
                    this.index = 1;
                    this.VisualizacionDelUsuario(this.index, this.usuario.Perfil);
                }
                else if (this.usuario.Perfil == "vendedor")
                {
                    this.index = 1;
                    this.VisualizacionDelUsuario(this.index, this.usuario.Perfil);
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
            this.panelInicio.Visible = false;
            this.lblNombreSeccion.Text = "Pasajeros";
            this.index = 0;
            ModificarColor(this.index);
            this.VisualizacionDelUsuario(this.index, this.usuario.Perfil);
        }

        private void stripVuelo_Click(object sender, EventArgs e)
        {
            this.panelModificar.Visible = true;
            this.panelInicio.Visible = false;
            this.lblNombreSeccion.Text = "Vuelos";
            this.index = 1;
            this.ModificarColor(this.index);
            this.VisualizacionDelUsuario(this.index, this.usuario.Perfil);
        }

        private void stripAeronave_Click(object sender, EventArgs e)
        {
            this.panelModificar.Visible = true;
            this.panelInicio.Visible = false;
            this.lblNombreSeccion.Text = "Aeronaves";
            this.index = 2;
            ModificarColor(this.index);
        }

        private void stripEstadistica_Click(object sender, EventArgs e)
        {
            this.panelModificar.Visible = false;
            this.panelInicio.Visible = false;
            this.index = 3;
            ModificarColor(this.index);
            this.VisualizacionDelUsuario(this.index, this.usuario.Perfil);
        }

        private void stripInicio_Click(object sender, EventArgs e)
        {
            this.panelModificar.Visible = false;
            this.panelInicio.Visible = true;
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
                        foreach (Pasajero pasajero in this.pasajeros)
                        {
                            if (pasajero != frmPasajero.Pasajero)
                            {
                                this.pasajeros.Add(frmPasajero.Pasajero);
                            }
                        }
                        Archivos.SerealizarViajeros(this.pasajeros);
                        this.ActualizarListaPasjeros();

                    }
                    break;
                case 1:
                    FrmVuelo vuelo = new FrmVuelo();
                    vuelo.ShowDialog();
                    break;
                case 2:
                    FrmAeronave frmAeronave = new FrmAeronave();
                    frmAeronave.ShowDialog();

                    if (frmAeronave.DialogResult == DialogResult.OK)
                    {
                        this.aeronaves.Add(frmAeronave.Aeronave);
                    }
                    break;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            this.AgregarElementos(this.index);
        }

        private void VisualizacionDelUsuario(int index, string perfil)
        {
            if ("administrador" == perfil)
            {
                if (index == 1 || index == 0)
                {
                    this.btnAgregar.Visible = false;
                    this.btnEliminar.Visible = false;
                    this.btnModificar.Visible = false;
                }
                else
                {
                    this.btnAgregar.Visible = true;
                    this.btnEliminar.Visible = true;
                    this.btnModificar.Visible = true;
                }
                this.stripEstadistica.Visible = false;
            }
            else if ("vendedor" == perfil)
            {
                if (index == 1 || index == 2)
                {
                    this.btnAgregar.Visible = false;
                    this.btnEliminar.Visible = false;
                    this.btnModificar.Visible = false;
                }
                else
                {
                    this.btnAgregar.Visible = true;
                    this.btnEliminar.Visible = true;
                    this.btnModificar.Visible = true;
                }
                this.stripAeronave.Visible = false;
            }
            else if ("supervisor" == perfil)
            {
                if (index == 1)
                {
                    this.btnAgregar.Visible = false;
                    this.btnEliminar.Visible = false;
                    this.btnModificar.Visible = false;
                }
                else
                {
                    this.btnAgregar.Visible = true;
                    this.btnEliminar.Visible = true;
                    this.btnModificar.Visible = true;
                }
                this.stripAeronave.Visible = false;
                this.stripVuelo.Visible = false;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void ModificarElemento(int index)
        {
            int indexItemSeleccionado;
            Pasajero modifica;
            indexItemSeleccionado = this.lstListaElementos.SelectedIndex;
            if (indexItemSeleccionado != -1)
            {
                modifica = pasajeros.ElementAt(indexItemSeleccionado);
                FrmPasajero frmPasajero = new FrmPasajero(modifica); 

                if (frmPasajero.ShowDialog() == DialogResult.OK)
                {
                    this.pasajeros[indexItemSeleccionado] = frmPasajero.Pasajero;
                    Archivos.SerealizarViajeros(this.pasajeros);
                    this.ActualizarListaPasjeros();
                }
            }
        }

        private void ActualizarListaPasjeros()
        {
            this.lstListaElementos.DataSource = null;
            this.lstListaElementos.DataSource = this.pasajeros;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

        }
    }
}