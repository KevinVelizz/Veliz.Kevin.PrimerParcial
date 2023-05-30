using System.Text.RegularExpressions;

namespace Entidades
{
    public static class Funcionalidades
    {
        public static Usuario? Login(string email, string clave)
        {
            List<Usuario> lista = Archivos.DeserealizarUsuarios();
            Usuario? aux = null;

            foreach (Usuario user in lista)
            {
                if (user.Correo == email && user.Clave == clave)
                {
                    aux = user;
                }
            }
            Archivos.SerealizarDatosUser(aux);
            return aux;
        }

        public static double CalcularDuracionNacional()
        {
            Random numRandom = new Random();
            double duracion = numRandom.Next(2, 5);
            return duracion;
        }

        public static double CalcularDuracionInternacional()
        {
            Random numRandom = new Random();
            double duracion = numRandom.Next(8, 13);
            return duracion;
        }

        public static string ReemplazarGuionBajo<T>(T elemento)
        {
            return elemento.ToString().Replace("_", " ");
        }

        public static double CalcularPrecio(bool premium, string destino, double duracion)
        {
            double valorPrecio = 0;
            string aux;
            foreach (EnumVuelosNacionales des1 in Enum.GetValues(typeof(EnumVuelosNacionales)))
            {
                aux = des1.ToString();
                aux = aux.Replace("_", " ");

                if (destino == aux)
                {
                    if (premium)
                    {
                        valorPrecio = (duracion * 50) * 1.35;
                    }
                    else
                    {
                        valorPrecio = duracion * 50;
                    }
                    break;
                }
            }

            foreach (EnumVuelosInternacionales des in Enum.GetValues(typeof(EnumVuelosInternacionales)))
            {
                aux = des.ToString();
                aux = aux.Replace("_", " ");

                if (destino == aux)
                {
                    if (premium)
                    {
                        valorPrecio = (duracion * 100) * 1.35;
                    }
                    else
                    {
                        valorPrecio = duracion * 100;
                    }
                    break;
                }
            }
            return valorPrecio;
        }


        public static string DestinoMasSeleccionado(List<Vuelo> listaVuelos)
        {
            string? destinoFavorito = "";

            if (listaVuelos.Count > 0 && listaVuelos is not null)
            {
                destinoFavorito = listaVuelos.GroupBy(v => v.CiudadDeDestino).OrderByDescending(g => g.Count()).Select(g => g.Key).FirstOrDefault();

            }
            return destinoFavorito ?? "";
        }

    }
}
