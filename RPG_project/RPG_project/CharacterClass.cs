using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_project
{
    internal class CharacterClass
    {

        public static int[] characterClassSelection()
        {
            // hp atack moc coinsy diaxy kły
            while (true)
            {
                Console.WriteLine("Wybierz postać, którą chcesz grać:");
                Console.WriteLine("1 - Wiedźmin \t 2 - Samurai \t 3 - Wizard ");
                string inp = Console.ReadLine();
                if (inp == "1")
                {
                    int[] m = { 100, 20, 150, 20, 0, 0, 0, 0, 0};
                    return m;
                }
                else if (inp == "2")
                {
                    int[] w = { 120, 30, 100, 20, 0, 0, 0, 0, 0};
                    return w;
                }
                else if (inp == "3")
                {
                    int[] w = { 80, 10, 200, 20, 0, 0, 0, 0, 0};
                    return w;
                }
                else
                {
                    Console.WriteLine("Brak takiej postaci");
                }
            }
        }
        //---------------------------------------------------------
        public static bool isAlive(int[] character)
        {
            if (character[0] <= 0)
                return false;
            return true;
        }
    }
}
