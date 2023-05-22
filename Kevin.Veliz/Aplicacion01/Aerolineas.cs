using Newtonsoft.Json;
using System.Data;
using System.IO;
using System.Text.Json.Serialization;
using Entidades;
using System.Runtime.Intrinsics.X86;
using System.Linq;

namespace Aplicacion01
{
    public partial class Aerolineas : Form
    {
        private Usuario usuario;
        private List<Pasajero> pasajeros;
        private List<Aeronave> aeronaves;
        private List<Vuelo> vuelos;
        private int index;
        private int indexItemSeleccionado;

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
            this.aeronaves = Archivos.DeserealizarAeronaves();
            this.pasajeros = Archivos.DeserealizarPasajeros();
            this.vuelos = Archivos.DeserealizarVuelos();

            IngresarUsuario ingresarUsuario = new IngresarUsuario();
            ingresarUsuario.ShowDialog();
            if (ingresarUsuario.DialogResult == DialogResult.OK)
            {
                this.usuario = ingresarUsuario.Usuario;
                this.index = 1;
                this.VisualizacionDelUsuario(this.index, this.usuario.Perfil);
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
            this.btnMostrarPasajeros.Visible = false;

            this.lblNombreSeccion.Text = "Pasajeros";
            this.index = 0;
            ModificarColor(this.index);
            this.VisualizacionDelUsuario(this.index, this.usuario.Perfil);
            this.vuelos = Archivos.DeserealizarVuelos();
            this.pasajeros = Archivos.DeserealizarPasajeros();
            this.ActualizarListaPasjeros();
        }

        private void stripVuelo_Click(object sender, EventArgs e)
        {
            this.panelModificar.Visible = true;
            this.panelInicio.Visible = false;
            this.btnMostrarPasajeros.Visible = false;

            this.btnMostrarPasajeros.Visible = true;

            this.lblNombreSeccion.Text = "Vuelos";
            this.index = 1;
            this.ModificarColor(this.index);
            this.VisualizacionDelUsuario(this.index, this.usuario.Perfil);
            this.vuelos = Archivos.DeserealizarVuelos();
            this.aeronaves = Archivos.DeserealizarAeronaves();
            foreach (Vuelo vuelo in this.vuelos)
            {
                vuelo.VueloEnCurso();
                vuelo.VueloRealizado();
                if (vuelo.AuxViaje || vuelo.AuxRealizado)
                {
                    Archivos.SerealizarVuelos(this.vuelos);
                    this.vuelos = Archivos.DeserealizarVuelos();
                }
            }
            this.ActualizarListaVuelos();
        }

