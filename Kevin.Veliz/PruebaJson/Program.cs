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
        List<Equipaje> equipajes = new List<Equipaje>();

        Equipaje equipaje = new Equipaje();
        equipaje.Tipo = "De bodega";
        equipaje.Peso = 200;

        equipajes.Add(equipaje);
        
        Pasajero pasajero = new Pasajero("Kevin", "Veliz", 43898582, 21, equipajes, false);
        List<Pasajero> pasajeros = new List<Pasajero>();

        pasajeros.Add(pasajero);

        //Archivos.SerealizarViajeros(pasajeros);


        List<Aeronave> aeronaves = new List<Aeronave>();
        Aeronave aeronave = new Aeronave("666",11,4,true,false,5000);

        aeronaves.Add(aeronave);

        //Archivos.SerealizarAeronaves(aeronaves);


        List<Vuelo> vuelos = new List<Vuelo>();
        DateTime tiempoSalida = DateTime.Now;
        DateTime tiempoLLegada = Aerolinea.CalcularDuracion(tiempoSalida);
        Aeronave aeronave1 = new Aeronave("fli2", 120, 4, true, false, 4000);


        Vuelo vuelo = new Vuelo(EnumVuelosNacionales.Santa_Rosa.ToString(), EnumVuelosInternacionales.Recife.ToString(), tiempoSalida, aeronave1, tiempoLLegada, pasajeros, "no realizado");

        vuelos.Add(vuelo);

        Archivos.SerealizarVuelos(vuelos);
    }
}
