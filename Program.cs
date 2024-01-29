using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratica_D1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Dipendente nome1 = new Dipendente(); 
            nome1.Nome = "Alessandro ";

            Dipendente cognome1 = new Dipendente();
            cognome1.Cognome = "Aucone ";

            Dipendente reddito = new Dipendente();
            reddito.Reddito = "30000 ";

            Console.WriteLine("Nome1: " + nome1.Nome);
            Console.WriteLine("Cognome1: " + cognome1.Cognome);
            Console.WriteLine("Reddito: " + reddito.Reddito);


            Animale cane1 = new Animale();
            cane1.Specie = "Cane ";

            Animale cane2 = new Animale();
            cane2.Razza = "Carlino ";


            Console.WriteLine("Cane1: " + cane1.Specie);
            Console.WriteLine("Cane2: " + cane2.Razza);

            Veicolo auto1 = new Veicolo();
            auto1.Tipo = "Automobile";

            Veicolo auto2 = new Veicolo();
            auto2.Marca = "Skoda";

            Console.WriteLine("Auto1: " + auto1.Tipo);
            Console.WriteLine("Auto2: " +  auto2.Marca);

            Atleta atleta1 = new Atleta();
            atleta1.FirstName = "Massimo";

            Atleta atleta2 = new Atleta();
            atleta1.LastName = "Marianella";

            Console.WriteLine("FirstName1: " + atleta1.FirstName);
            Console.WriteLine("LastName1: " +  atleta2.LastName);
            string MessaggioAtleta = atleta1.CodiceTessera(1000);
            Console.WriteLine(MessaggioAtleta);
            Console.ReadLine();
        }
    }
}
