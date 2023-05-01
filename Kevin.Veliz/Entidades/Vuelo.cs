using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Vuelo
    {
        string _ciudadDePartida;
        string _ciudadDeDestino;
        DateTime _fechaDeVuelo;

        int _cantidadAsientosDispPremium;
        int _cantidadAsientosDispTurista;
        double _costoClasePremium;
        double _costoClaseTurista;
        DateTime _duracionVuelo;
        List<Cliente> _clientes;


        private Vuelo()
        {
            this._clientes = new List<Cliente>();
        }

        public Vuelo(string ciudadDePartida, string ciudadDeDestino, DateTime fechaDeVuelo, int cantidadAsientosDispPremium,  int cantidadAsientosDispTurista, double costoClasePremium, double costoClaseTurista, DateTime duracionVuelo, List<Cliente> clientes) :this()
        {
            this._ciudadDePartida = ciudadDePartida;
            this._ciudadDeDestino = ciudadDeDestino;
            this._fechaDeVuelo = fechaDeVuelo;
            this._cantidadAsientosDispPremium = cantidadAsientosDispPremium;
            this._cantidadAsientosDispTurista = cantidadAsientosDispTurista;
            this._costoClasePremium = costoClasePremium;
            this._costoClaseTurista = costoClaseTurista;
            this._clientes = clientes;
        }


        public string CiudadDePartida
        {
            get { return this._ciudadDePartida; }
            set { this._ciudadDePartida = value; }
        }

        public string CiudadDeDestino
        {
            get { return this._ciudadDeDestino; }
            set { this._ciudadDeDestino = value; }
        }

        public DateTime FechaDeVuelo
        {
            get { return this._fechaDeVuelo; }
            set { this._fechaDeVuelo = value; }
        }

        public int CantidadAsientosDispPremium
        {
            get { return this._cantidadAsientosDispPremium; }
            set { this._cantidadAsientosDispPremium = value; }
        }

        public int CantidadAsientosDispTurista
        {
            get { return this._cantidadAsientosDispTurista; }
            set { this._cantidadAsientosDispTurista = value; }
        }

        public double CostoClasePremium
        {
            get { return this._costoClasePremium; }
            set { this._costoClasePremium  = value; }
        }

        public double CostoClaseTurista
        {
            get { return this._costoClaseTurista; }
            set { this._costoClaseTurista = value; }
        }

        public List<Cliente> Clientes
        {
            get { return this._clientes; }
            set { this._clientes = value; }
        }

    }
}
