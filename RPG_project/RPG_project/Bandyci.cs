using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RPG_project
{
    internal class Bandyci
    {
        public static int[] genrateBandyt()
        {
            Random rnd = new Random();
            int[] bandytStatystic = new int[5];
            for (int i = 0; i < bandytStatystic.Length; i++)
            {
                bandytStatystic[i] = rnd.Next(25, 35);
            }
            return bandytStatystic;
        }

        public static int[] ambusz(int[] player)
        {
            Random rnd = new Random();
            Console.WriteLine("Spotykasz bandytów na szciesce!");
            Console.WriteLine("1 - Daj im 50 coinsów / 2 - Broń się / 3 - Uciekaj");
            int inp = int.Parse(Console.ReadLine());
            switch (inp)
            {
                case 1:
                    return Tchurz(player);
                case 2:
                    return Idiota(player);
                case 3:
                    return Ucieczka(player);
            }
            Console.WriteLine("Wracasz z ekspedycji");
            return player;
        }

        public static int[] Tchurz(int[] player)
        {
            if (player[3] >= 50)
            {
                player[3] -= 50;
                Console.WriteLine("Oddałeś bandytom 50 coinsow");
            }
            else if (player[3] < 50)
            {
                return Idiota(player);
            }
            return player;
        }

        public static int[] Idiota(int[] player)
        {
            Console.WriteLine("Bandyci cie atakują!");
            int[] bandyt= genrateBandyt();
            while (bandyt[0] > 0)
            {
                player[0] -= bandyt[1];
                bandyt[0] -= player[1];
                if (player[0] <= 0)
                {
                    Console.WriteLine("Umierasz!!!");
                    break;

                }
                Thread.Sleep(900);
                Console.WriteLine($"Walka playerHp {player[0]} dostajesz {bandyt[1]} obr | bandyt {bandyt[0]} zadajesz {player[1]} obr");
            }
            player[3] += bandyt[3];           
            player[4] += 6;
            Console.WriteLine("Otrzymałeś coinsy i kilka diaxow");
            return player;
        }
        public static int[] Ucieczka(int[] player)
        {
            if (player[1] >= 50)
            {
                player[3] -= 25;
                Console.WriteLine("Podczas ucieczki straciłeś 25 coinsow");
            }
            else if (player[1] < 50)
            {
                return Idiota(player);
            }
            return player;
        }
    }
}
