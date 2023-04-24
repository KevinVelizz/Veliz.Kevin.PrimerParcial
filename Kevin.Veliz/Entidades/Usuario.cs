namespace Entidades
{
    public class Usuario
    {
        string apellido;
        string nombre;
        int legajo;
        string correo;
        string clave;
        string perfil;

        public Usuario()
        {
            this.apellido = "Veliz";
            this.nombre = "Kevin";
            this.legajo = 1;
            this.correo = "velizkevin@gmail.com";
            this.clave = "1d3g3";
            this.perfil = "vendedor";
        }

        public string Apellido
        {
            get { return apellido; }
            set { this.apellido = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { this.nombre = value; }
        }

        public int Legajo
        {
            get { return legajo; }
            set { this.legajo = value;}
        }

        public string Correo
        {
            get { return correo; }
            set {  this.correo = value;}
        }

        public string Clave
        {
            get { return clave; }
            set { this.clave = value;}
        }

        public string Perfil
        {
            get { return perfil; }
            set { this.perfil = value; }
        }

        

        public string Mostar()
        {
            return $"{this.apellido} - {this.nombre} - {this.legajo} - {this.correo} - {this.clave} - {this.perfil}";
        }

    }
}