using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Cliente
    {
        string _nombres;
        string _apellidos;
        string _dni;
        string _edad;
        Dictionary<string, double> _equipajes;
        DateTime _fechaNacimiento;
        bool _vacunado;
        bool _premium;

        private Cliente()
        {
            this._vacunado = false;
            this._equipajes = new Dictionary<string, double>();
        }

    public Cliente(string nombres, string apellidos, string dni, string edad, Dictionary<string, double> equipajes, bool premium) : this()
        {
            this._nombres = nombres;
            this._apellidos = apellidos;
            this._dni = dni;
            this._edad = edad;
            this._equipajes = equipajes;
            this._premium = premium;
        }

        public Cliente (string nombres, string apellidos, string dni, string edad, Dictionary<string, double> equipajes, bool premium, DateTime fechaNacimiento, bool vacunado) :this(nombres,apellidos,dni,edad,equipajes,premium)
        {
            this._fechaNacimiento = fechaNacimiento;
            this._vacunado = vacunado;
        }

        public string Nombres
        {
            get { return this._nombres; }
            set { this._nombres = value; }
        }

        public string Apellidos
        {
            get { return this._apellidos; }
            set { this._apellidos = value; }
        }

        public string Dni
        {
            get { return this._dni; }
            set { this._dni = value; }
        }

        public string Edad
        {
            get { return this._edad; }
            set { this._edad = value; }
        }

        public Dictionary<string, double> Equipajes
        {
            get { return this._equipajes; }
            set { this._equipajes = value; }
        }

        public DateTime FechaNacimiento
        {
            get { return this._fechaNacimiento; }
            set { this._fechaNacimiento = value; }
        }

        public bool Vacunado
        {
            get { return this._vacunado; }
            set { this._vacunado = value;}
        }

    }

}
