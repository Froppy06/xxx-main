using System;
using System.Collections.Generic;
using System.Linq; 
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RPG_project
{
    internal class GameInformation
    {
        public static void informations(int[] character, int round)
        {
            Console.WriteLine($"------------------- runda - {round} -------------------");
            Console.WriteLine($"Twoje życie: {character[0]}, atak: {character[1]}, moc: {character[2]}, coinsy: {character[3]} | Twój ekwipunek: diaxy: {character[4]}, kły: {character[5]}, fosfofilit: {character[6]}");
            Console.WriteLine($"w - walka | e - ekspedycja | z - zaklęcia |s - sklep | k - kowal | m - pieczara mistrza |");
            Thread.Sleep(900);
        }
    }
}
