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
        const string pathUsuario = @"C:\Users\veliz\Desktop\Veliz.Kevin.PrimerParcial\Kevin.Veliz\MOCK_DATA.json";

        //requerimientos de negocio.
        public static Usuario? Login(string email, string clave) 
        {
            List<Usuario> lista = ListaUsuarios();
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

        public static List<Usuario> ListaUsuarios()
        {
            List<Usuario> usuarios = new ();
            try
            {
                // Crear un JsonReader a partir del archivo JSON
                using (StreamReader sr = new StreamReader(pathUsuario))
                {
                    string json_str = sr.ReadToEnd();

                    usuarios = JsonSerializer.Deserialize(json_str, typeof(List<Usuario>)) as List<Usuario> ?? new(); // el operador as es para expresiones que devuelven nulos. ?? me pregunto si es nulo
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error cargando lista usuarios: {ex.Message}\n {ex.StackTrace}"); // StackTrace la pila de llamados. cual fue la jerarquia del error. 
            }
            return usuarios;
        }
    }
}
