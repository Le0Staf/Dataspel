using System;
using System.Security.Cryptography.X509Certificates;
using Dataspel;

namespace Dataspel
{
    class Program
    {
        static void Main(string[] args)
        {
            string search;

            Dataspel fortnite = new Dataspel("Multiplayer", "Shooter", "Fortnite");
            Dataspel ark = new Dataspel("Singleplayer", "Survival", "Ark");

            Console.WriteLine("Search for game: ");
            search = Console.ReadLine();

            foreach (Dataspel spel in new Dataspel[] { fortnite, ark })
            {
                if (search == spel.namn)
                {
                    Console.WriteLine("\nNamn: " + spel.namn + "\nGenre: " + spel.genre + "\nSpelarläge: " + spel.spelarläge);
                }
                else if (search != spel.namn)
                {
                    Console.Write("");
                }
            }
        }
    }
}