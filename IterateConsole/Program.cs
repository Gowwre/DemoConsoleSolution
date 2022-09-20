// See https://aka.ms/new-console-template for more information

/*string fizz = "Fizz";
string buzz = "Buzz";
for (int i = 1; i <= 100; i++)
{
    if (i % 3 == 0 && i % 5 == 0)
    {
        Console.WriteLine($"{i} - {fizz}{buzz}");
    } else if (i % 3 == 0)
    {
        Console.WriteLine($"{i} - {fizz}");
    } else if (i % 5 == 0)
    {
        Console.WriteLine($"{i} - {buzz}");
    }
    else
    {
        Console.WriteLine(i);
    }
}*/

/*
Random random = new Random();
int current = 0;
do
{
    current = random.Next(1, 11);
    Console.WriteLine(current);

} while (current != 7);
*/

/*Random random = new Random();
int current = random.Next(1, 11);

do
{
    current = random.Next(1, 11);

    if (current >= 8) continue;

    Console.WriteLine(current);
} while (current != 7);*/

int heroHP = 10;
int monsterHP = 10;
Random random = new Random();

while (heroHP > 0 && monsterHP > 0)
{
    //TODO: If ONE characters health reaches 0 or below, stop the loop
    int damage = random.Next(1, 10);
    monsterHP -= damage;
    if (monsterHP <= 0)
    {
        Console.WriteLine($"Monster was damaged and lost {damage} health and now has {monsterHP} health");
        Console.WriteLine("Hero wins!");
        break;
    }
    damage = random.Next(1, 10);
    heroHP -= damage;
    if (heroHP <= 0)
    {
        Console.WriteLine($"Hero was damaged and lost {damage} health and now has {heroHP} health");
        Console.WriteLine("Monster wins!");
        break;
    }
    
    
    Console.WriteLine($"Monster was damaged and lost {damage} health and now has {monsterHP} health");
    Console.WriteLine($"Hero was damaged and lost {damage} health and now has {heroHP} health");
}

