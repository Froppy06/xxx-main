using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_project
{
    public class Shop
    {
        public static int[] shop(int[] character, int mxaHp, int maxMoc)
        {
            Console.WriteLine("Witaj w  sklepie!");
            Console.WriteLine("Do kupienia: 1 - misktura regeneracji 10 coinsów \t 2 - lepsza mikstura regenarcji 30 coinsów \t 3 - mikstura ataku 15 coinsów");
            Console.WriteLine("Do sprzedania: 4 - diax 50 coinsów \t 5 - kieł 40 coinsów");
            
            int inp = int.Parse(Console.ReadLine());
            switch (inp)
            {
                case 1:
                    return heal(character, mxaHp);
                case 2:
                    return heal1(character, mxaHp);
                case 3:
                    return upAtac(character);
                case 4:
                    return Diaxy(character);
                case 5:
                    return Kły(character);
                default:
                    Console.WriteLine("Opuszczasz sklep");
                    return character;
            }
        }



        public static int[] heal(int[] character, int mxaHp)
        {
            Random rnd = new Random();
            int heal = rnd.Next(10, 20);
            Console.WriteLine(character[0]);
            if (character[3] >= 10)
            {
                Console.WriteLine("Płacisz 10 coinsów");
                character[3] -= 10;
                if (character[0] + heal >= mxaHp)
                {
                    Console.WriteLine("Masz max hp");
                    character[0] = mxaHp;
                    return character;
                }
                else
                {
                    Console.WriteLine($"mikstura cię o {heal} masz teraz {character[0]} hp");
                    character[0] += heal;
                    return character;
                }
            }
            Console.WriteLine("Nie masz wystarczająco coinsów");
            return character;
        }


        public static int[] heal1(int[] character, int mxaHp)
        {
            Random rnd = new Random();
            int heal = rnd.Next(40, 60);
            Console.WriteLine(character[0]);
            if (character[3] >= 30)
            {
                Console.WriteLine("Płacisz 30 coinsów");
                character[3] -= 30;
                if (character[0] + heal >= mxaHp)
                {
                    Console.WriteLine("Masz max hp");
                    character[0] = mxaHp;
                    return character;
                }
                else
                {
                    Console.WriteLine($"mikstura leczy cię o {heal} masz teraz {character[0]} hp");
                    character[0] += heal;
                    return character;
                }
            }
            Console.WriteLine("Nie masz wystarczjaco coinsów");
            return character;
        }
        public static int[] upAtac(int[] character)
        {
            if (character[3] >= 15)
            {
                Console.WriteLine("Twój atak zwiekszył się o 5 po treningu, wydajesz 15 coinsów");
                character[3] -= 15;
                character[1] += 5;
            }
            else
            {
                Console.WriteLine("Nie masz wystarczjaco coinsów");
            }
            return character;
        }
        public static int[] Diaxy(int[] character)
        {
            if (character[4] >= 1)
            {
                character[4] -= 1;
                int s = 50;
                Console.WriteLine($"Sprzedałeś diaxa i dostałeś {s} coinsów");
                character[3] += s;
            }
            else
            {
                Console.WriteLine("Nie masz diaxów");
            }
            return character;
        }
        public static int[] Kły(int[] character)
        {
            if (character[5] >= 1)
            {
                character[5] -= 1;
                int s = 5;
                Console.WriteLine($"Sprzedałeś kieł i dostałeś {s} coinsów");
                character[3] += s;
            }
            else
            {
                Console.WriteLine("Nie masz kłów");
            }
            return character;
        }
    }
}
