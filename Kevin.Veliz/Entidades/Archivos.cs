using System.Text;
using System.Xml.Serialization;
using System.Xml;
using System.Text.Json;

namespace Entidades
{
    public static class Archivos
    {
        public static string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
        public static string folderPath = Path.Combine(Archivos.desktopPath, @"Veliz.Kevin.PrimerParcial\Kevin.Veliz\");

        //Path Aeronaves.
        public static string pathAeronaves = Path.Combine(Archivos.folderPath + @"listaAeronaves.xml");

        //Path Usuarios.
        public static string pathUsuario = Path.Combine(Archivos.folderPath + @"MOCK_DATA.json");

        //Path Viajeros.
        public static string pathPasajeros = Path.Combine(Archivos.folderPath + @"listaViajeros.xml");

        public static string pathVuelos = Path.Combine(Archivos.folderPath + @"listaVuelos.json");

        public static string pathDataUsuario = Path.Combine(Archivos.folderPath + @"usuarios.log");

        public static void SerealizarDatosUser(Usuario usuario)
        {
            if (usuario != null)
            {
                using TextWriter writer = new StreamWriter(Archivos.pathDataUsuario, true);
                writer.Write($"{DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss")} - {usuario}");
            }
        }

        public static void SerealizarDatos <T>(List<T> lista, string path)
        {
            try
            {
                using (XmlTextWriter writer = new XmlTextWriter(path, Encoding.UTF8))
                {
                    XmlSerializer ser = new XmlSerializer((typeof(List<Aeronave>)));
                    ser.Serialize(writer, lista);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"ERROR:{ex.Message} - {ex.StackTrace}");
            }
        }
        public static List<Aeronave> DeserealizarAeronaves()
        {
            List<Aeronave> listXML = new List<Aeronave>();
            try
                {
                    using (XmlTextReader sr = new XmlTextReader(Archivos.pathAeronaves))
                    {
                        XmlSerializer serializer = new XmlSerializer((typeof(List<Aeronave>)));
                        listXML = serializer.Deserialize(sr) as List<Aeronave> ?? new();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"ERROR: {ex.Message} - {ex.StackTrace}");
                }
            return listXML;
        }

        public static List<Usuario> DeserealizarUsuarios()
        {
            List<Usuario> usuarios = new();
            if (File.Exists(Archivos.pathUsuario))
            {
                try
                {
                    using (StreamReader sr = new StreamReader(Archivos.pathUsuario))
                    {
                        string json_str = sr.ReadToEnd();
                        usuarios = JsonSerializer.Deserialize(json_str, typeof(List<Usuario>)) as List<Usuario> ?? new(); // el operador as es para expresiones que devuelven nulos. ?? me pregunto si es nulo
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error cargando lista usuarios: {ex.Message}\n {ex.StackTrace}"); // StackTrace la pila de llamados. cual fue la jerarquia del error. 
                }
            }
            else
            {
                Console.WriteLine("No se encontroó el path");
            }
            return usuarios;
        }

        public static List<Pasajero> DeserealizarPasajeros()
        {
            List<Pasajero> listaPasajerosXML = new List<Pasajero>();

            if (File.Exists(Archivos.pathPasajeros))
            {
                try
                {
                    using (XmlTextReader sr = new XmlTextReader(Archivos.pathPasajeros))
                    {
                        XmlSerializer serializer = new XmlSerializer((typeof(List<Pasajero>)));
                        listaPasajerosXML = serializer.Deserialize(sr) as List<Pasajero> ?? new();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"ERROR: {ex.Message} - {ex.StackTrace}");
                }
            }
            return listaPasajerosXML;
        }

        public static void SerealizarVuelos(List<Vuelo> vuelos)
        {
            try
            {
                using (TextWriter writer = new StreamWriter(Archivos.pathVuelos))
                {
                    writer.Write(JsonSerializer.Serialize(vuelos));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"ERROR:{ex.Message} - {ex.StackTrace}");
            }
        }

        public static List<Vuelo> DeserealizarVuelos()
        {
            List<Vuelo> listaVuelos = new List<Vuelo>();
            if (File.Exists(Archivos.pathVuelos))
            {
                try
                {
                    using (TextReader sr = new StreamReader(Archivos.pathVuelos))
                    {
                        listaVuelos = JsonSerializer.Deserialize<List<Vuelo>>(sr.ReadToEnd()) ?? new();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"ERROR: {ex.Message} - {ex.StackTrace}");
                }
            }
            else
            {
                Console.WriteLine("No existe el archivo");
            }
            return listaVuelos;
        }
    }
}
