using System;
public class Dragon: Character
{
   public Dragon(string name, int health,int attack,int defense): base(name, health, attack, defense) { }
    public void BreatheFire(Character target)
    {
        //a method for the dragon to breathe fire at a target
        Console.WriteLine($"{name} breathe fire at {target.name}.");
        Attack(target);
    }

    public override void Attack(Character target)
    {
        base.attack *= 2;
        base.Attack(target);
        base.attack /= 2;
    }
}