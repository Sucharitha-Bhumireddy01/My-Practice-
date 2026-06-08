//In this assignment, you will create a game character system using inheritance, abstract classes.method overriding/ hiding, sealed classes and constructors in C#.
using System;
class Game
{
    static void Main()
    {
        Warrior arthur = new Warrior("Arthur", 100, 20, 10);
        Mage merlin = new Mage("Merlin", 80, 15, 5);
        Dragon smaug = new Dragon("Smaug", 200, 30, 20);

        
        Console.WriteLine($"{arthur.name} is a warrior.");
        Console.WriteLine($"{merlin.name} is a mage.");
        Console.WriteLine($"{smaug.name} is a dragon.\n");


        arthur.Attack(merlin);
        merlin.Defend();
        smaug.BreatheFire(arthur);
        smaug.Defend();
        arthur.Defend();
        Console.WriteLine();

        Console.WriteLine("--- Battle between Arthur and Merlin ---");
        while (arthur.health > 0 && merlin.health > 0)
        {
            arthur.Attack(merlin);
            if (merlin.health > 0)
                merlin.Attack(arthur);
        }
        if (merlin.health <= 0)
            Console.WriteLine("Arthur wins!");
        else if (arthur.health <= 0)
            Console.WriteLine("Merlin wins!");

        Console.WriteLine("--- Battle between Smaug and Arthur ---");
        while (smaug.health > 0 && arthur.health > 0)
        {
            smaug.Attack(arthur);
            if (arthur.health > 0)
                arthur.Attack(smaug);
        }
        if (smaug.health <= 0)
            Console.WriteLine("Arthur wins!");
        else if (arthur.health <= 0)
            Console.WriteLine("Smaug wins!");

        Console.WriteLine("--- Battle between Merlin and Smaug ---");
        while (merlin.health > 0 && smaug.health > 0)
        {
            merlin.Attack(smaug);
            if (smaug.health > 0)
                smaug.Attack(merlin);
        }

        if (merlin.health <= 0)
            Console.WriteLine("Smaug wins!");
        else if (smaug.health <= 0)
            Console.WriteLine(" Merlin wins!");
        Console.ReadKey();
    }
}