        private void stripAeronave_Click(object sender, EventArgs e)
        {
            this.panelModificar.Visible = true;
            this.panelInicio.Visible = false;
            this.btnMostrarPasajeros.Visible = false;
            this.lblNombreSeccion.Text = "Aeronaves";
            this.index = 2;
            ModificarColor(this.index);
            this.VisualizacionDelUsuario(this.index, this.usuario.Perfil);
            this.aeronaves = Archivos.DeserealizarAeronaves();
            this.ActualizarListaAeronaves();
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

        private void stripVender_Click(object sender, EventArgs e)
        {
            this.panelModificar.Visible = false;
            this.panelInicio.Visible = false;
            this.index = 5;
            ModificarColor(this.index);
            FrmVenderVuelo frmVenderVuelo = new FrmVenderVuelo(this.pasajeros, this.vuelos);
            frmVenderVuelo.ShowDialog();
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
                    this.stripVender.BackColor = Color.FromArgb(153, 180, 209);

                    break;
                case 1:
                    this.stripVuelo.BackColor = Color.Aqua;
                    this.stripPasajero.BackColor = Color.FromArgb(153, 180, 209);
                    this.stripAeronave.BackColor = Color.FromArgb(153, 180, 209);
                    this.stripEstadistica.BackColor = Color.FromArgb(153, 180, 209);
                    this.stripInicio.BackColor = Color.FromArgb(153, 180, 209);
                    this.stripVender.BackColor = Color.FromArgb(153, 180, 209);
                    break;
                case 2:
                    this.stripAeronave.BackColor = Color.Aqua;
                    this.stripPasajero.BackColor = Color.FromArgb(153, 180, 209);
                    this.stripVuelo.BackColor = Color.FromArgb(153, 180, 209);
                    this.stripEstadistica.BackColor = Color.FromArgb(153, 180, 209);
                    this.stripInicio.BackColor = Color.FromArgb(153, 180, 209);
                    this.stripVender.BackColor = Color.FromArgb(153, 180, 209);
                    break;
                case 3:
                    this.stripEstadistica.BackColor = Color.Aqua;
                    this.stripPasajero.BackColor = Color.FromArgb(153, 180, 209);
                    this.stripAeronave.BackColor = Color.FromArgb(153, 180, 209);
                    this.stripVuelo.BackColor = Color.FromArgb(153, 180, 209);
                    this.stripInicio.BackColor = Color.FromArgb(153, 180, 209);
                    this.stripVender.BackColor = Color.FromArgb(153, 180, 209);
                    break;
                case 4:
                    this.stripInicio.BackColor = Color.Aqua;
                    this.stripPasajero.BackColor = Color.FromArgb(153, 180, 209);
                    this.stripAeronave.BackColor = Color.FromArgb(153, 180, 209);
                    this.stripVuelo.BackColor = Color.FromArgb(153, 180, 209);
                    this.stripEstadistica.BackColor = Color.FromArgb(153, 180, 209);
                    this.stripVender.BackColor = Color.FromArgb(153, 180, 209);
                    break;
                case 5:
                    this.stripVender.BackColor = Color.Aqua;
                    this.stripPasajero.BackColor = Color.FromArgb(153, 180, 209);
                    this.stripAeronave.BackColor = Color.FromArgb(153, 180, 209);
                    this.stripVuelo.BackColor = Color.FromArgb(153, 180, 209);
                    this.stripEstadistica.BackColor = Color.FromArgb(153, 180, 209);
                    this.stripInicio.BackColor = Color.FromArgb(153, 180, 209);
                    break;
            }
        }

