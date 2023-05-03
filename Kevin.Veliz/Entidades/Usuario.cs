using System.Reflection.Metadata;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Text;

namespace Entidades
{
    public class Usuario : Persona
    {
        private int legajo;      
        private string correo;       
        private string clave; 
        private string perfil;

        public Usuario (string apellido, string nombre, int legajo, string correo, string clave, string perfil) :base(nombre,apellido)
        {
            this.legajo = legajo;
            this.correo = correo;
            this.clave = clave;
            this.perfil = perfil;
        }

        [JsonPropertyName("legajo")]
        public int Legajo
        {
            get { return this.legajo; }
            set { this.legajo = value; }
        }

        [JsonPropertyName("correo")]
        public string Correo
        {
            get { return this.correo; }
            set { this.correo = value;}
        }

        [JsonPropertyName("clave")]
        public string Clave
        {
            get { return clave; }
            set { this.clave = value; }
        }

        [JsonPropertyName("perfil")]
        public string Perfil
        {
            get { return this.perfil; }
            set { this.perfil = value; }
        }

        protected override string Informacion()
        {
            StringBuilder mensaje = new StringBuilder();
            mensaje.AppendLine($"{base.Mostrar()}");
            mensaje.AppendLine($"Legajo: {this.legajo}");
            mensaje.AppendLine($"Correo: {this.correo}");
            mensaje.AppendLine($"Clave: {this.clave}");
            mensaje.AppendLine($"Perfil: {this.Perfil}");
            return mensaje.ToString();
        }

        public override string ToString()
        {
            return this.Informacion();
        }
    }
}