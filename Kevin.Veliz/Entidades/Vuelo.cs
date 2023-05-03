using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        private DateTime duracionVuelo;
        private List<Cliente> clientes;

        private Vuelo()
        {
            this.clientes = new List<Cliente>();
            this.duracionVuelo = new DateTime();
        }

        public Vuelo(string ciudadDePartida, string ciudadDeDestino, DateTime fechaDeVuelo,Aeronave avion, int cantidadAsientosDispPremium,  int cantidadAsientosDispTurista, double costoClasePremium, double costoClaseTurista, DateTime duracionVuelo, List<Cliente> clientes) :this()
        {
            this.ciudadDePartida = ciudadDePartida;
            this.ciudadDeDestino = ciudadDeDestino;
            this.fechaDeVuelo = fechaDeVuelo;
            this.avion = avion;
            this.cantidadAsientosDispPremium = cantidadAsientosDispPremium;
            this.cantidadAsientosDispTurista = cantidadAsientosDispTurista;
            this.costoClasePremium = costoClasePremium;
            this.costoClaseTurista = costoClaseTurista;
            this.clientes = clientes;
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

        public int CantidadAsientosDispPremium
        {
            get { return this.cantidadAsientosDispPremium; }
            set { this.cantidadAsientosDispPremium = value; }
        }

        public int CantidadAsientosDispTurista
        {
            get { return this.cantidadAsientosDispTurista; }
            set { this.cantidadAsientosDispTurista = value; }
        }

        public double CostoClasePremium
        {
            get { return this.costoClasePremium; }
            set { this.costoClasePremium  = value; }
        }

        public double CostoClaseTurista
        {
            get { return this.costoClaseTurista; }
            set { this.costoClaseTurista = value; }
        }

        public List<Cliente> Clientes
        {
            get { return this.clientes; }
            set { this.clientes = value; }
        }

    }
}
