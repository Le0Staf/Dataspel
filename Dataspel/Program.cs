using System;
using System.Security.Cryptography.X509Certificates;
using Dataspel;

namespace Dataspel
{
    class Program
    {
        static void Main()
        {
            string search;

            Dataspel fortnite = new("Multiplayer", "Shooter", "Fortnite");
            Dataspel ark = new("Singleplayer", "Survival", "Ark");
            Dataspel csgo = new("Multiplayer", "Shooter", "Csgo");
            Dataspel amongus = new("Multiplayer", "Strategy", "Among us");

            Console.WriteLine("Search for game: ");
            search = Console.ReadLine();

            foreach (Dataspel spel in new Dataspel[] { fortnite, ark, csgo,  })
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