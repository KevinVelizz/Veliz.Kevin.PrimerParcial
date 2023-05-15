using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Aeronave
    {
        private string matricula;
        private int cantidadAsientos;
        private int cantidadDeBanios;
        private bool servicioInternet;
        private bool servicioComida;
        private double capacidadBodega;

        private Aeronave()
        {
            cantidadAsientos = 0;
        }

        public Aeronave(string matricula, int cantidadAsientos, int cantidadDeBanios, bool servicioInternet, bool servicioComida, double capacidadBodega)
        {
            this.matricula = matricula;
            this.cantidadAsientos = cantidadAsientos;
            this.cantidadDeBanios = cantidadDeBanios;
            this.servicioInternet = servicioInternet;
            this.servicioComida = servicioComida;
            this.capacidadBodega = capacidadBodega;
        }

        public string Matricula
        {
            get { return this.matricula; }
            set { this.matricula = value; }
        }

        public int CantidadAsientos
        {
            get { return this.cantidadAsientos; }
            set { this.cantidadAsientos = value; }
        }

        public int CantidadDeBanios
        {
            get { return this.cantidadDeBanios; }
            set { this.cantidadDeBanios = value; }
        }

        public bool ServicioInternet
        {
            get { return this.servicioInternet; }
            set { this.servicioInternet = value;}
        }

        public bool ServicioComida
        {
            get { return this.servicioComida; }
            set { this.servicioComida = value; }
        }

        public double CapacidadBodega
        {
            get { return this.capacidadBodega; }
            set { this.capacidadBodega = value; }
        }


        private string Infomacion()
        {
            StringBuilder mensaje = new StringBuilder();
            mensaje.AppendLine($"Matricula: {this.matricula} ");
            mensaje.AppendLine($"Cantidad de asientos: {this.cantidadAsientos} ");
            mensaje.AppendLine($"Cantidad de baños: {this.cantidadDeBanios} ");
            if (this.servicioInternet)
            {
                mensaje.AppendLine("Internet: Si");
            }
            else
            {
                mensaje.AppendLine("Internet: No");
            }
            if (this.servicioComida)
            {
                mensaje.AppendLine("Comida: Si ");
            }    
            else
            {
                mensaje.AppendLine("Comida: No ");
            }
            mensaje.AppendLine($"Capacidad Bodega: {this.capacidadBodega}");
            return mensaje.ToString();  
        }

        public override string ToString()
        {
            return this.Infomacion();
        }


    }
}
