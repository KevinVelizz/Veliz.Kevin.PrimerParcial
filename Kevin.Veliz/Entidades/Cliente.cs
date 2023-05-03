using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cliente : Persona
    {
        private string dni;
        private string edad;
        private static Dictionary<string, double> equipajes;
        private bool premium;

        static Cliente() 
        {
            Cliente.equipajes = new Dictionary<string, double>();
        }

    public Cliente(string nombre, string apellido, string dni, string edad, Dictionary<string, double> equipajes, bool premium) : base(nombre,apellido)
        {
            this.dni = dni;
            this.edad = edad;
            Cliente.equipajes = equipajes;
            this.premium = premium;
        }

        public string Dni
        {
            get { return this.dni; }
            set { this.dni = value; }
        }

        public string Edad
        {
            get { return this.edad; }
            set { this.edad = value; }
        }

        public static Dictionary<string, double> Equipajes
        {
            get { return Cliente.equipajes; }
            set { Cliente.equipajes = value; }
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
            foreach (KeyValuePair<string, double> valores in Cliente.equipajes)
            {
                mensaje.AppendLine($"{valores.Key} - {valores.Value}");
            }
            mensaje.AppendLine($"Premium: {this.premium}");
            return mensaje.ToString();
        }

        public override string ToString()
        {
            return this.Informacion();
        }
    }

}
