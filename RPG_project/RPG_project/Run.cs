using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_project
{
    internal class Run
    {
        static void Main(string[] args)
        {             
            int[] character = CharacterClass.characterClassSelection();
            int round = 0;

            int maxHp = character[0];
            int maxMoc = character[2];

            while (CharacterClass.isAlive(character))
            {
                GameInformation.informations(character, round);
                string inp = Console.ReadLine().ToLower();
                switch (inp)
                {
                    case "w":
                        Console.WriteLine("walka");
                        Monsters.faight(character);
                        break;
                    case "e":
                        Console.WriteLine("ekspedycja");
                        Ekspedycja.Place(character, maxHp);
                        break;
                    case "z":
                        Console.WriteLine("zaklęcia");
                        Spels.SpelsBook(character, maxHp, maxMoc);
                        break;
                    case "s":
                        Shop.shop(character, maxHp, maxMoc);
                        Console.WriteLine("sklep");
                        break;
                    case "m":
                        mistrz.mistrzu(character);
                        Console.WriteLine("mistrz");
                        break;
                    case "k":
                        rzemioslo.kowal(character);
                        Console.WriteLine("kowal");
                        break;                   
                    default:
                        Console.WriteLine("Nie ma tak");
                        break;
                }
                round += 1;
            }

            Console.WriteLine("Dziekuje za grę");
            Console.ReadKey();
        }
    }
}