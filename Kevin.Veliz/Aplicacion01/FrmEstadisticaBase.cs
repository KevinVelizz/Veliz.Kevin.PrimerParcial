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
    public partial class FrmEstadisticaBase : FrmBase
    {
        List<Vuelo> listaVuelos;
        double acumuladorDinero;

        public FrmEstadisticaBase(List<Vuelo> vuelos)
        {
            InitializeComponent();
            this.listaVuelos = vuelos;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void FrmEstadisticaBase_Load(object sender, EventArgs e)
        {
            foreach (Vuelo vuelo in this.listaVuelos)
            {
                if (vuelo.AuxRealizado)
                {
                    int rows = dtgvViajes.Rows.Add();
                    this.dtgvViajes.Rows[rows].Cells[0].Value = vuelo.CiudadDePartida;
                    this.dtgvViajes.Rows[rows].Cells[1].Value = vuelo.CiudadDeDestino;
                    this.dtgvViajes.Rows[rows].Cells[2].Value = vuelo.FechaDeVuelo;
                }
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            this.acumuladorDinero = 0;
            foreach (Vuelo vuelo in this.listaVuelos)
            {
                if (vuelo != null)
                {
                    this.acumuladorDinero += vuelo.RecaudacionTotal;
                }
            }
            this.textBox1.Text = acumuladorDinero.ToString();
        }
    }
}
