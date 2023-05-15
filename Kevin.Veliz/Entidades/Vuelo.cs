using System;
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
        private bool disponible;
        private double recaudacionTotal;
        private int index;

        private Vuelo()
        {
            this.pasajeros = new List<Pasajero>();
            this.fechaDeLLegada = new DateTime();
            this.costoClasePremium = 200;
            this.costoClaseTurista = 100;
            this.disponible = true;
        }
        
        public Vuelo(string ciudadDePartida, string ciudadDeDestino, DateTime fechaDeVuelo,Aeronave avion, DateTime fechaDeLLegada, string estado) :this()
        {
            this.ciudadDePartida = ciudadDePartida;
            this.ciudadDeDestino = ciudadDeDestino;
            this.fechaDeVuelo = fechaDeVuelo;
            this.avion = avion;
            this.fechaDeLLegada = fechaDeLLegada;
            this.estado = estado;
        }

        public int Index
        {
            get { return this.index; }
            set { this.index = value; }
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
                if (this.cantidadAsientosDispTurista == 0)
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
                if (this.cantidadAsientosDispPremium == 0)
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

        public void RestarAsientos()
        {
            if (this.pasajeros.Count > 0)
            {
                foreach (Pasajero pasajero in this.pasajeros)
                {
                    if (pasajero.Premium)
                    {
                        this.cantidadAsientosDispPremium--;
                        this.recaudacionTotal += this.CostoClasePremium;
                    }
                    else
                    {
                        this.cantidadAsientosDispTurista--;
                        this.recaudacionTotal += this.CostoClaseTurista;
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
