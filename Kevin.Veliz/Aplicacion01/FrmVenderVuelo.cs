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
    public partial class FrmVenderVuelo : FrmBase
    {
        private List<Pasajero> pasajeros;
        private List<Vuelo> vuelos;
        private int indexVueloSeleccionado;
        private int indexPasajeroSeleccionado;
        private bool comida;
        private bool internet;
        private string pasajeroSeleccionado;
        private string vueloSeleccionado;

        public FrmVenderVuelo(List<Pasajero> listaPasajeros, List<Vuelo> listaVuelos)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.pasajeros = listaPasajeros;
            this.vuelos = listaVuelos;
            this.comida = false;
            this.internet = false;
        }

        private void FrmVenderVuelo_Load(object sender, EventArgs e)
        {

        }

        private void cboViajes_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.indexVueloSeleccionado = this.cboViajes.SelectedIndex;
            this.lblInfoAvion.Visible = true;
            this.lblInfoAvion.Text = this.vuelos[this.indexVueloSeleccionado].Avion.ToString();
            this.vueloSeleccionado = this.cboViajes.SelectedItem.ToString() ?? "";

            if (this.pasajeros[this.indexPasajeroSeleccionado].Premium)
            {
                this.txtCosto.Text = this.vuelos[this.indexVueloSeleccionado].CostoClasePremium.ToString();
            }
            else
            {
                this.txtCosto.Text = this.vuelos[this.indexVueloSeleccionado].CostoClaseTurista.ToString();
            }
        }

        private void chkComida_CheckedChanged(object sender, EventArgs e)
        {
            this.comida = chkComida.Checked;
        }

        private void chkInternet_CheckedChanged(object sender, EventArgs e)
        {
            this.internet = chkInternet.Checked;
        }

        private void cboViajes_Click(object sender, EventArgs e)
        {
            this.cboViajes.Items.Clear();
            foreach (Vuelo vuelo in this.vuelos)
            {
                if (this.comida && this.internet)
                {
                    if (vuelo.Avion.ServicioComida && vuelo.Avion.ServicioInternet)
                    {
                        this.cboViajes.Items.Add(vuelo.Informacion());
                    }
                }
                else if (this.comida)
                {
                    if (vuelo.Avion.ServicioComida)
                    {
                        this.cboViajes.Items.Add(vuelo.Informacion());
                    }
                }
                else if (this.internet)
                {
                    if (vuelo.Avion.ServicioInternet)
                    {
                        this.cboViajes.Items.Add(vuelo.Informacion());
                    }
                }
                else
                {
                    if (vuelo.Avion.ServicioComida == false && vuelo.Avion.ServicioInternet == false)
                        this.cboViajes.Items.Add(vuelo);
                }
            }
        }

        private void cboPasajeros_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.pasajeroSeleccionado = this.cboPasajeros.SelectedItem.ToString() ?? "";
            this.indexPasajeroSeleccionado = this.cboPasajeros.SelectedIndex;
        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            if (this.pasajeroSeleccionado != null && this.vueloSeleccionado != null)
            {
                if (this.vuelos[this.indexVueloSeleccionado].Avion.CantidadAsientos > 0)
                {
                    this.vuelos[this.indexVueloSeleccionado].Pasajeros.Add(this.pasajeros[this.indexPasajeroSeleccionado]);
                    this.vuelos[this.indexVueloSeleccionado].RestarAsientos();
                    this.pasajeros[this.indexPasajeroSeleccionado].Agregado = true;
                    Archivos.SerealizarViajeros(this.pasajeros);
                    Archivos.SerealizarVuelos(this.vuelos);
                    this.Close();
                }
            }
        }

        private void cboPasajeros_Click(object sender, EventArgs e)
        {
            foreach (Pasajero pasajero in this.pasajeros)
            {
                if (pasajero.Agregado == false)
                {
                    this.cboPasajeros.Items.Add(pasajero.Mostrar());
                }
            }
        }
    }
}
