using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Vuelo
    {
        private Enum ciudadDePartida;
        private Enum ciudadDeDestino;
        private DateTime fechaDeVuelo;
        private Aeronave avion;
        private int cantidadAsientosDispPremium;
        private int cantidadAsientosDispTurista;
        private double costoClasePremium;
        private double costoClaseTurista;
        private DateTime duracionVuelo;
        private List<Pasajero> clientes;
        private string estado;

        private Vuelo()
        {
            this.clientes = new List<Pasajero>();
            this.duracionVuelo = new DateTime();
        }

        public Vuelo(Enum ciudadDePartida, Enum ciudadDeDestino, DateTime fechaDeVuelo,Aeronave avion, DateTime duracionVuelo, List<Pasajero> clientes) :this()
        {
            this.ciudadDePartida = ciudadDePartida;
            this.ciudadDeDestino = ciudadDeDestino;
            this.fechaDeVuelo = fechaDeVuelo;
            this.avion = avion;
            this.clientes = clientes;
        }

        public Enum CiudadDePartida
        {
            get { return this.ciudadDePartida; }
            set { this.ciudadDePartida = value; }
        }

        public Enum CiudadDeDestino
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
                if (avion.CantidadAsientos > 0)
                {
                    double aux = 80 * avion.CantidadAsientos / 100;
                    this.cantidadAsientosDispTurista = (int)Math.Round(aux,0);
                    return this.cantidadAsientosDispTurista;
                }
                return this.cantidadAsientosDispTurista = 0;
            }
        }

        public int CantidadAsientosDispPremium
        {
            get 
            {
                if (avion.CantidadAsientos > 0)
                {
                    double aux = 20 * avion.CantidadAsientos / 100;
                    this.cantidadAsientosDispPremium = (int)Math.Round(aux, 0);
                    return this.cantidadAsientosDispPremium;
                }
                return this.cantidadAsientosDispPremium = 0;
            }
        }

        public double CostoClasePremium
        {
            get {return this.costoClasePremium; }
            private set { this.costoClasePremium  = value; }
        }

        public double CostoClaseTurista
        {
            get { return this.costoClaseTurista; }
            private set { this.costoClaseTurista = value; }
        }

        public List<Pasajero> Clientes
        {
            get { return this.clientes; }
            private set { this.clientes = value; }
        }
    }
}
