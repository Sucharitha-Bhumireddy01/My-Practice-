using System;
public class Mage:Character
{
    public Mage(string name, int health, int attack, int defense): base(name, health, attack, defense) { }
    public void CastSpell(Character target)
    {
        // a method to cast a spell at a target
        Console.WriteLine($"{name} cast spell at {target.name}.");
        Attack(target);
    }

     public sealed override void Defend() 
     {
        Console.WriteLine(name + " can't defend!");
     }
}