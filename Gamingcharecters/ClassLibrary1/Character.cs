using System;
public class Character
{
    public string name;
    public int health;
    public int attack;
    public int defense;

    //constructor
    public Character(string name,int health,int attack,int defense)
    {
        this.name = name;
        this.health = health;
        this.attack = attack;
        this.defense = defense;
    }
    //method 
    public  virtual void Attack(Character target) 
    {

        int damage = attack - target.defense;
        if (damage > 0)
        {
            target.health -= damage;
            Console.WriteLine($"{name} attaks {target.name} for {damage} damage!");
        }
        else
            Console.WriteLine($"{name} attack has no effect on { target.name}");

    }
    //method
    public virtual void Defend() 
    {
        Console.WriteLine(name+" defends.");
    
    }
}