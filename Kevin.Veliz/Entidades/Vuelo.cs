﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Entidades
{
    public class Vuelo
    {
        private string ciudadDePartida;
        private string ciudadDeDestino;
        private DateTime fechaDeVuelo;
        private Aeronave avion;
        private int cantidadAsientosDispPremium;
        private int cantidadAsientosDispTurista;
        private double costoClasePremium;
        private double costoClaseTurista;
        private DateTime fechaDeLLegada;
        private List<Pasajero> pasajeros;
        private string estado;
        private double recaudacionTotal;
        private bool enViaje;
        private bool realizado;
        private EnumTipoVuelo tipo;

        private Vuelo()
        {
            this.pasajeros = new List<Pasajero>();
            this.fechaDeLLegada = new DateTime();
            this.costoClasePremium = 100;
            this.costoClaseTurista = 50;
        }
        
        public Vuelo(string ciudadDePartida, string ciudadDeDestino, DateTime fechaDeVuelo,Aeronave avion, DateTime fechaDeLLegada, string estado) :this()
        {
            this.ciudadDePartida = ciudadDePartida;
            this.ciudadDeDestino = ciudadDeDestino;
            this.fechaDeVuelo = fechaDeVuelo;
            this.avion = avion;
            this.fechaDeLLegada = fechaDeLLegada;
            this.estado = estado;
            this.InicializarTipo();
        }
        
        public string CiudadDePartida
        {
            get { return this.ciudadDePartida; }
            set { this.ciudadDePartida = value; }
        }
        public string CiudadDeDestino
        {
            get { return this.ciudadDeDestino; }
            set { this.ciudadDeDestino = value; }
        }

        public DateTime FechaDeVuelo
        {
            get { return this.fechaDeVuelo; }
            set { this.fechaDeVuelo = value; }
        }

        public int CantidadAsientosDispTurista
        {
            get
            {
                if (this.cantidadAsientosDispTurista == 0 && this.recaudacionTotal == 0)
                {
                    double aux = this.avion.CantidadAsientos - (20 * this.avion.CantidadAsientos / 100);
                    this.cantidadAsientosDispTurista = (int)Math.Floor(aux);
                    return this.cantidadAsientosDispTurista;
                }
                else
                {
                    return this.cantidadAsientosDispTurista;
                }
            }
            set { this.cantidadAsientosDispTurista = value; }
        }

        public int CantidadAsientosDispPremium
        {
            get 
            {
                if (this.cantidadAsientosDispPremium == 0 && this.recaudacionTotal == 0)
                {
                    double aux = this.avion.CantidadAsientos - (80 * this.avion.CantidadAsientos / 100);
                    this.cantidadAsientosDispPremium = (int)Math.Floor(aux);
                    return this.cantidadAsientosDispPremium;
                }
                else
                {
                    return this.cantidadAsientosDispPremium;
                }
            }
            set { this.cantidadAsientosDispPremium = value; }
        }

        public double CostoClasePremium
        {
            get {return this.costoClasePremium; }
            set { this.costoClasePremium  = value; }
        }

        public double CostoClaseTurista
        {
            get { return this.costoClaseTurista; }
            set { this.costoClaseTurista = value; }
        }
        
        public List<Pasajero> Pasajeros
        {
            get { return this.pasajeros; }
            set { this.pasajeros = value; }
        }

        public string Estado
        {
            get { return this.estado; }
            set { this.estado = value;}
        }

        public Aeronave Avion
        {
            get { return this.avion; }
            set { this.avion = value; }
        }
        
        public DateTime FechaDeLLegada
        {
            get { return this.fechaDeLLegada; }
            set { this.fechaDeLLegada = value; }
        }

        public double RecaudacionTotal
        {
            get { return this.recaudacionTotal; }
            set { this.recaudacionTotal = value; }
        }

        public bool EnViaje
        {
            get { return this.enViaje; }
            set { this.enViaje = value; }
        }

        public bool Realizado
        {
            get { return this.realizado; }
            set { this.realizado = value; }
        }

        public EnumTipoVuelo Tipo
        {
            get { return this.tipo; }
            set { this.tipo = value; }
        }

        public void RestarAsientos(Pasajero pasajero)
        {
            if (this.pasajeros.Count > 0)
            {
                foreach (Pasajero pasajeroAux in this.pasajeros)
                {
                    if (pasajeroAux ==  pasajero)
                    {
                        if (pasajero.Premium)
                        {
                            this.cantidadAsientosDispPremium--;
                            this.recaudacionTotal += this.CostoClasePremium * 1.21;
                        }
                        else
                        {
                            this.cantidadAsientosDispTurista--;
                            this.recaudacionTotal += this.CostoClaseTurista * 1.21;
                        }
                        break;
                    }
                    
                }
            }
        }

        public static bool operator ==(Vuelo vuelo, Vuelo vuelo1)
        {
            return vuelo.avion == vuelo1.avion;
        }

        public static bool operator !=(Vuelo vuelo, Vuelo vuelo1)
        {
            return !(vuelo == vuelo1);
        }

        public override bool Equals(object? obj)
        {
            bool retorno = false;
            if (obj is Vuelo)
            {
                if (this == (Vuelo)obj)
                {
                    retorno = true;
                }
            }
            return retorno;
        }

        public override int GetHashCode()
        {
            return Avion.Matricula.GetHashCode();  
        }


        public static bool operator ==(Vuelo vuelo, Pasajero pasajero)
        {
            return vuelo.pasajeros.Contains(pasajero);
        }

        public static bool operator !=(Vuelo vuelo, Pasajero pasajero)
        {
            return !(vuelo == pasajero);
        }

       
        public void VueloEnCurso()
        {
            if (DateTime.Now >= this.fechaDeVuelo && DateTime.Now < this.fechaDeLLegada && this.enViaje == false)
            {
                this.Estado = "En viaje";
                this.enViaje = true;

                foreach (Pasajero pasajero in this.pasajeros)
                {
                    pasajero.EnVuelo = true;
                }
            }
        }

        public void VueloRealizado()
        {
            if (DateTime.Now >= this.FechaDeLLegada && this.realizado == false)
            {
                this.estado = "Realizado";
                this.realizado = true;
                this.enViaje = false;
                foreach (Pasajero pasajero in this.pasajeros)
                {
                    pasajero.Agregado = false;
                    pasajero.EnVuelo = false;
                }
            }
        }

        private void InicializarTipo()
        {
            foreach (EnumVuelosNacionales clase in Enum.GetValues(typeof(EnumVuelosNacionales)))
            {
                if (Funcionalidades.ReemplazarGuionBajo(clase) == this.ciudadDeDestino)
                {
                    this.tipo = EnumTipoVuelo.Nacional;
                    break;
                }
            }

            if (this.tipo == null)
            {
                foreach (EnumVuelosInternacionales clase in Enum.GetValues(typeof(EnumVuelosInternacionales)))
                {
                   
                    if (Funcionalidades.ReemplazarGuionBajo(clase) == this.ciudadDeDestino)
                    {
                        this.tipo = EnumTipoVuelo.Internacional;
                        break;
                    }
                }
            }
        }

        private string Mostrar()
        {
            StringBuilder mensaje = new StringBuilder();
            mensaje.AppendLine($"Partida: {this.ciudadDePartida}");
            mensaje.AppendLine($"Destino: {this.ciudadDeDestino}");
            mensaje.AppendLine($"Fecha salida: {this.fechaDeVuelo}");
            mensaje.AppendLine($"Fecha llegada: {this.FechaDeLLegada}");
            mensaje.AppendLine($"Avion: {this.avion.Matricula}");
            mensaje.AppendLine($"Asientos premium: {this.CantidadAsientosDispPremium}");
            mensaje.AppendLine($"Asientos turista: {this.CantidadAsientosDispTurista}");
            mensaje.AppendLine($"Costo premium {this.costoClasePremium}");
            mensaje.AppendLine($"Costo turista {this.costoClaseTurista}");
            mensaje.AppendLine($"Estado: {this.estado}");
            return mensaje.ToString();
        }

        public string MostrarPasajeros()
        {
            StringBuilder mensaje = new StringBuilder();
            foreach (Pasajero pasajero in pasajeros)
            {
                mensaje.AppendLine(pasajero.ToString());
            }
            return mensaje.ToString();
        }

        public string Informacion()
        {
            StringBuilder mensaje = new StringBuilder();
            mensaje.AppendLine($"Partida: {this.ciudadDePartida} - ");
            mensaje.AppendLine($"Destino: {this.ciudadDeDestino} - ");
            mensaje.AppendLine($"Fecha salida: {this.fechaDeVuelo}");
            return mensaje.ToString();
        }

        public override string ToString()
        {
            return this.Mostrar();
        }



    }
}
