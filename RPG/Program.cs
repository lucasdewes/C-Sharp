using System;
using RPG.Oldrpg;
using RPG.Entities;

namespace RPG
{
    class Program
    {
        static void Main(string[] args)
        {

            Start();
        }

        public decimal RandomCalc(decimal value)
        {
            decimal minValue = value * 0.9m;
            decimal maxValue = value * 1.1m;
            Random random = new Random();

            return decimal.Round((decimal)random.NextDouble() * (maxValue - minValue) + minValue, 1);
        }

        static void Start()
        {
            Console.WriteLine("A masmorra!");
            Console.WriteLine("Digite o nome do heroi.\nNome: ");
            string nomeBoneco = Console.ReadLine();
            while (nomeBoneco == null || nomeBoneco.Length > 10)
            {
                Console.WriteLine("Digite o nome do heroi!");
                nomeBoneco = Console.ReadLine();
            }
            Boneco hero = new Boneco(nomeBoneco, 1000, 10, 100, 100, 10);

            Boneco monster = new Boneco("LowLvl monster", 500, 2, 50, 100, 15);

            Combat(hero, monster);

        }

        static void Combat(Boneco player, Boneco oponent)
        {
            int round = 0;
            decimal damage = 0;
            Random random = new Random();

            while (player.HP > 0 && oponent.HP > 0)
            {
                round++;

                System.Threading.Thread.Sleep(1000);

                Console.WriteLine($"\n=============================== Round {round} ==============================\n");
                Console.WriteLine(oponent.ShowStatus() + "\n\n" + player.ShowStatus());
                Console.WriteLine("\n----------------------------------------------------------------------");

                Console.ReadKey();

                Console.WriteLine("\n" + player.Name + " Attacks!\n");

                System.Threading.Thread.Sleep(1000);

                damage = player.DamageAmount() - oponent.Armor;
                if (damage < 0)
                    damage = 0;

                oponent.HP -= damage + 1;
                if (oponent.HP <= 0)
                {
                    Console.WriteLine(oponent.Name + " Is dead!!!\n");
                    player.LvlUp(1.1m);
                    break;
                }

                System.Threading.Thread.Sleep(1000);

                Console.WriteLine("\n" + oponent.Name + "Is stil alive! and it attacks!!!!\n");

                System.Threading.Thread.Sleep(1000);

                damage = (oponent.DamageAmount() - player.Armor);
                if (damage < 0)
                    damage = 0;

                player.HP -= damage + 1;
                if (player.HP <= 0)
                {
                    Console.WriteLine(player.Name + " Is dead!!!\n");
                    oponent.LvlUp(1.1m);
                    break;
                }
            }
        }
    }
}
