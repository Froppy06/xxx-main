using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_project
{
    public class mistrz
    {

        public static int[] mistrzu(int[] character)
        {
            Console.WriteLine("Witaj w pieciarze pradawnego mistrza, wybierz szkolenie!");
            Console.WriteLine("1 - trening wytrzymałościowy 20 coinsów \t 2 - trening podstawowy 15 coinsów  \t 3 - trening mistrzowski 100 coinsów");

            int inp = int.Parse(Console.ReadLine());
            switch (inp)
            {
                case 1:
                    return wytrz(character);
                case 2:
                    return podst(character);
                case 3:
                    return mis(character);



            }
            Console.WriteLine("Opuszczasz pieczare pradawnego mistrza");
            return character;
        }

        public static int[] wytrz(int[] character)
        {
            if (character[3] >= 20)
            {
                Console.WriteLine("Twój trening się zakończył, zyskujesz 20 mocy, wydajesz 20 coinów");
                character[3] -= 20;
                character[2] += 20;             
            }
            else
            {
                Console.WriteLine("Nie masz wystarczjaco coinów");
            }
            return character;
        }

        public static int[] podst(int[] character)
        {
            if (character[3] >= 15)
            {
                Console.WriteLine("Twój trening się zakończył, zyskujesz 10 mocy i 20 ataku, wydajesz 15 coinów");
                character[3] -= 15;
                character[2] += 10;
                character[1] += 20;
            }
            else
            {
                Console.WriteLine("Nie masz wystarczjaco coinsów");
            }
            return character;
        }

        public static int[] mis(int[] character)
        {
            if (character[3] >= 150)
            {
                Console.WriteLine("Twój trening się zakończył, zyskujesz 70 mocy i 100 ataku, wydajesz 100 coinów");
                character[3] -= 150;
                character[2] += 70;
                character[1] += 100;
            }
            else
            {
                Console.WriteLine("Nie masz wystarczjaco coinsów");
            }
            return character;
        }






    }
}
