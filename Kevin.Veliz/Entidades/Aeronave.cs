using System.Text;

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
        private bool disponible;

        private Aeronave()
        {
            cantidadAsientos = 0;
            disponible = true;
        }

        public Aeronave(string matricula, int cantidadAsientos, int cantidadDeBanios, bool servicioInternet, bool servicioComida, double capacidadBodega) : this()
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
            set { this.servicioInternet = value; }
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

        public bool Disponible
        {
            get { return this.disponible; }
            set { this.disponible = value; }
        }

        public static bool operator ==(Aeronave aeronave, Aeronave aeronave1)
        {
            return aeronave.matricula == aeronave1.matricula;
        }

        public static bool operator !=(Aeronave aeronave, Aeronave aeronave1)
        {
            return !(aeronave == aeronave1);
        }

        public override bool Equals(object? obj)
        {
            bool retorno = false;
            if (obj is Aeronave)
            {
                if (this == (Aeronave)obj)
                {
                    retorno = true;
                }
            }
            return retorno;
        }

        public override int GetHashCode()
        {
            return this.matricula.GetHashCode();
        }

        public static explicit operator Aeronave(string infoAeronave)
        {
            string[] datos = infoAeronave.Split(',');
            string matricula = datos[0];
            int cantidadAsientos = int.Parse(datos[1]);
            int cantidadDeBanios = int.Parse(datos[2]);
            bool servicioInternet = bool.Parse(datos[3]);
            bool servicioComida = bool.Parse(datos[4]);
            double capacidadBodega = double.Parse(datos[5]);
            return new Aeronave(matricula, cantidadAsientos, cantidadDeBanios, servicioInternet, servicioComida, capacidadBodega);
        }

        public static implicit operator string(Aeronave aeronave)
        {
            string infoAeronave = $"{aeronave.matricula}, {aeronave.cantidadAsientos}, {aeronave.cantidadDeBanios}, {aeronave.servicioInternet}, {aeronave.servicioComida}, {aeronave.capacidadBodega}";
            return infoAeronave;
        }

        private string Infomacion()
        {
            StringBuilder mensaje = new StringBuilder();
            mensaje.AppendLine($"Matricula: {this.matricula} - ");
            mensaje.AppendLine($"Cantidad de asientos: {this.cantidadAsientos} - ");
            mensaje.AppendLine($"Cantidad de baños: {this.cantidadDeBanios} - ");
            if (this.servicioInternet)
            {
                mensaje.AppendLine("Internet: Si - ");
            }
            else
            {
                mensaje.AppendLine("Internet: No - ");
            }
            if (this.servicioComida)
            {
                mensaje.AppendLine("Comida: Si - ");
            }
            else
            {
                mensaje.AppendLine("Comida: No - ");
            }
            mensaje.AppendLine($"Capacidad Bodega: {this.capacidadBodega} - ");

            if (this.disponible)
            {
                mensaje.AppendLine("Disponible");
            }
            else
            {
                mensaje.AppendLine("No disponible");
            }
            return mensaje.ToString();
        }

        public override string ToString()
        {
            return this.Infomacion();
        }
    }
}
