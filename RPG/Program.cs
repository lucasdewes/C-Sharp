using System;
using RPG.Oldrpg;
using RPG.Entities;

namespace RPG
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            Start();
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
            int damage = 0;

            while (player.HP > 0 && oponent.HP > 0)
            {
                round++;
                Console.WriteLine($"\n============== Round {round} ==============");
                Console.WriteLine(oponent.ShowStatus() + "\n\n" + player.ShowStatus());

                damage = player.BaseDamage;
                Console.ReadKey();
            }
        }
    }
}
