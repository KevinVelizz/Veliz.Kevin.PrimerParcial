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
        private EnumTipoVuelo tipoSeleccionado;
        private string? seleccionadoDestino;
        private DateTime fechaDeLlegada;
        private List<Aeronave> aeronaves;
        private Vuelo vuelo;
        private int indexAeronaveSeleccionada;
        private string? salidaSeleccionado;
        private string? destinoSeleccionado;
        private DateTime fechaSeleccionado;
        private string? avionSeleccionado;
        private bool modifica;


        public FrmVuelo()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        public FrmVuelo(List<Aeronave> listaAeronaves) : this()
        {
            this.aeronaves = listaAeronaves;
            this.btnAgregar1.Visible = true;
            this.btnModificar1.Visible = false;
        }

        public FrmVuelo(Vuelo vuelo, List<Aeronave> aeronaves) : this()
        {
            this.vuelo = vuelo;
            this.aeronaves = aeronaves;
            this.btnModificar1.Location = new System.Drawing.Point(this.btnAgregar1.Location.X, this.btnAgregar1.Location.Y);
            this.btnAgregar1.Visible = false;
            this.modifica = true;
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
                this.cboTipoVuelo.Items.Add(tipo);
            }

            if (modifica)
            {
                this.InicializarComponentes();
            }
        }

        private void dtmVuelo_ValueChanged(object sender, EventArgs e)
        {
            if (this.destinoSeleccionado != null && this.tipoSeleccionado != null && this.salidaSeleccionado != null)
            {
                this.lblHoraVuelo.Visible = true;
                this.lblDuracionVuelo.Visible = true;
                this.seleccionadoDestino = cboDestino.SelectedItem.ToString();
                this.txtCostoTurista.Visible = true;
                double duracion = 0;
                DateTime hora = dtmVuelo.Value;
                this.lblHoraVuelo.Text = hora.ToString();
                if (this.tipoSeleccionado == EnumTipoVuelo.Nacional)
                {
                    duracion = Funcionalidades.CalcularDuracionNacional();
                }
                else if (this.tipoSeleccionado == EnumTipoVuelo.Internacional)
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

        private void cboTipoVuelo_SelectedIndexChanged(object sender, EventArgs e)
        {

            this.AgregarElementosComboBox();
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
            if (this.tipoSeleccionado == EnumTipoVuelo.Nacional)
            {
                comboBox.Items.Clear();
                foreach (EnumVuelosNacionales clase in Enum.GetValues(typeof(EnumVuelosNacionales)))
                {
                    if (!Funcionalidades.ReemplazarGuionBajo(clase).Equals(comboBox1.SelectedItem.ToString()))
                    {
                        comboBox.Items.Add(Funcionalidades.ReemplazarGuionBajo(clase));
                    }
                }
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
            foreach (Aeronave aeronave in this.aeronaves)
            {
                if (aeronave.Disponible && !cboAeronave.Items.Contains(aeronave))
                {
                    cboAeronave.Items.Add(aeronave);
                }
            }
        }

        private void AgregarElementosComboBox()
        {
            lblHoraVuelo.Text = "";
            lblDuracionVuelo.Text = "";
            this.fechaSeleccionado = DateTime.Today;
            this.tipoSeleccionado = (EnumTipoVuelo)cboTipoVuelo.SelectedItem;
            this.txtCostoPremium.Text = "";
            this.txtCostoTurista.Text = "";
            this.dtmVuelo.Enabled = false;

            if (this.tipoSeleccionado == EnumTipoVuelo.Nacional)
            {
                this.cboPartida.Items.Clear();
                this.cboDestino.Items.Clear();
                this.cboPartida.Text = "--Seleccione--";
                this.cboDestino.Text = "--Seleccione--";
                foreach (EnumVuelosNacionales clase in Enum.GetValues(typeof(EnumVuelosNacionales)))
                {
                    this.cboPartida.Items.Add(Funcionalidades.ReemplazarGuionBajo(clase));
                }
            }
            else if (this.tipoSeleccionado == EnumTipoVuelo.Internacional)
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
                    this.cboDestino.Items.Add(Funcionalidades.ReemplazarGuionBajo(equipaje));
                }
            }
        }

        private void InicializarComponentes()
        {
            this.cboAeronave.Items.Add(this.vuelo.Avion);
            this.cboTipoVuelo.SelectedIndex = cboTipoVuelo.FindStringExact(this.vuelo.Tipo.ToString());
            this.cboPartida.SelectedIndex = cboPartida.FindStringExact(this.vuelo.CiudadDePartida);
            this.cboDestino.SelectedIndex = cboDestino.FindStringExact(this.vuelo.CiudadDeDestino);
            this.dtmVuelo.Value = this.vuelo.FechaDeVuelo;
            this.cboAeronave.SelectedIndex = cboAeronave.FindStringExact(this.vuelo.Avion.ToString());
        }


        private void btnAgregar1_Click(object sender, EventArgs e)
        {
            if (this.fechaSeleccionado != DateTime.Today && this.avionSeleccionado != null && this.txtCostoPremium.Text != "" && this.txtCostoTurista.Text != "")
            {
                this.vuelo = new Vuelo(this.salidaSeleccionado ?? "", this.destinoSeleccionado ?? "", this.fechaSeleccionado, ((Aeronave)cboAeronave.Items[this.indexAeronaveSeleccionada]), this.fechaDeLlegada);
                this.vuelo.CostoClasePremium = double.Parse(txtCostoPremium.Text);
                this.vuelo.CostoClaseTurista = double.Parse(txtCostoTurista.Text);
                ((Aeronave)cboAeronave.Items[this.indexAeronaveSeleccionada]).Disponible = false;
                Archivos.SerealizarDatos(this.aeronaves, Archivos.PathAeronaves);
                this.cerrar = true;
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Complete los campos.");
            }
        }

        private void btnModificar1_Click(object sender, EventArgs e)
        {
            this.vuelo.Avion = (Aeronave)this.cboAeronave.Items[this.indexAeronaveSeleccionada];
            this.vuelo.CiudadDePartida = this.salidaSeleccionado ?? "";
            this.vuelo.CiudadDeDestino = this.destinoSeleccionado ?? "";
            this.vuelo.Tipo = this.tipoSeleccionado;
            this.vuelo.FechaDeVuelo = this.fechaSeleccionado;
            this.vuelo.CostoClasePremium = double.Parse(txtCostoPremium.Text);
            this.vuelo.CostoClaseTurista = double.Parse(txtCostoTurista.Text);
            ((Aeronave)cboAeronave.Items[this.indexAeronaveSeleccionada]).Disponible = false;
            Archivos.SerealizarDatos(this.aeronaves, Archivos.PathAeronaves);
            this.cerrar = true;
            this.DialogResult = DialogResult.OK;
        }

        public Vuelo Vuelo
        {
            get { return this.vuelo; }
            set { this.vuelo = value; }
        }
    }
}
