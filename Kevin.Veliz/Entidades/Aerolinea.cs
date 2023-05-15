using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Runtime.Intrinsics.X86;

namespace Entidades
{
    public class Aerolinea
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
            return aux;
        }

        public static double CalcularDuracion()
        {   
            Random numRandom = new Random();
            double duracion = numRandom.Next(2, 5);
            return duracion;
        }

        public static double CalcularPrecio(bool premium, string destino,double duracion)
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
    }
}
