using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Pasajero : Persona
    {
        private int dni;
        private int edad;
        private Dictionary<string, double> equipajes;
        private bool premium;

        private Pasajero()
        {
            this.equipajes = new Dictionary<string, double>();
        }

        public Pasajero(string nombre, string apellido, int dni, int edad, Dictionary<string, double> equipajes, bool premium) : base(nombre,apellido)
        {
            this.dni = dni;
            this.edad = edad;
            this.equipajes = equipajes;
            this.premium = premium;
        }

        public int Dni
        {
            get { return this.dni; }
            set { this.dni = value; }
        }

        public int Edad
        {
            get { return this.edad; }
            set { this.edad = value; }
        }

        public Dictionary<string, double> Equipajes
        {
            get { return this.equipajes; }
            set { this.equipajes = value; }
        }

        public bool Premium
        {
            get { return this.premium; }
            set { this.premium = value; }
        }

        protected override string Informacion()
        {
            StringBuilder mensaje = new StringBuilder();
            mensaje.AppendLine($"{base.Mostrar()}");
            mensaje.AppendLine($"DNI: {this.dni}");
            mensaje.AppendLine($"Edad: {this.edad}");
            foreach (KeyValuePair<string, double> valores in this.equipajes)
            {
                mensaje.AppendLine($"{valores.Key} - {valores.Value}");
            }
            if (this.premium)
            {
                mensaje.AppendLine($"Clase: Premium");
            }
            else
            {
                mensaje.AppendLine("Clase: Turista");
            }
            return mensaje.ToString();
        }

        public override string ToString()
        {
            return this.Informacion();
        }
    }

}
