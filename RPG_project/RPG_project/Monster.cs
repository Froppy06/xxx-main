using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RPG_project
{
    internal class Monsters
    {

        public static int[] genrateMonster()
        {
            Random rnd = new Random();
            int[] monsterStatystic = new int[4];
            for (int i = 0; i < monsterStatystic.Length; i++)
            {
                monsterStatystic[i] = rnd.Next(20, 30);
            }
            return monsterStatystic;
        }

        public static int[] faight(int[] player)
        {
            Random rnd = new Random();
            Console.WriteLine("Spotykasz potwora!");
            int[] monster = genrateMonster();
            while (monster[0] > 0)
            {
                player[0] -= monster[1];
                monster[0] -= player[1];
                if (player[0] <= 0)
                {
                    Console.WriteLine("Umierasz!!!");
                    break;

                }
                Thread.Sleep(900);
                Console.WriteLine($"Walka playerHp {player[0]} dostajesz {monster[1]} obr = monster {monster[0]} zadajesz {player[1]}");
            }
            player[3] += monster[3];           
            player[5] += 2;
            player[7] += rnd.Next(2,8);
            Console.WriteLine("Otrzymałeś 2 kły i kilka kości");
            return player;
        }

    }
}

