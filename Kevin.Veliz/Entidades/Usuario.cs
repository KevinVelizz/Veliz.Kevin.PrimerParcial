using System.Reflection.Metadata;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Entidades
{
    public class Usuario
    {
        string _apellido;   
        string _nombre;   
        int _legajo;      
        string _correo;       
        string _clave; 
        string _perfil;

        public Usuario (string apellido, string nombre, int legajo, string correo, string clave, string perfil)
        {
            this._apellido = apellido;
            this._nombre = nombre;
            this._legajo = legajo;
            this._correo = correo;
            this._clave = clave;
            this._perfil = perfil;
        }

        [JsonPropertyName("apellido")]
        public string Apellido
        {
            get { return this._apellido; }
            set { this._apellido = value; }
        }

        [JsonPropertyName("nombre")]
        public string Nombre
        {
            get { return _nombre; }
            set { this._nombre = value; }
        }

        [JsonPropertyName("legajo")]
        public int Legajo
        {
            get { return this._legajo; }
            set { this._legajo = value; }
        }

        [JsonPropertyName("correo")]
        public string Correo
        {
            get { return this._correo; }
            set { this._correo = value;}
        }

        [JsonPropertyName("clave")]
        public string Clave
        {
            get { return _clave; }
            set { this._clave = value; }
        }

        [JsonPropertyName("perfil")]
        public string Perfil
        {
            get { return this._perfil; }
            set { this._perfil = value; }
        }

    }
}