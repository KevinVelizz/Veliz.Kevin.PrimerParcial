using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using System.IO;
using System.Xml;
using System.Xml.Linq;
using System.Text.Json;

namespace Entidades
{
    public class Archivos
    {
        private static string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
        private static string folderPath = Path.Combine(Archivos.desktopPath, @"Veliz.Kevin.PrimerParcial\Kevin.Veliz\");
        private static string folderPathAux = Path.Combine(Archivos.desktopPath, @"Veliz.Kevin.PrimerParcial-main\Kevin.Veliz\");

        //Path Aeronaves.
        private static string pathAeronaves = Path.Combine(Archivos.folderPath + @"listaAeronaves.xml");
        private static string pathAeronavesAux = Path.Combine(Archivos.folderPathAux + @"listaAeronaves.xml");

        //Path Usuarios.
        private static string pathUsuario = Path.Combine(Archivos.folderPath + @"MOCK_DATA.json");
        private static string pathUsuarioAux = Path.Combine(Archivos.folderPathAux + @"MOCK_DATA.json");

        //Path Viajeros.
        private static string pathViajeros = Path.Combine(Archivos.folderPath + @"listaViajeros.xml");
        private static string pathViajerosAux = Path.Combine(Archivos.folderPathAux + @"listaViajeros.xml");

        private static string pathVuelos = Path.Combine(Archivos.folderPath + @"listaVuelos.xml");
        private static string pathVuelosAux = Path.Combine(Archivos.folderPathAux + @"listaVuelos.xml");

        public static void SerealizarAeronaves(List<Aeronave> aeronaves)
        {
            string pathAux = "";
            if (File.Exists(Archivos.pathAeronaves))
            {
                pathAux = Archivos.pathAeronaves;
            }
            else if (File.Exists(Archivos.pathAeronavesAux))
            {
                pathAux = Archivos.pathAeronavesAux;
            }

            try
            {
                using (XmlTextWriter writer = new XmlTextWriter(pathAux, Encoding.UTF8))
                {
                    XmlSerializer ser = new XmlSerializer((typeof(List<Aeronave>)));
                    ser.Serialize(writer, aeronaves);
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
            string pathAux = "";
            if (File.Exists(Archivos.pathAeronaves))
            {
                pathAux = Archivos.pathAeronaves;
            }
            else if (File.Exists(Archivos.pathAeronavesAux))
            {
                pathAux = Archivos.pathAeronavesAux;
            }

            try
                {
                    using (XmlTextReader sr = new XmlTextReader(pathAux))
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
            string pathAux = "";
            if (File.Exists(Archivos.pathUsuario))
            {
                pathAux = Archivos.pathUsuario;
            }
            else if (File.Exists(Archivos.pathUsuarioAux))
            {
                pathAux = Archivos.pathUsuarioAux;
            }

            List<Usuario> usuarios = new();
            try
            {
                // Crear un JsonReader a partir del archivo JSON
                using (StreamReader sr = new StreamReader(pathAux))
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

        public static void SerealizarViajeros(List<Pasajero> pasajeros)
        {
            string pathAux = "";
            if (File.Exists(Archivos.pathViajeros))
            {
                pathAux = Archivos.pathViajeros;
            }
            else if (File.Exists(Archivos.pathViajerosAux))
            {
                pathAux = Archivos.pathViajerosAux;
            }

            try
            {
                using (XmlTextWriter writer = new XmlTextWriter(pathAux, Encoding.UTF8))
                {
                    XmlSerializer ser = new XmlSerializer((typeof(List<Pasajero>)));
                    ser.Serialize(writer, pasajeros);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"ERROR:{ex.Message} - {ex.StackTrace}");
            }
        }

        public static List<Pasajero> DeserealizarPasajeros()
        {

            string pathAux = "";
            if (File.Exists(Archivos.pathViajeros))
            {
                pathAux = Archivos.pathViajeros;
            }
            else if (File.Exists(Archivos.pathViajerosAux))
            {
                pathAux = Archivos.pathViajerosAux;
            }
            List<Pasajero> listaPasajerosXML = new List<Pasajero>();
            try
            {
                using (XmlTextReader sr = new XmlTextReader(pathAux))
                {
                    XmlSerializer serializer = new XmlSerializer((typeof(List<Pasajero>)));
                    listaPasajerosXML = serializer.Deserialize(sr) as List<Pasajero> ?? new();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"ERROR: {ex.Message} - {ex.StackTrace}");
            }
            
            
            return listaPasajerosXML;
        }

        public static void SerealizarVuelos(List<Vuelo> vuelos)
        {
            string pathAux = "";
            if (File.Exists(Archivos.pathVuelos))
            {
                pathAux = Archivos.pathVuelos;
            }
            else if (File.Exists(Archivos.pathVuelosAux))
            {
                pathAux = Archivos.pathVuelosAux;
            }

            try
            {
                using (XmlTextWriter writer = new XmlTextWriter(pathAux, Encoding.UTF8))
                {
                    XmlSerializer ser = new XmlSerializer((typeof(List<Vuelo>)));
                    ser.Serialize(writer, vuelos);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"ERROR:{ex.Message} - {ex.StackTrace}");
            }
        }

        public static List<Vuelo> DeserealizarVuelos()
        {

            string pathAux = "";
            if (File.Exists(Archivos.pathVuelos))
            {
                pathAux = Archivos.pathVuelos;
            }
            else if (File.Exists(Archivos.pathVuelosAux))
            {
                pathAux = Archivos.pathVuelosAux;
            }

            List<Vuelo> listaVuelosXML = new List<Vuelo>();
            if (File.Exists(Archivos.pathVuelos))
            {
                try
                {
                    using (XmlTextReader sr = new XmlTextReader(pathAux))
                    {
                        XmlSerializer serializer = new XmlSerializer((typeof(List<Vuelo>)));
                        listaVuelosXML = serializer.Deserialize(sr) as List<Vuelo> ?? new();
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
            return listaVuelosXML;
        }
    }
}
