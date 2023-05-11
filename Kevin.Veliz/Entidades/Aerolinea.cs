using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

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

        public static DateTime CalcularDuracion(DateTime fechaViaje)
        {   
            Random numRandom = new Random();
            double num = numRandom.Next(2, 5);
            fechaViaje = fechaViaje.AddHours(num);
            return fechaViaje;
        }

        public static double CalcularPrecio(Pasajero pasajero, string destino, DateTime fechaViaje)
        {
            int duracion = CalcularDuracion(fechaViaje).Hour;

            double valorPrecio = 0;
            
            foreach (EnumEquipaje equipaje in Enum.GetValues(typeof(EnumVuelosNacionales)))
            {
                if (destino == equipaje.ToString())
                {
                    if (pasajero.Premium)
                    {
                        valorPrecio = (duracion * 50) * 135 / 100;
                        break;
                    }
                    else
                    {
                        valorPrecio = duracion * 50;
                    }
                }
            }

            foreach (EnumEquipaje equipaje in Enum.GetValues(typeof(EnumVuelosInternacionales)))
            {
                if (destino == equipaje.ToString())
                {
                    if (pasajero.Premium)
                    {
                        valorPrecio = (duracion * 50) * 135 / 100;
                        break;
                    }
                    else
                    {
                        valorPrecio = duracion * 50;
                    }
                }
            }
            return valorPrecio;
        }


        
    }
}
