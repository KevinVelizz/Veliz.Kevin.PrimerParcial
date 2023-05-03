using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using Entidades;

class Program
{
    static void Main(string[] args)
    {
        List<Usuario> lista = Aerolinea.ListaUsuarios();
        
        //foreach (Usuario usario in lista)
        //{
        //    Console.WriteLine(usario.Perfil);  
        //}

        Dictionary<string,double> valija = new Dictionary<string,double>();

        valija.Add("De mano", 400);

        Cliente cliente = new Cliente("German", "Veliz","43898582","21",valija,false);

        //Console.WriteLine(cliente.ToString());
        Usuario usuario = new Usuario("Veliz", "Kevin", 24, "kevin@gmail.com", "12345678", "administrador");
        Console.WriteLine(usuario.ToString());
    }
}
