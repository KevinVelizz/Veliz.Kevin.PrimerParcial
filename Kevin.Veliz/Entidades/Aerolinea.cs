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

        public static double CalcularPrecioTurista(Pasajero pasajero, string destino)
        {
            double valorPrecio;
            if (pasajero.Premium == false)
            {

            }

            return valorPrecio = 0;
        }
    }
}
