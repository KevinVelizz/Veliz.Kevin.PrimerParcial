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

        //Path Aeronaves.
        private static string pathAeronaves = Path.Combine(Archivos.folderPath + @"listaAeronaves.xml");

        //Path Usuarios.
        private static string pathUsuario = Path.Combine(Archivos.folderPath + @"MOCK_DATA.json");

        //Path Viajeros.
        private static string pathViajeros = Path.Combine(Archivos.folderPath + @"listaViajeros.xml");
        public static void SerealizarAeronaves(List<Aeronave> aeronaves)
        {
            try
            {
                using (XmlTextWriter writer = new XmlTextWriter(Archivos.pathAeronaves, Encoding.UTF8))
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
            if (File.Exists(Archivos.pathAeronaves))
            {
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
            }
            else
            {
                Console.WriteLine("No existe el archivo");
            }
            return listXML;
        }

        public static List<Usuario> DeserealizarUsuarios()
        {
            List<Usuario> usuarios = new();
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

        public static void SerealizarViajeros(List<Pasajero> pasajeros)
        {
            try
            {
                using (XmlTextWriter writer = new XmlTextWriter(Archivos.pathAeronaves, Encoding.UTF8))
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
            List<Pasajero> listaXML = new List<Pasajero>();
            if (File.Exists(Archivos.pathAeronaves))
            {
                try
                {
                    using (XmlTextReader sr = new XmlTextReader(Archivos.pathAeronaves))
                    {
                        XmlSerializer serializer = new XmlSerializer((typeof(List<Pasajero>)));
                        listaXML = serializer.Deserialize(sr) as List<Pasajero> ?? new();
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
            return listaXML;
        }
    }
}
