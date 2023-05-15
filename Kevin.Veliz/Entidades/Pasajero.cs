using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Entidades
{
    public class Pasajero : Persona
    {
        private int dni;
        private int edad;
        private List<Equipaje> equipajes;
        private bool premium;
        private bool equipajeDeMano;
        private bool agregado;
        private bool enVuelo;
        private bool llego;
        private bool modificado;
        private Pasajero()
        {
            this.equipajes = new List<Equipaje>();
            this.enVuelo = false;
            this.llego = false;
        }

        public Pasajero(string nombre, string apellido, int dni, int edad, List<Equipaje> equipajes, bool premium, bool equipajeDeMano) : base(nombre,apellido)
        {
            this.dni = dni;
            this.edad = edad;
            this.equipajes = equipajes;
            this.premium = premium;
            this.equipajeDeMano = equipajeDeMano;

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

        public bool EquipajeDeMano
        {
            get { return this.equipajeDeMano; }
            set { this.equipajeDeMano = value; }
        }

        public bool EnVuelo
        {
            get { return this.enVuelo; }
            set { this.enVuelo = value; }
        }

        public bool Agregado
        {
            get { return this.agregado; }
            set { this.agregado = value; }
        }

        public bool Llego
        {
            get { return this.llego; }
            set { this.llego = value; }
        }

        [XmlIgnore]
        public bool Modificado
        {
            get { return this.modificado; }
            set { this.Modificado = value; }
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
                mensaje.AppendLine(equipajeClase.ToString());
            }
            if (this.premium)
            {
                mensaje.AppendLine($"Clase: Premium");
            }
            else
            {
                mensaje.AppendLine("Clase: Turista");
            }

            if (this.equipajeDeMano)
            {
                mensaje.AppendLine($"Equipaje de mano: Si - ");
            }    
            else
            {
                mensaje.AppendLine($"Equipaje de mano: No - ");
            }

            if (this.agregado)
            {
                mensaje.AppendLine("Agregado - ");
            }
            else
            {
                mensaje.AppendLine("No agregado - ");
            }
            if (this.llego)
            {
                mensaje.AppendLine("Llegó - ");
            }

            if (this.enVuelo)
            {
                mensaje.AppendLine("En vuelo");
            }
            else
            {
                mensaje.AppendLine("En espera");
            }
            
            

            return mensaje.ToString();
        }

        public string Mostrar()
        {
            StringBuilder mensaje = new StringBuilder();
            mensaje.AppendLine($"{base.Mostrar()} - ");
            mensaje.AppendLine($"DNI: {this.dni}");
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
