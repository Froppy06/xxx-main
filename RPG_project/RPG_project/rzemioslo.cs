using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_project
{
    public class rzemioslo
    {
        public static int[] kowal(int[] character)
        {
            Console.WriteLine("Witaj u kowala!");
            Console.WriteLine("1 - kup miecz 35 coinsów \t 2 - kup buzdygan 40 coinsów  \t 3 - kup siekierę 30 coinsów");

            int inp = int.Parse(Console.ReadLine());
            switch (inp)
            {
                case 1:
                    return miecz(character);
                case 2:
                    return buzdygan(character);
                case 3:
                    return siekiera(character);
            }
            Console.WriteLine("Opuszczasz kowala");
            return character;
        }


        public static int[] miecz(int[] character)
        {
            if (character[3] >= 35)
            {
                Console.WriteLine("Oto twój miecz, twój atak zwięszył sie o 20, wydajesz 35 coinów");
                character[3] -= 35;
                character[1] += 20;
            }
            else
            {
                Console.WriteLine("Nie masz wystarczjaco coinsów");
            }
            return character;
        }



        public static int[] buzdygan(int[] character)
        {
            if (character[3] >= 40)
            {
                Console.WriteLine("Oto twój buzdygan, twój atak zwięszył sie o 25, wydajesz 40 coinów");
                character[3] -= 40;
                character[1] += 25;
            }
            else
            {
                Console.WriteLine("Nie masz wystarczjaco coinsów");
            }
            return character;
        }

        public static int[] siekiera(int[] character)
        {
            if (character[3] >= 30)
            {
                Console.WriteLine("Oto twoja siekiera, twój atak zwięszył sie o 15, wydajesz 30 coinów");
                character[3] -= 30;
                character[1] += 15;
            }
            else
            {
                Console.WriteLine("Nie masz wystarczjaco coinsów");
            }
            return character;
        }




    }
}
