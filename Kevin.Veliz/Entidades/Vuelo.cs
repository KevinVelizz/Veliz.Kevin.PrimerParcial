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
        private DateTime duracionVuelo;
        private List<Pasajero> clientes;
        private string estado;

        private Vuelo()
        {
            this.clientes = new List<Pasajero>();
            this.duracionVuelo = new DateTime();
            this.costoClasePremium = 200;
            this.costoClaseTurista = 100;
        }

        public Vuelo(string ciudadDePartida, string ciudadDeDestino, DateTime fechaDeVuelo,Aeronave avion, DateTime duracionVuelo, List<Pasajero> clientes, string estado) :this()
        {
            this.ciudadDePartida = ciudadDePartida;
            this.ciudadDeDestino = ciudadDeDestino;
            this.fechaDeVuelo = fechaDeVuelo;
            this.avion = avion;
            this.clientes = clientes;
            this.estado = estado;
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
                if (avion.CantidadAsientos > 0)
                {
                    double aux = 80 * avion.CantidadAsientos / 100;
                    this.cantidadAsientosDispTurista = (int)Math.Round(aux,0);
                    return this.cantidadAsientosDispTurista;
                }
                return this.cantidadAsientosDispTurista = 0;
            }

            set { this.cantidadAsientosDispTurista = value; }
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

        public List<Pasajero> Clientes
        {
            get { return this.clientes; }
            set { this.clientes = value; }
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
        
        public DateTime DuracionVuelo
        {
            get { return this.duracionVuelo; }
            set { this.duracionVuelo = value; }
        }

        private string Mostrar()
        {
            StringBuilder mensaje = new StringBuilder();

            mensaje.AppendLine($"Ciudad de partida: {this.ciudadDePartida}");
            mensaje.AppendLine($"Ciudad de destino: {this.ciudadDeDestino}");
            mensaje.AppendLine($"Fecha de vuelo: {this.fechaDeVuelo}");
            mensaje.AppendLine($"Avion: {this.avion.Matricula}");
            mensaje.AppendLine($"Asientos clase premium: {this.cantidadAsientosDispPremium}");
            mensaje.AppendLine($"Asientos clase turista: {this.cantidadAsientosDispPremium}");
            mensaje.AppendLine($"Costo clase premium {this.costoClasePremium}");
            mensaje.AppendLine($"Costo clase turista {this.costoClaseTurista}");
            mensaje.AppendLine($"Duracion vuelo: {this.duracionVuelo}");
            mensaje.AppendLine($"Estado del vuelo: {this.estado}");

            return mensaje.ToString();
        }


        public override string ToString()
        {
            return this.Mostrar();
        }



    }
}
