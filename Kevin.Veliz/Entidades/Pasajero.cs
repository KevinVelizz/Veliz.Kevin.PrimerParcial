using System.Text;

namespace Entidades
{
    public class Pasajero : Persona
    {
        private int dni;
        private int edad;
        private List<Equipaje>? equipajes;
        private bool premium;
        private bool equipajeDeMano;
        private bool agregado;
        private bool enVuelo;
        private bool vacunado;

        public Pasajero()
        {
            this.equipajes = new List<Equipaje>();
        }

        public Pasajero(string nombre, string apellido, int dni, int edad, List<Equipaje> equipajes, bool premium, bool equipajeDeMano) : base(nombre,apellido)
        {
            this.dni = dni; 
            this.edad = edad;
            this.equipajes = equipajes;
            this.premium = premium;
            this.equipajeDeMano = equipajeDeMano;
        }

        public Pasajero(string nombre, string apellido, int dni, int edad, List<Equipaje> equipajes, bool premium, bool equipajeDeMano, bool vacunado) : this(nombre, apellido, dni, edad, equipajes, premium, equipajeDeMano)
        {
            this.vacunado = vacunado;
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
            get { return this.equipajes ?? new List<Equipaje>(); }
            set { this.equipajes = value; }
        }

        public Equipaje this[int index]
        {
            get
            {
                return this.equipajes[index];
              
            }
            set
            {
                this.equipajes[index] = value;
            }
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

        public bool Vacunado
        {
            get { return this.vacunado; }
            set { this.vacunado = value; }
        }
        public void AgregarEquipaje(Equipaje equipaje)
        {
            if (this.equipajes != null)
            {
                this.equipajes.Add(equipaje);
            }
        }

        public void AgregarEquipaje(string descripcion, double peso)
        {
            Equipaje equipaje = new Equipaje(descripcion, peso);
            if (this.equipajes != null)
            {
                this.equipajes.Add(equipaje);
            }
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

        public override int GetHashCode()
        {
            return this.dni.GetHashCode();
        }

        protected override string Informacion()
        {
            StringBuilder mensaje = new StringBuilder();
            mensaje.AppendLine($"{base.Mostrar()}");
            mensaje.AppendLine($"DNI: {this.dni}");
            mensaje.AppendLine($"Edad: {this.edad}");

            if (this.equipajes != null )
            {
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
            }    

            if (this.equipajeDeMano)
            {
                mensaje.AppendLine($"Equipaje de mano: Si  ");
            }    
            else
            {
                mensaje.AppendLine($"Equipaje de mano: No  ");
            }

            if (this.agregado)
            {
                mensaje.AppendLine("Agregado  ");
            }
            else
            {
                mensaje.AppendLine("No agregado  ");
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


        public override string ToString()
        {
            return this.Informacion();
        }
    }
}
