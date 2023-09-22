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

            //Spel
            Dataspel fortnite = new("Multiplayer", "Shooter", "Fortnite");
            Dataspel ark = new("Singleplayer", "Survival", "Ark");
            Dataspel csgo = new("Multiplayer", "Shooter", "Csgo");
            Dataspel amongus = new("Multiplayer", "Strategy", "Among us");

            //Sök efter spel
            Console.WriteLine("Search for game (or type 'exit' to quit): ");
            search = Console.ReadLine();
            spel();

            void spel()
            {
                foreach (Dataspel spel in new Dataspel[] { fortnite, ark, csgo, amongus })
                {
                    if (search == spel.namn || search == spel.namn.ToLower())
                    {
                        Console.WriteLine("\nNamn: " + spel.namn + "\nGenre: " + spel.genre + "\nSpelarläge: " + spel.spelarläge);
                    }
                }

                Console.WriteLine("\nSearch for game (or type 'exit' to quit): ");
                search = Console.ReadLine();
                if (search != "exit")
                {
                    spel();
                }
            }

        }
    }
}