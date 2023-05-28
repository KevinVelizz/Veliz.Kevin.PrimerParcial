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

        Vuelo? vueloSeleccionado;
        Pasajero? pasajeroSeleccionado;

        private bool comida;
        private bool internet;

        public FrmVenderVuelo(List<Pasajero> listaPasajeros, List<Vuelo> listaVuelos)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.pasajeros = listaPasajeros;
            this.vuelos = listaVuelos;
            this.comida = false;
            this.internet = false;
            this.dtgvVuelosDisponibles.Columns.Add("LugarSalida", "Salida");
            this.dtgvVuelosDisponibles.Columns.Add("LugarDestino", "Destino");
            this.dtgvVuelosDisponibles.Columns.Add("FechaSalida", "Fecha de salida");
            this.dtgvVuelosDisponibles.Columns.Add("FechaLlegada", "Fecha de llegada");

            this.dtgvPasajerosDisponibles.Columns.Add("Nombre", "Nombre");
            this.dtgvPasajerosDisponibles.Columns.Add("Apellido", "Apellido");
            this.dtgvPasajerosDisponibles.Columns.Add("DNI", "DNI");
        }

        private void FrmVenderVuelo_Load(object sender, EventArgs e)
        {
            dtgvVuelosDisponibles.ClearSelection();

            if (this.pasajeros.Count > 0)
            {
                foreach (Pasajero pasajero in this.pasajeros)
                {
                    if (pasajero.Agregado == false)
                    {
                        int rowIndex = this.dtgvPasajerosDisponibles.Rows.Add();
                        DataGridViewRow row = dtgvPasajerosDisponibles.Rows[rowIndex];
                        row.Tag = pasajero;
                        row.Cells["Nombre"].Value = pasajero.Nombre;
                        row.Cells["Apellido"].Value = pasajero.Edad;
                        row.Cells["DNI"].Value = pasajero.Dni;
                    }
                }
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

        private void btnVender_Click(object sender, EventArgs e)
        {
            if (this.pasajeroSeleccionado is not null && this.vueloSeleccionado is not null)
            {
                this.vueloSeleccionado.Pasajeros.Add(this.pasajeroSeleccionado);
                this.pasajeroSeleccionado.Agregado = true;
                this.vueloSeleccionado.RestarAsientos();
                Archivos.SerealizarDatos(this.pasajeros, Archivos.pathAeronaves);
                Archivos.SerealizarVuelos(this.vuelos);
                this.Close();
            }
        }

        private void cboPasajeros_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscarVuelo_Click(object sender, EventArgs e)
        {
            dtgvVuelosDisponibles.Rows.Clear();
            foreach (Vuelo vuelo in this.vuelos)
            {
                if (!vuelo.EnViaje && !vuelo.Realizado)
                {
                    if (this.comida && this.internet)
                    {
                        if (vuelo.Avion.ServicioComida && vuelo.Avion.ServicioInternet)
                        {
                            int rowIndex = this.dtgvVuelosDisponibles.Rows.Add();
                            DataGridViewRow row = dtgvVuelosDisponibles.Rows[rowIndex];
                            row.Tag = vuelo;

                            row.Cells["LugarSalida"].Value = vuelo.CiudadDePartida;
                            row.Cells["LugarDestino"].Value = vuelo.CiudadDeDestino;
                            row.Cells["FechaSalida"].Value = vuelo.FechaDeVuelo;
                            row.Cells["FechaLlegada"].Value = vuelo.FechaDeLLegada;
                        }
                    }
                    else if (this.comida)
                    {
                        if (vuelo.Avion.ServicioComida)
                        {
                            int rowIndex = this.dtgvVuelosDisponibles.Rows.Add();
                            DataGridViewRow row = dtgvVuelosDisponibles.Rows[rowIndex];
                            row.Tag = vuelo;

                            row.Cells["LugarSalida"].Value = vuelo.CiudadDePartida;
                            row.Cells["LugarDestino"].Value = vuelo.CiudadDeDestino;
                            row.Cells["FechaSalida"].Value = vuelo.FechaDeVuelo;
                            row.Cells["FechaLlegada"].Value = vuelo.FechaDeLLegada;
                        }
                    }
                    else if (this.internet)
                    {
                        if (vuelo.Avion.ServicioInternet)
                        {
                            int rowIndex = this.dtgvVuelosDisponibles.Rows.Add();
                            DataGridViewRow row = dtgvVuelosDisponibles.Rows[rowIndex];
                            row.Tag = vuelo;

                            row.Cells["LugarSalida"].Value = vuelo.CiudadDePartida;
                            row.Cells["LugarDestino"].Value = vuelo.CiudadDeDestino;
                            row.Cells["FechaSalida"].Value = vuelo.FechaDeVuelo;
                            row.Cells["FechaLlegada"].Value = vuelo.FechaDeLLegada;
                        }
                    }
                    else
                    {
                        if (vuelo.Avion.ServicioComida == false && vuelo.Avion.ServicioInternet == false)
                        {
                            int rowIndex = this.dtgvVuelosDisponibles.Rows.Add();
                            DataGridViewRow row = dtgvVuelosDisponibles.Rows[rowIndex];
                            row.Tag = vuelo;

                            row.Cells["LugarSalida"].Value = vuelo.CiudadDePartida;
                            row.Cells["LugarDestino"].Value = vuelo.CiudadDeDestino;
                            row.Cells["FechaSalida"].Value = vuelo.FechaDeVuelo;
                            row.Cells["FechaLlegada"].Value = vuelo.FechaDeLLegada;
                        }
                    }
                }
            }
        }

        private void dtgvVuelosDisponibles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < this.dtgvVuelosDisponibles.Rows.Count)
            {
                DataGridViewRow filaSeleccionada = dtgvVuelosDisponibles.Rows[e.RowIndex];
                this.vueloSeleccionado = filaSeleccionada.Tag as Vuelo;

                foreach (Vuelo vuelo in this.vuelos)
                {
                    if (vuelo.Equals(this.vueloSeleccionado))
                    {
                        if (this.pasajeroSeleccionado is not null)
                        {
                            if (this.pasajeroSeleccionado.Premium)
                            {
                                this.txtCostoBruto.Text = this.vueloSeleccionado.CostoClasePremium.ToString();
                                this.txtCostoNeto.Text = (this.vueloSeleccionado.CostoClasePremium * 1.21).ToString();
                            }
                            else
                            {
                                this.txtCostoBruto.Text = this.vueloSeleccionado.CostoClaseTurista.ToString();
                                this.txtCostoNeto.Text = (this.vueloSeleccionado.CostoClaseTurista * 1.21).ToString();
                            }
                        }
                        break;
                    }
                }
            }
        }

        private void dtgvPasajerosDisponibles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaSeleccionada = dtgvPasajerosDisponibles.Rows[e.RowIndex];
            this.pasajeroSeleccionado = filaSeleccionada.Tag as Pasajero;
        }
    }
}
