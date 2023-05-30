using System.Text;

namespace Entidades
{
    public class Equipaje
    {
        public string? Tipo { get; set; }
        public double Peso { get; set; }

        public Equipaje() { }

        public Equipaje(string tipo, double peso)
        {
            this.Tipo = tipo;
            this.Peso = peso;
        }

        private string Informacion()
        {
            StringBuilder mensaje = new StringBuilder();
            mensaje.AppendLine($"Tipo: {this.Tipo} ");
            mensaje.AppendLine($"Peso: {this.Peso} ");
            return mensaje.ToString();
        }

        public override string ToString()
        {
            return this.Informacion();
        }
    }
}
