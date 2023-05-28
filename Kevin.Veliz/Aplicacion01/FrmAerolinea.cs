using Entidades;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Aplicacion01
{
    public partial class FrmAerolinea : Form
    {
        private Usuario? usuario;
        private List<Pasajero> pasajeros;
        private List<Aeronave> aeronaves;
        private List<Vuelo> vuelos;
        private int index;
        private int indexItemSeleccionado;
        Pasajero? pasajeroSeleccionado;
        Aeronave? aeronaveSeleccionado;
        Vuelo? vueloSeleccionado;

        public FrmAerolinea()
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
            this.StripNombreOperador.Enabled = false;

            IngresarUsuario ingresarUsuario = new IngresarUsuario();
            ingresarUsuario.ShowDialog();
            if (ingresarUsuario.DialogResult == DialogResult.OK)
            {
                this.usuario = ingresarUsuario.Usuario;
                this.index = 1;
                this.VisualizacionDelUsuario(this.index, this.usuario.Perfil);
                this.StripNombreOperador.Text = ingresarUsuario.Usuario.Nombre;
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

            this.lblApellidoBuscar.Visible = true;
            this.lblNombreBuscar.Visible = true;
            this.lblDniBuscar.Visible = true;

            this.txtBuscarNombre.Visible = true;
            this.txtBuscarApellido.Visible = true;
            this.txtBuscarDNI.Visible = true;
            this.btnBuscar.Visible = true;

            this.lblNombreSeccion.Text = "Pasajeros";
            this.index = 0;
            ModificarColor(this.index);
            this.VisualizacionDelUsuario(this.index, this.usuario.Perfil);
            this.vuelos = Archivos.DeserealizarVuelos();
            this.pasajeros = Archivos.DeserealizarPasajeros();
            this.ActualizarLista(this.pasajeros);
        }

        private void stripVuelo_Click(object sender, EventArgs e)
        {
            this.panelModificar.Visible = true;
            this.panelInicio.Visible = false;
            this.btnMostrarPasajeros.Visible = false;

            this.lblApellidoBuscar.Visible = false;
            this.lblNombreBuscar.Visible = false;
            this.lblDniBuscar.Visible = false;

            this.txtBuscarNombre.Visible = false;
            this.txtBuscarApellido.Visible = false;
            this.txtBuscarDNI.Visible = false;
            this.btnBuscar.Visible = false;

            this.btnMostrarPasajeros.Visible = true;

            this.lblNombreSeccion.Text = "Vuelos";
            this.index = 1;
            this.ModificarColor(this.index);
            this.VisualizacionDelUsuario(this.index, this.usuario.Perfil);
            this.pasajeros = Archivos.DeserealizarPasajeros();
            this.aeronaves = Archivos.DeserealizarAeronaves();
            foreach (Vuelo vuelo in this.vuelos)
            {
                vuelo.VueloEnCurso();
                vuelo.VueloRealizado();
                if (vuelo.EnViaje || vuelo.Realizado)
                {
                    Archivos.SerealizarVuelos(this.vuelos);
                }
            }
            this.vuelos = Archivos.DeserealizarVuelos();
            this.ActualizarLista(this.vuelos);
        }

        private void stripAeronave_Click(object sender, EventArgs e)
        {
            this.panelModificar.Visible = true;
            this.panelInicio.Visible = false;
            this.btnMostrarPasajeros.Visible = false;

            this.lblApellidoBuscar.Visible = false;
            this.lblNombreBuscar.Visible = false;
            this.lblDniBuscar.Visible = false;

            this.txtBuscarNombre.Visible = false;
            this.txtBuscarApellido.Visible = false;
            this.txtBuscarDNI.Visible = false;
            this.btnBuscar.Visible = false;

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

                        Archivos.SerealizarDatos(this.pasajeros, Archivos.pathPasajeros);
                        this.pasajeros = Archivos.DeserealizarPasajeros();
                        this.ActualizarLista(this.pasajeros);
                    }
                    break;
                case 1:
                    FrmVuelo frmVuelo = new FrmVuelo(this.aeronaves);
                    frmVuelo.ShowDialog();
                    if (frmVuelo.DialogResult == DialogResult.OK)
                    {
                        this.vuelos.Add(frmVuelo.Vuelo);
                    }
                    Archivos.SerealizarVuelos(this.vuelos);
                    this.vuelos = Archivos.DeserealizarVuelos();
                    this.ActualizarLista(this.vuelos);
                    break;
                case 2:
                    FrmAeronave frmAeronave = new FrmAeronave();
                    frmAeronave.ShowDialog();

                    if (frmAeronave.DialogResult == DialogResult.OK)
                    {
                        this.aeronaves.Add(frmAeronave.Aeronave);
                    }
                    Archivos.SerealizarDatos(this.aeronaves, Archivos.pathAeronaves);
                    this.aeronaves = Archivos.DeserealizarAeronaves();
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
                this.stripPasajero.Visible = false;
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


            if (this.indexItemSeleccionado != -1)
            {
                switch (index)
                {
                    case 0:
                        if (this.pasajeroSeleccionado is not null)
                        {
                            if (MessageBox.Show("Desea eliminar al pasajero? ", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                            {
                                this.pasajeros.Remove(this.pasajeroSeleccionado);
                                Archivos.SerealizarDatos(this.pasajeros, Archivos.pathPasajeros);
                                this.pasajeros = Archivos.DeserealizarPasajeros();
                                this.ActualizarLista(this.pasajeros);
                            }
                        }
                        else
                        {
                            MessageBox.Show("El pasajero está en un vuelo, no puede ser eliminado.");
                        }
                        break;
                    case 1:
                        if (this.vueloSeleccionado.Realizado == false && this.vueloSeleccionado.EnViaje == false)
                        {
                            if (this.vueloSeleccionado.Realizado == false || this.vueloSeleccionado.EnViaje == false)
                            {
                                if (MessageBox.Show("Desea eliminar el vuelo? ", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                                {
                                    foreach (Pasajero pasajero in this.vueloSeleccionado.Pasajeros)
                                    {
                                        foreach (Pasajero aux in this.pasajeros)
                                        {
                                            if (pasajero == aux)
                                            {
                                                aux.Agregado = false;
                                            }
                                        }
                                    }

                                    foreach (Aeronave aeronave in this.aeronaves)
                                    {
                                        if (this.vueloSeleccionado.Avion == aeronave)
                                        {
                                            aeronave.Disponible = true;
                                        }
                                    }

                                    this.vuelos.Remove(this.vueloSeleccionado);
                                    Archivos.SerealizarVuelos(this.vuelos);
                                    Archivos.SerealizarDatos(this.pasajeros, Archivos.pathPasajeros);
                                    Archivos.SerealizarDatos(this.aeronaves, Archivos.pathAeronaves);
                                    this.vuelos = Archivos.DeserealizarVuelos();
                                    this.ActualizarLista(this.vuelos);
                                }
                            }
                            else
                            {
                                MessageBox.Show("No se puede eliminar porque está en vuelo o ya se ha realizado");
                            }
                        }
                        break;
                    case 2:
                        if (this.aeronaveSeleccionado.Disponible == false)
                        {
                            if (MessageBox.Show("Desea eliminar la aeronave? ", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                            {
                                this.aeronaves.Remove(this.aeronaveSeleccionado);
                                Archivos.SerealizarVuelos(this.vuelos);
                                this.vuelos = Archivos.DeserealizarVuelos();
                                this.ActualizarLista(this.vuelos);
                            }
                        }
                        break;
                }
            }
        }

        private void ModificarElemento(int index)
        {
            if (this.aeronaveSeleccionado is not null || this.vueloSeleccionado is not null || this.pasajeroSeleccionado is not null)
            {

                switch (index)
                {
                    case 0:
                        if (this.pasajeroSeleccionado.EnVuelo == false)
                        {
                            FrmPasajero frmPasajero = new FrmPasajero(this.pasajeroSeleccionado);
                            if (frmPasajero.ShowDialog() == DialogResult.OK)
                            {
                                foreach (Vuelo vuelo in this.vuelos)
                                {
                                    if (vuelo.Pasajeros.Contains(frmPasajero.Pasajero))
                                    {
                                        int indice2 = vuelo.Pasajeros.FindIndex(p => p == frmPasajero.Pasajero);
                                        vuelo.Pasajeros[indice2] = frmPasajero.Pasajero;
                                        break;
                                    }
                                }
                                Archivos.SerealizarDatos(this.pasajeros,Archivos.pathPasajeros);
                                Archivos.SerealizarVuelos(this.vuelos);
                                this.pasajeros = Archivos.DeserealizarPasajeros();
                                this.vuelos = Archivos.DeserealizarVuelos();
                                this.ActualizarLista(this.pasajeros);
                            }
                        }
                        else
                        {
                            MessageBox.Show("El pasajero está en un vuelo, no puede ser modificado.");
                        }
                        break;
                    case 1:
                        if (this.vueloSeleccionado.EnViaje == false || this.vueloSeleccionado.Realizado == false)
                        {
                            FrmVuelo frmVuelo = new FrmVuelo(this.vueloSeleccionado, this.aeronaves);
                            frmVuelo.ShowDialog();

                            if (frmVuelo.DialogResult == DialogResult.OK)
                            {
                                Archivos.SerealizarVuelos(this.vuelos);
                                this.vuelos = Archivos.DeserealizarVuelos();
                                this.aeronaves = Archivos.DeserealizarAeronaves();
                            }
                        }
                        break;
                    case 2:
                        if (this.vueloSeleccionado.EnViaje == false || this.vueloSeleccionado.Realizado == false)
                        {
                            FrmAeronave frmAeronave = new FrmAeronave(this.aeronaveSeleccionado);
                            if (frmAeronave.ShowDialog() == DialogResult.OK)
                            {
                                foreach (Vuelo vuelo in this.vuelos)
                                {
                                    if (vuelo.Avion == frmAeronave.Aeronave)
                                    {
                                        vuelo.Avion = frmAeronave.Aeronave;
                                        break;
                                    }
                                }
                                Archivos.SerealizarDatos(this.aeronaves, Archivos.pathAeronaves);
                                Archivos.SerealizarVuelos(this.vuelos);
                                this.aeronaves = Archivos.DeserealizarAeronaves();
                                this.vuelos = Archivos.DeserealizarVuelos();
                                this.ActualizarListaAeronaves();
                            }
                        }
                        else
                        {
                            MessageBox.Show("El avión está en vuelo, no puede ser modificado.");
                        }
                        break;

                }
            }
        }

        private void ActualizarLista<T>(List<T> listaDatos)
        {
            this.dtgvElementos.DataSource = null;
            this.dtgvElementos.DataSource = listaDatos;
        } 

        private void ActualizarListaAeronaves()
        {
            this.dtgvElementos.DataSource = null;
            foreach (Aeronave aeronave in this.aeronaves)
            {
                if (this.vuelos.All(vuelo => vuelo.Avion != aeronave))
                {
                    aeronave.Disponible = true;
                }
            }
            this.dtgvElementos.DataSource = this.aeronaves;
            Archivos.SerealizarDatos(this.aeronaves, Archivos.pathAeronaves);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            this.ModificarElemento(this.index);
        }

        private void buscarPasajero()
        {
            this.ActualizarLista(this.pasajeros);

            if (int.TryParse(this.txtBuscarDNI.Text, out _))
            {
                this.dtgvElementos.DataSource = this.pasajeros.FindAll(pasajero => pasajero.Dni.ToString().Contains(this.txtBuscarDNI.Text));
            }
            else if (!Regex.IsMatch(this.txtBuscarNombre.Text, @"\d"))
            {
                this.dtgvElementos.DataSource = this.pasajeros.FindAll(pasajero => pasajero.Nombre.Contains(this.txtBuscarNombre.Text, StringComparison.OrdinalIgnoreCase));
            }
            else if (!Regex.IsMatch(this.txtBuscarNombre.Text, @"\d"))
            {
                this.dtgvElementos.DataSource = this.pasajeros.FindAll(pasajero => pasajero.Apellido.Contains(this.txtBuscarApellido.Text, StringComparison.OrdinalIgnoreCase));
            }
            else
            {
                this.dtgvElementos.DataSource = null;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.StripTxtHora.Text = DateTime.Now.ToShortDateString();
        }

        private void StripCerrarSesion_Click(object sender, EventArgs e)
        {

        }

        private void StripEstadisticaViajes_Click(object sender, EventArgs e)
        {
            FrmEstadistica frmEstadisticaBase = new FrmEstadistica(this.vuelos);
            frmEstadisticaBase.ShowDialog();
        }


        private void btnMostrarPasajeros_Click(object sender, EventArgs e)
        {
            FrmPasajerosDelVuelo pasajerosDelVuelo = new FrmPasajerosDelVuelo(this.vueloSeleccionado);
            pasajerosDelVuelo.ShowDialog();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.buscarPasajero();
        }

        private void panelModificar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dtgvElementos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow filaSeleccionada = dtgvElementos.Rows[e.RowIndex];
                switch (this.index)
                {
                    case 0:
                        this.pasajeroSeleccionado = filaSeleccionada.DataBoundItem as Pasajero;
                        break;
                    case 1:
                        this.vueloSeleccionado = filaSeleccionada.DataBoundItem as Vuelo;
                        break;
                    case 2:
                        this.aeronaveSeleccionado = filaSeleccionada.DataBoundItem as Aeronave;
                        break;
                }
            }
        }

        private void menuAerolinea_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}