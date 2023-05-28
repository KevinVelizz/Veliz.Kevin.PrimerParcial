using System.Text;
using System.Text.Json.Serialization;

namespace Entidades
{
    public abstract class Persona
    {
        private string? nombre;
        private string? apellido;

        public Persona() {}
        public Persona(string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }

        [JsonPropertyName("nombre")]
        public string Nombre
        {
            get { return this.nombre ?? ""; }
            set { this.nombre = value; }
        }

        [JsonPropertyName("apellido")]
        public string Apellido
        {
            get { return this.apellido ?? ""; }
            set { this.apellido = value;}
        }

        protected abstract string Informacion();

        protected virtual string Mostrar()
        {
            StringBuilder mensaje = new StringBuilder();
            mensaje.AppendLine($"Nombre: {this.nombre}");
            mensaje.Append($"Apellido: {this.apellido}");
            return mensaje.ToString();
        }
    }
}
