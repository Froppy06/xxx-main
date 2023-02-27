using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_project
{
    public class Ekspedycja
    {
        public static int[] Place(int[] character, int maxHp)
        {
            Console.WriteLine("Gdzie chcesz iść?");
            Console.WriteLine("1 - Jaskinia \t 2 - Pustynia \t 3 - Las");
            int inp = int.Parse(Console.ReadLine());
            switch (inp)
            {
                case 1:
                    return Jaskinia(character);
                case 2:
                    return Pustynia(character, maxHp);
                case 3:
                    return Las(character, maxHp);
            }
            Console.WriteLine("Wracasz z ekspedycji");
            return character;
        }

        public static int[] Jaskinia(int[] character)
        {
            Random rnd = new Random();
            int t = rnd.Next(0, 2);
            int a = rnd.Next(0, 4);
            if (t == 0)
            {
                if (a > 0)
                {
                    Console.WriteLine($"Znalazłeś {a} diaxy");
                    character[4] += a;
                }
                else if (a == 0)
                {
                    Console.WriteLine("Nic nie znalazłeś");
                }

            }
            else if (t == 1)
            {
                Monsters.faight(character);
            }
            return character;
        }


        public static int[] Pustynia(int[] character, int maxHp)
        {
            Random rnd = new Random();
            int t = rnd.Next(0, 2);
            int a = rnd.Next(0, 10);
            if (t == 0)
            {
                if (a > 0)
                {
                    Console.WriteLine($"Znalazłeś {a} kłów");
                    character[4] += a;
                }
                else if (a == 0)
                {
                    Console.WriteLine("Nic nie znalazłeś");
                }

            }
            else if (t == 1)
            {
                Travel.travel(character, maxHp);
            }
            return character;
        }
        public static int[] Las(int[] character, int maxHp)
        {
            Random rnd = new Random();
            int t = rnd.Next(0, 3);
            int a = rnd.Next(0, 10);
            if (t == 0)
            {
                if (a > 0)
                {
                    Console.WriteLine($"Znalazłeś {a} rośli");
                    character[4] += a;
                }
                else if (a == 0)
                {
                    Console.WriteLine("Nic nie znalazłeś");
                }

            }
            else if (t == 1)
            {
                Travel.travel(character, maxHp);
            }
            else if (t == 2)
            {
                Bandyci.ambusz(character);
            }
            return character;
        }
    }
}
