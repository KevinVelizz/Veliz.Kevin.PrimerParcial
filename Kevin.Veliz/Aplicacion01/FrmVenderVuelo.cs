using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicacion01
{
    public partial class FrmVenderVuelo : FrmBase
    {
        private List<Pasajero> pasajeros;
        private List<Vuelo> vuelos;
        Vuelo vueloSeleccionado;
        Pasajero pasajeroSeleccionado;
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

        }

        private void FrmVenderVuelo_Load(object sender, EventArgs e)
        {
            dtgvVuelosDisponibles.ClearSelection();
            if (this.pasajeros.Count > 0)
            {
                this.dtgvPasajerosDisponibles.DataSource = this.pasajeros.FindAll(pasajero => !pasajero.Agregado);
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


        private void cboPasajeros_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscarVuelo_Click(object sender, EventArgs e)
        {
            dtgvVuelosDisponibles.Rows.Clear();
            foreach (Vuelo vuelo in this.vuelos)
            {
                if (!vuelo.EnViaje && !vuelo.Realizado && (vuelo.CantidadAsientosDispPremium > 0 || vuelo.CantidadAsientosDispTurista > 0) && vuelo.Avion.CapacidadBodega > 0)
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
            this.pasajeroSeleccionado = filaSeleccionada.DataBoundItem as Pasajero;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.buscarPasajero();
        }

        private void buscarPasajero()
        {
            this.ActualizarLista(this.pasajeros);
            if (this.txtBuscarDNI.Text != "" && this.txtBuscarNombre.Text != "" && this.txtBuscarApellido.Text != "")
            {
                this.dtgvPasajerosDisponibles.DataSource = this.pasajeros.FindAll(pasajero => pasajero.Dni.ToString().Contains(this.txtBuscarDNI.Text)
                && pasajero.Nombre.Contains(this.txtBuscarNombre.Text, StringComparison.OrdinalIgnoreCase)
                && pasajero.Apellido.Contains(txtBuscarApellido.Text, StringComparison.OrdinalIgnoreCase));
            }
            else if (this.txtBuscarDNI.Text != "" && this.txtBuscarNombre.Text != "")
            {
                this.dtgvPasajerosDisponibles.DataSource = this.pasajeros.FindAll(pasajero => pasajero.Dni.ToString().Contains(this.txtBuscarDNI.Text)
                && pasajero.Nombre.Contains(this.txtBuscarNombre.Text, StringComparison.OrdinalIgnoreCase));
            }
            else if (this.txtBuscarDNI.Text != "" && this.txtBuscarApellido.Text != "")
            {
                this.dtgvPasajerosDisponibles.DataSource = this.pasajeros.FindAll(pasajero => pasajero.Dni.ToString().Contains(this.txtBuscarDNI.Text)
                && pasajero.Nombre.Contains(this.txtBuscarApellido.Text, StringComparison.OrdinalIgnoreCase));
            }
            else if (this.txtBuscarNombre.Text != "" && this.txtBuscarApellido.Text != "")
            {
                this.dtgvPasajerosDisponibles.DataSource = this.pasajeros.FindAll(pasajero => pasajero.Nombre.Contains(this.txtBuscarNombre.Text, StringComparison.OrdinalIgnoreCase)
                && pasajero.Nombre.Contains(this.txtBuscarApellido.Text, StringComparison.OrdinalIgnoreCase));
            }
            else if (this.txtBuscarDNI.Text != "")
            {
                this.dtgvPasajerosDisponibles.DataSource = this.pasajeros.FindAll(pasajero => pasajero.Dni.ToString().Contains(this.txtBuscarDNI.Text));
            }
            else if (this.txtBuscarNombre.Text != "")
            {
                this.dtgvPasajerosDisponibles.DataSource = this.pasajeros.FindAll(pasajero => pasajero.Nombre.Contains(this.txtBuscarNombre.Text, StringComparison.OrdinalIgnoreCase));
            }
            else if (this.txtBuscarApellido.Text != "")
            {
                this.dtgvPasajerosDisponibles.DataSource = this.pasajeros.FindAll(pasajero => pasajero.Apellido.Contains(this.txtBuscarApellido.Text, StringComparison.OrdinalIgnoreCase));
            }
            else
            {
                this.dtgvPasajerosDisponibles.DataSource = this.pasajeros;
            }
        }

        private void btnVender_Click_1(object sender, EventArgs e)
        {
            bool validar = true;
            if (this.pasajeroSeleccionado is not null && this.vueloSeleccionado is not null)
            {
                if (this.pasajeroSeleccionado.Equipajes.Count > 0)
                {
                    if (this.pasajeroSeleccionado.Equipajes.Count > 1)
                    {
                        this.vueloSeleccionado.Avion.CapacidadBodega -= this.pasajeroSeleccionado.Equipajes[0].Peso + this.pasajeroSeleccionado.Equipajes[1].Peso;
                        if (this.vueloSeleccionado.Avion.CapacidadBodega < 0)
                        {
                            this.vueloSeleccionado.Avion.CapacidadBodega += this.pasajeroSeleccionado.Equipajes[0].Peso + this.pasajeroSeleccionado.Equipajes[1].Peso;
                            validar = false;
                        }
                    }
                    else
                    {
                        this.vueloSeleccionado.Avion.CapacidadBodega -= this.pasajeroSeleccionado.Equipajes[0].Peso;
                        if (this.vueloSeleccionado.Avion.CapacidadBodega < 0)
                        {
                            this.vueloSeleccionado.Avion.CapacidadBodega += this.pasajeroSeleccionado.Equipajes[0].Peso;
                            validar = false;
                        }
                    }
                }

                if ((this.pasajeroSeleccionado.Premium == false && this.vueloSeleccionado.CantidadAsientosDispTurista > 0) || (this.pasajeroSeleccionado.Premium && this.vueloSeleccionado.CantidadAsientosDispPremium > 0))
                {
                    if (validar)
                    {
                        this.vueloSeleccionado.Pasajeros.Add(this.pasajeroSeleccionado);
                        this.pasajeroSeleccionado.Agregado = true;
                        this.vueloSeleccionado.RestarAsientos(this.pasajeroSeleccionado);

                        Archivos.SerealizarDatos(this.pasajeros, Archivos.pathPasajeros);
                        Archivos.SerealizarVuelos(this.vuelos);
                        this.cerrar = true;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show($"El peso de equipaje excede el limite de capacidad de peso.\n Capacidad disponible:{this.vueloSeleccionado.Avion.CapacidadBodega}kg");
                    }
                }
                else
                {
                    if (this.pasajeroSeleccionado.Premium)
                    {
                        MessageBox.Show("Ya no hay asientos para la clase: premium");
                    }
                    else
                    {
                        MessageBox.Show("Ya no hay asientos para la clase: turista");
                    }
                }
            }
        }

        private void btnEquipaje_Click(object sender, EventArgs e)
        {
            string mensaje;
            if (this.pasajeroSeleccionado is not null)
            {
                mensaje = ($"{this.pasajeroSeleccionado.Equipajes[0]} ");

                if (this.pasajeroSeleccionado.Equipajes.Count > 1)
                {
                    mensaje += $"{this.pasajeroSeleccionado.Equipajes[1]}";
                }
                MessageBox.Show(mensaje);
            }
        }

        private void ActualizarLista<T>(List<T> listaDatos)
        {
            this.dtgvPasajerosDisponibles.DataSource = null;
            this.dtgvPasajerosDisponibles.DataSource = listaDatos;
        }
    }
}
