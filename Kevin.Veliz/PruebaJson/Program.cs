using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using Entidades;
using System.Text;
using System.Xml.Serialization;
using System.Xml;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, double> equipaje = new Dictionary<string, double>();
        Dictionary<string, double> equipaje1 = new Dictionary<string, double>();
        equipaje.Add("de mano", 200);
        equipaje1.Add("de bodega", 400);

        List<Pasajero> pasajeros = new List<Pasajero>();

        DateTime numero = DateTime.Now;

        numero = Aerolinea.CalcularDuracion();

        Console.WriteLine(numero);

    }
}