        private void AgregarElementos(int index)
        {
            bool encontro = false;
            switch (index)
            {
                case 0:
                    FrmPasajero frmPasajero = new FrmPasajero(this.vuelos);
                    frmPasajero.ShowDialog();

                    if (frmPasajero.DialogResult == DialogResult.OK)
                    {
                        if (this.pasajeros.Count > 0)
                        {
                            foreach (Pasajero pasajero in this.pasajeros)
                            {
                                if (pasajero == frmPasajero.Pasajero)
                                {
                                    encontro = true;
                                    break;
                                }
                            }
                            if (encontro)
                            {
                                MessageBox.Show("Ya se encuentra el pasajero registrado.");
                            }
                            else
                            {
                                this.pasajeros.Add(frmPasajero.Pasajero);
                            }
                        }
                        else
                        {
                            this.pasajeros.Add(frmPasajero.Pasajero);
                        }

                        Archivos.SerealizarViajeros(this.pasajeros);
                        this.ActualizarListaPasjeros();
                    }
                    break;
                case 1:

                    FrmVuelo frmVuelo = new FrmVuelo(this.pasajeros, this.aeronaves);
                    frmVuelo.ShowDialog();

                    if (frmVuelo.DialogResult == DialogResult.OK)
                    {
                        this.vuelos.Add(frmVuelo.Vuelo);
                    }
                    Archivos.SerealizarVuelos(this.vuelos);
                    this.ActualizarListaVuelos();
                    break;

                case 2:
                    FrmAeronave frmAeronave = new FrmAeronave();
                    frmAeronave.ShowDialog();

                    if (frmAeronave.DialogResult == DialogResult.OK)
                    {
                        this.aeronaves.Add(frmAeronave.Aeronave);
                    }
                    Archivos.SerealizarAeronaves(this.aeronaves);
                    this.ActualizarListaAeronaves();
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
                if (index == 0)
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
                    this.stripVender.Visible = true;
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
            BorrarElemento(this.index);
        }

        private void BorrarElemento(int index)
        {
            Pasajero pasajeroElimina;
            Aeronave aeronaveElimina;
            Vuelo vueloElimina;
            this.indexItemSeleccionado = this.lstListaElementos.SelectedIndex;
            if (this.indexItemSeleccionado != -1)
            {
                switch (index)
                {
                    case 0:
                        if (this.pasajeros[this.indexItemSeleccionado].Agregado == false)
                        {
                            if (MessageBox.Show("Desea eliminar al pasajero? ", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                            {
                                this.pasajeros.RemoveAt(this.indexItemSeleccionado);
                                Archivos.SerealizarViajeros(this.pasajeros);
                                this.ActualizarListaPasjeros();
                            }
                        }
                        else
                        {
                            MessageBox.Show("El pasajero está en un vuelo, no puede ser eliminado.");
                        }
                        break;
                    case 1:
                        if (this.vuelos[this.indexItemSeleccionado].AuxRealizado == false && this.vuelos[this.indexItemSeleccionado].AuxViaje == false)
                        {
                            if (MessageBox.Show("Desea eliminar al pasajero? ", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                            {
                                this.vuelos.RemoveAt(this.indexItemSeleccionado);
                                Archivos.SerealizarVuelos(this.vuelos);
                                this.ActualizarListaVuelos();
                            }
                        }
                        break;
                }

            }
        }

        private void ModificarElemento(int index)
        {
            Pasajero pasajeroModifica;
            Aeronave aeronaveModifica;
            Vuelo vueloModifica;

            this.indexItemSeleccionado = this.lstListaElementos.SelectedIndex;
            if (this.indexItemSeleccionado != -1)
            {
                if (index == 0)
                {
                    if (this.pasajeros[this.indexItemSeleccionado].Agregado == false)
                    {
                        pasajeroModifica = this.pasajeros.ElementAt(this.indexItemSeleccionado);
                        FrmPasajero frmPasajero = new FrmPasajero(pasajeroModifica, "Modificar");
                        if (frmPasajero.ShowDialog() == DialogResult.OK)
                        {
                            this.pasajeros[this.indexItemSeleccionado] = frmPasajero.Pasajero;
                            Archivos.SerealizarViajeros(this.pasajeros);
                            this.ActualizarListaPasjeros();
                        }
                    }
                    else
                    {
                        MessageBox.Show("El pasajero está en un vuelo, no puede ser modificado.");
                    }
                }


                else if (index == 2)
                {
                    aeronaveModifica = this.aeronaves.ElementAt(this.indexItemSeleccionado);
                    if (aeronaveModifica.Disponible == true)
                    {
                        FrmAeronave frmAeronave = new FrmAeronave(aeronaveModifica, "Modificar");
                        if (frmAeronave.ShowDialog() == DialogResult.OK)
                        {
                            this.aeronaves[this.indexItemSeleccionado] = frmAeronave.Aeronave;
                            Archivos.SerealizarAeronaves(this.aeronaves);
                            this.ActualizarListaAeronaves();
                        }
                    }
                    else
                    {
                        MessageBox.Show("El avión fue agregado a un vuelo, no puede ser modificado.");
                    }
                }
            }
        }

        private void ActualizarListaPasjeros()
        {
            this.lstListaElementos.DataSource = null;
            this.lstListaElementos.DataSource = this.pasajeros;
        }
        private void ActualizarListaVuelos()
        {
            this.lstListaElementos.DataSource = null;
            this.lstListaElementos.DataSource = this.vuelos;
        }

        private void ActualizarListaAeronaves()
        {
            this.lstListaElementos.DataSource = null;
            this.lstListaElementos.DataSource = this.aeronaves;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            this.ModificarElemento(this.index);
        }

        private void buscarPasajero()
        {
            //if (int.TryParse("24", out _))
            //{
            //    this.pasajeros.FindAll(pasajeros => pasajeros.Dni.ToString().Contains());
            //}
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.StripTxtHora.Text = DateTime.Now.ToLongTimeString();
        }

        private void StripCerrarSesion_Click(object sender, EventArgs e)
        {

        }

        private void StripEstadisticaViajes_Click(object sender, EventArgs e)
        {
            FrmEstadisticaBase frmEstadisticaBase = new FrmEstadisticaBase(this.vuelos);
            frmEstadisticaBase.ShowDialog();
        }

        

        private void lstListaElementos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnMostrarPasajeros_Click(object sender, EventArgs e)
        {
            if (this.indexItemSeleccionado != -1)
            {
                MessageBox.Show(this.vuelos[this.indexItemSeleccionado].MostrarPasajeros());
            }
        }
    }
}