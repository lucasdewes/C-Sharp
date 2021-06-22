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
            Boneco hero = new Boneco(nomeBoneco, 100, 10, 10, 100, 10);

            Boneco monster = new Boneco("LowLvl monster", 20, 2, 10, 100, 15);

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
                Console.WriteLine($"\n============== Round {round} ==============");
                Console.WriteLine(oponent.ShowStatus() + "\n\n" + player.ShowStatus());
                Console.ReadKey();

                Console.WriteLine(player.Name + " Attacks! ");
                oponent.HP--;
                oponent.HP -= ((player.DamageAmount() - oponent.Armor) < 0) ? 0 : ((player.DamageAmount() - oponent.Armor) + 1);
                if (oponent.HP <= 0)
                {
                    Console.WriteLine(oponent.Name + " Is dead");
                    player.LvlUp(1.1m);
                    break;
                }

                Console.WriteLine(oponent.Name + "Is stil alive! and it attacks!!!!");
                player.HP--;
                player.HP -= ((oponent.DamageAmount() - player.Armor) < 0) ? 0 : ((oponent.DamageAmount() - player.Armor) + 1);
                if (player.HP <= 0)
                {
                    Console.WriteLine(player.Name + " Is dead");
                    oponent.LvlUp(1.1m);
                    break;
                }
            }
        }
    }
}
