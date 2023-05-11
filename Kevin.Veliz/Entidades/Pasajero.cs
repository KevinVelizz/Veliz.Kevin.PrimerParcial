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
        private List<Equipaje> equipajes;
        private bool premium;

        private Pasajero()
        {
            this.equipajes = new List<Equipaje>();
        }

        public Pasajero(string nombre, string apellido, int dni, int edad, List<Equipaje> equipajes, bool premium) : base(nombre,apellido)
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

        public List<Equipaje> Equipajes
        {
            get { return this.equipajes; }
            set { this.equipajes = value; }
        }

        public bool Premium
        {
            get { return this.premium; }
            set { this.premium = value; }
        }
        public static bool operator ==(Pasajero pasajero1, Pasajero pasajero2)
        {
            return pasajero1.dni == pasajero2.dni;
        }

        public static bool operator !=(Pasajero pasajero1, Pasajero pasajero2)
        {
            return !(pasajero1 == pasajero2);
        }

        public override bool Equals(object? obj)
        {
            bool retorno = false;
            if (obj is Pasajero)
            {
                if (this == (Pasajero)obj)
                {
                    retorno = true;
                }
            }
            return retorno;
        }

        protected override string Informacion()
        {
            StringBuilder mensaje = new StringBuilder();
            mensaje.AppendLine($"{base.Mostrar()}");
            mensaje.AppendLine($"DNI: {this.dni}");
            mensaje.AppendLine($"Edad: {this.edad}");
            foreach (Equipaje equipajeClase in this.equipajes)
            {
                mensaje.AppendLine($"{equipajeClase.Tipo} - {equipajeClase.Peso}");
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
