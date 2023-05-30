using Entidades;
using System.Data;
using System.Xml.Linq;


namespace Aplicacion01
{
    public partial class FrmEstadistica : FrmBase
    {
        List<Vuelo> listaVuelos;
        double acumuladorDinero;
        double acumuladorDineroPorDestino;
        Dictionary<string, double> recaudacionDestino;
        Dictionary<string, double> diccionarioOrdenado;

        public FrmEstadistica(List<Vuelo> vuelos)
        {
            InitializeComponent();
            this.listaVuelos = vuelos;
            this.acumuladorDinero = 0;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.recaudacionDestino = new Dictionary<string, double>();
            this.diccionarioOrdenado = new Dictionary<string, double>();
        }

        private void FrmEstadisticaBase_Load(object sender, EventArgs e)
        {
            string auxDestino = "";

            // Obtén la posición del control en relación con el formulario

            // Calcula la posición de desplazamiento necesaria

            // Ajusta el desplazamiento del formulario

            foreach (Vuelo vuelo in this.listaVuelos)
            {
                if (vuelo.Realizado)
                {
                    int rows = dtgvViajes.Rows.Add();
                    this.dtgvViajes.Rows[rows].Cells[0].Value = vuelo.CiudadDePartida;
                    this.dtgvViajes.Rows[rows].Cells[1].Value = vuelo.CiudadDeDestino;
                    this.dtgvViajes.Rows[rows].Cells[2].Value = vuelo.FechaDeVuelo;
                    this.dtgvViajes.Rows[rows].Cells[3].Value = vuelo.FechaDeLLegada;
                    this.dtgvViajes.Rows[rows].Cells[4].Value = vuelo.Avion;
                    this.dtgvViajes.Rows[rows].Cells[5].Value = vuelo.CantidadAsientosDispPremium;
                    this.dtgvViajes.Rows[rows].Cells[6].Value = vuelo.CantidadAsientosDispTurista;
                    this.dtgvViajes.Rows[rows].Cells[7].Value = vuelo.CostoClasePremium;
                    this.dtgvViajes.Rows[rows].Cells[8].Value = vuelo.CostoClaseTurista;
                    this.dtgvViajes.Rows[rows].Cells[9].Value = vuelo.RecaudacionTotal;
                }
            }

            foreach (EnumDestinos destino in Enum.GetValues(typeof(EnumDestinos)))
            {
                auxDestino = destino.ToString();
                auxDestino = auxDestino.Replace("_", " ");
                foreach (Vuelo vuelo in this.listaVuelos)
                {
                    if (vuelo.Realizado)
                    {
                        if (vuelo.CiudadDeDestino == auxDestino)
                        {
                            this.acumuladorDineroPorDestino += vuelo.RecaudacionTotal;
                        }
                    }
                }
                this.recaudacionDestino.Add(auxDestino, this.acumuladorDineroPorDestino);
                this.acumuladorDineroPorDestino = 0;
            }

            this.lblDestino.Text = Funcionalidades.DestinoMasSeleccionado(this.listaVuelos);
            this.almacenarVueloRecaudacion();
        }

        private void almacenarVueloRecaudacion()
        {
            this.diccionarioOrdenado = this.recaudacionDestino.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
            foreach (KeyValuePair<string, double> kvp in diccionarioOrdenado)
            {
                int rows = dtgvMontoDestinos.Rows.Add();
                this.dtgvMontoDestinos.Rows[rows].Cells[0].Value = kvp.Key;
                this.dtgvMontoDestinos.Rows[rows].Cells[1].Value = kvp.Value;
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            this.acumuladorDinero = 0;
            foreach (Vuelo vuelo in this.listaVuelos)
            {
                if (vuelo is not null && vuelo.Realizado)
                {
                    this.acumuladorDinero += vuelo.RecaudacionTotal;
                }
            }
            this.textBox1.Text = acumuladorDinero.ToString();
        }


        private void FrmEstadistica_FormClosing(object sender, FormClosingEventArgs e)
        {
            Archivos.SerealizarEstadistica(this.diccionarioOrdenado, this.acumuladorDinero);
        }
    }
}
