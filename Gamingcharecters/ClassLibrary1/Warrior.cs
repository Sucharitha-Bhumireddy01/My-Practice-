using System;
public class Warrior:Character
{
    public Warrior(string name, int health, int attack, int defense):base(name,health,attack,defense) { }
    public void Charge(Character target)
    {
        Console.WriteLine($"{name} charges at {target.name}.");
        Attack(target);
    }
    public override void Defend()
    {
        defense += 5;
        Console.WriteLine(name+" defends and gains "+defense+" defense.");
    }
}