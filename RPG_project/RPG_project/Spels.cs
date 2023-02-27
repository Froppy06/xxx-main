using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_project
{
    internal class Spels
    {
        public static int[] SpelsBook(int[] character, int mxaHp, int maxMoc)
        {
            Console.WriteLine($"Twój ekwipunek: kości: { character[7]}, rośliny: {character[8]}, diaxy: { character[4]}, fosfofilit: { character[8]}");
            Console.WriteLine("1 - Lecznie \t 2 - Zwiększenie ataku \t 3 - Zwiększenie mocy");
            int inp = int.Parse(Console.ReadLine());
            switch (inp)
            {
                case 1:
                    return Heal(character, mxaHp, maxMoc);               
                case 2:
                    return Atack(character, maxMoc);
                case 3:
                    return Magic(character, maxMoc);
                default:
                    return character;
            }
        }

        public static int[] Heal(int[] character, int mxaHp, int maxMoc)
        {
            if (character[2] >= 100 & character[4] >= 5 & character[8] >= 10)
            {
                character[0] = mxaHp;
                character[2] -= 100;
                character[4] -= 5;
                character[8] -= 10;
                Console.WriteLine("Masz max hp");
                return character;
            }
            else
            {
                Console.WriteLine("Brak mocy, roślin lub diaxów");
            }

            return character;
        }

        public static int[] Atack(int[] character, int maxMoc)
        {
            if (character[2] >= 150)
            {
                character[1] += 15;
                character[2] -= 100;
                character[7] -= 10;
                Console.WriteLine("Zyskałeś +15 do ataku");
                return character;
            }
            else
            {
                Console.WriteLine("Brak mocy lub kości");
            }

            return character;
        }

        public static int[] Magic(int[] character, int maxMoc)
        {
            if (character[6] >= 15)
            {
                character[2] += 150;
                character[6] -= 15;
                Console.WriteLine("Zyskałeś +150 do mocy");
                return character;
            }
            else
            {
                Console.WriteLine("Brak Fosfofilitu");
            }

            return character;
        }



    }
}
