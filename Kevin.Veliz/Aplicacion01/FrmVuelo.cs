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
    public partial class FrmVuelo : FrmBase
    {
        private string? seleccionadoTipo;
        private string? seleccionadoDestino;
        private DateTime fechaDeLlegada;
        private List<Aeronave> aeronaves;
        private List<Pasajero> pasajeros;
        private Vuelo vuelo;
        private int indexAeronaveSeleccionada;
        private string? salidaSeleccionado;
        private string? destinoSeleccionado;
        private DateTime fechaSeleccionado;
        private string? avionSeleccionado;

        public FrmVuelo()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        public FrmVuelo(List<Pasajero> listaPasajeros, List<Aeronave> listaAeronaves) : this()
        {
            this.pasajeros = listaPasajeros;
            this.aeronaves = listaAeronaves;
            this.btnAgregar.Visible = true;
        }

        public FrmVuelo(Vuelo vuelo, List<Aeronave> aeronaves) : this()
        {
            this.vuelo = vuelo;
            this.aeronaves = aeronaves;
            this.btnModifcar.Location = new System.Drawing.Point(this.btnAgregar.Location.X, this.btnAgregar.Location.Y);
            this.btnAgregar.Visible = false;
        }

        private void FrmVuelo_Load(object sender, EventArgs e)
        {
            this.dtmVuelo.MinDate = DateTime.Today;
            this.lblHoraVuelo.Visible = false;
            this.dtmVuelo.Format = DateTimePickerFormat.Custom;
            this.dtmVuelo.CustomFormat = "MM/dd/yyyy hh:mm:ss";
            this.lblDuracionVuelo.Visible = false;
            this.txtCostoPremium.Enabled = false;
            this.txtCostoTurista.Enabled = false;
            this.cboTipoVuelo.Text = "--Ingrese--";
            foreach (EnumTipoVuelo tipo in Enum.GetValues(typeof(EnumTipoVuelo)))
            {
                this.cboTipoVuelo.Items.Add(tipo.ToString());
            }

            this.InicializarComponentes();
        }

        private void dtmVuelo_ValueChanged(object sender, EventArgs e)
        {
            if (this.destinoSeleccionado != null && this.seleccionadoTipo != null && this.salidaSeleccionado != null)
            {

                this.lblHoraVuelo.Visible = true;
                this.lblDuracionVuelo.Visible = true;
                this.seleccionadoDestino = cboDestino.SelectedItem.ToString();
                this.txtCostoTurista.Visible = true;
                double duracion = 0;
                DateTime hora = dtmVuelo.Value;
                this.lblHoraVuelo.Text = hora.ToString();
                if (this.seleccionadoTipo == "Nacional")
                {
                    duracion = Funcionalidades.CalcularDuracionNacional();
                }
                else if (this.seleccionadoTipo == "Internacional")
                {
                    duracion = Funcionalidades.CalcularDuracionInternacional();
                }
                this.fechaDeLlegada = hora.AddHours(duracion);
                this.lblDuracionVuelo.Text = this.fechaDeLlegada.ToString();
                double costoTurista = Funcionalidades.CalcularPrecio(false, this.seleccionadoDestino ?? "", duracion);
                double costoPremium = Funcionalidades.CalcularPrecio(true, this.seleccionadoDestino ?? "", duracion);
                this.txtCostoTurista.Text = costoTurista.ToString();
                this.txtCostoPremium.Text = costoPremium.ToString();
                this.fechaSeleccionado = this.dtmVuelo.Value;
            }
            else
            {
                this.lblHoraVuelo.Visible = false;
                this.lblDuracionVuelo.Visible = false;
            }
        }

        private void cboTipoVuelo_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }

        private void cboTipoVuelo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string auxInternacional;
            string auxNacional;
            lblHoraVuelo.Text = "";
            lblDuracionVuelo.Text = "";
            this.fechaSeleccionado = DateTime.Today;
            this.seleccionadoTipo = (string)cboTipoVuelo.SelectedItem;
            this.txtCostoPremium.Text = "";
            this.txtCostoTurista.Text = "";
            this.dtmVuelo.Enabled = false;

            if (this.seleccionadoTipo == "Nacional")
            {
                this.cboPartida.Items.Clear();
                this.cboDestino.Items.Clear();
                this.cboPartida.Text = "--Seleccione--";
                this.cboDestino.Text = "--Seleccione--";
                foreach (EnumVuelosNacionales clase in Enum.GetValues(typeof(EnumVuelosNacionales)))
                {
                    auxNacional = clase.ToString();
                    auxNacional = auxNacional.Replace('_', ' ');
                    this.cboPartida.Items.Add(auxNacional);
                }
            }
            else if (this.seleccionadoTipo == "Internacional")
            {
                this.cboPartida.Items.Clear();
                this.cboDestino.Items.Clear();
                this.cboPartida.Text = "--Seleccione--";
                this.cboDestino.Text = "--Seleccione--";
                string aux = EnumVuelosNacionales.Buenos_Aires.ToString();
                aux = aux.Replace('_', ' ');
                this.cboPartida.Items.Add(aux);

                foreach (EnumVuelosInternacionales equipaje in Enum.GetValues(typeof(EnumVuelosInternacionales)))
                {
                    auxInternacional = equipaje.ToString();
                    auxInternacional = auxInternacional.Replace('_', ' ');
                    this.cboDestino.Items.Add(auxInternacional);
                }
            }
        }

        private void cboPartida_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.salidaSeleccionado = this.cboPartida.SelectedItem.ToString();
            FiltrarLugares(this.cboDestino, this.cboPartida);
        }

        private void cboDestino_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.destinoSeleccionado = this.cboDestino.SelectedItem.ToString();
            FiltrarLugares(this.cboPartida, this.cboDestino);
            this.dtmVuelo.Enabled = true;
        }

        public void FiltrarLugares(ComboBox comboBox, ComboBox comboBox1)
        {
            if (this.seleccionadoTipo == "Nacional")
            {
                comboBox.Items.Clear();
                foreach (EnumVuelosNacionales clase in Enum.GetValues(typeof(EnumVuelosNacionales)))
                {
                    string aux = clase.ToString();
                    aux = aux.Replace("_", " ");
                    if (!aux.Equals(comboBox1.SelectedItem.ToString()))
                    {
                        comboBox.Items.Add(aux);
                    }
                }
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (this.fechaSeleccionado != DateTime.Today && this.avionSeleccionado != null)
            {
                this.vuelo = new Vuelo(this.salidaSeleccionado ?? "", this.destinoSeleccionado ?? "", this.fechaSeleccionado, ((Aeronave)cboAeronave.Items[this.indexAeronaveSeleccionada]), this.fechaDeLlegada, "No viajó");
                this.vuelo.CostoClasePremium = double.Parse(txtCostoPremium.Text);
                this.vuelo.CostoClaseTurista = double.Parse(txtCostoTurista.Text);
                ((Aeronave)cboAeronave.Items[this.indexAeronaveSeleccionada]).Disponible = false;
                Archivos.SerealizarAeronaves(this.aeronaves);
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Complete los campos.");
            }
        }

        private void cboAeronave_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.indexAeronaveSeleccionada = cboAeronave.SelectedIndex;
            this.lblInfoAeronave.Visible = true;
            this.lblInfoAeronave.Text = ((Aeronave)cboAeronave.Items[this.indexAeronaveSeleccionada]).ToString();
            this.avionSeleccionado = ((Aeronave)cboAeronave.Items[this.indexAeronaveSeleccionada]).ToString();
        }

        private void cboAeronave_Click(object sender, EventArgs e)
        {
            cboAeronave.Items.Clear();
            foreach (Aeronave aeronave in this.aeronaves)
            {
                if (aeronave.Disponible)
                {
                    cboAeronave.Items.Add(aeronave);
                }
            }
        }

        private void InicializarComponentes()
        {
            int indexCboSalida = cboPartida.FindStringExact(this.vuelo.CiudadDePartida);
        }
        public Vuelo Vuelo
        {
            get { return this.vuelo; }
            set { this.vuelo = value; }
        }


    }
}
