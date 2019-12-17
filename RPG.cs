// Simple rpg game using while and if statements

Random random = new Random();
int hero = 10, monster = 10, damage = 0, round = 0;

Console.WriteLine("\n=======================================");

while ((hero >= 1) && (monster >= 1))
{
    round++;
    damage = random.Next(1, 11);
    Console.WriteLine($"\n============== Round {round} ================");
    Console.WriteLine($"hero's life: {hero} ---- Monster's life: {monster}\n\n");
    if(damage > 5)
    {
        if (damage == 10)
        {
            Console.Write("SUPER");
        }
        Console.Write("CRIT DAMAGE = ");
    }
    Console.WriteLine($"Hero attacks with {damage} damage");
    monster -= damage;

    if (monster >= 1)
    {
        Console.WriteLine($"\nMonster's life: {monster}");
        damage = random.Next(1, 11);
        if(damage > 5)
        {
            if (damage == 10)
            {
                Console.Write("SUPER");
            }
            Console.Write("CRIT DAMAGE = ");
        }
        Console.WriteLine($"Monster attacks with {damage} damage");
        hero -= damage;

        if (hero < 1)
        {
            Console.WriteLine("\nThe Hero is dead!");
        }
        else
        {
            Console.WriteLine("The Hero is alive");
        }
    }
    else
    {
        Console.WriteLine("The monster is dead!");
    }
}
Console.WriteLine("End of combat.");
