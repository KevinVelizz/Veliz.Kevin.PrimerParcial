using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using Entidades;

class Program
{
    static void Main(string[] args)
    {
        List<Usuario> usuarios = new List<Usuario>();
        string jsonFilePath = @"C:\Users\veliz\Desktop\Veliz.Kevin.PrimerParcial\Kevin.Veliz\MOCK_DATA.json";

        // Crear un JsonReader a partir del archivo JSON
        using (System.IO.StreamReader sr = new System.IO.StreamReader(jsonFilePath))
        {
            string json_str = sr.ReadToEnd();
            usuarios = (List<Usuario>)System.Text.Json.JsonSerializer.Deserialize(json_str, typeof(List<Usuario>));

            foreach (Usuario usuario in usuarios)
            {
                Console.WriteLine(usuario.nombre);
            }

        }
    }
}
