using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicacion01
{
    public partial class FrmEstadistica : FrmBase
    {
        List<Vuelo> listaVuelos;
        double acumuladorDinero;
        double acumuladorDineroPorDestino;
        Dictionary<string, double> recaudacionDestino;

        public FrmEstadistica(List<Vuelo> vuelos)
        {
            InitializeComponent();
            this.listaVuelos = vuelos;
            this.acumuladorDinero = 0;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.recaudacionDestino = new Dictionary<string, double>();
        }

        private void FrmEstadisticaBase_Load(object sender, EventArgs e)
        {

            string auxDestino = "";

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
                    this.dtgvViajes.Rows[rows].Cells[9].Value = vuelo.Pasajeros;
                    this.dtgvViajes.Rows[rows].Cells[10].Value = vuelo.Estado;
                    this.dtgvViajes.Rows[rows].Cells[11].Value = vuelo.RecaudacionTotal;
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
            this.almacenarVueloRecaudacion();
        }

        private void almacenarVueloRecaudacion()
        {
            Dictionary<string, double> diccionarioOrdenado = this.recaudacionDestino.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
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
    }
}
