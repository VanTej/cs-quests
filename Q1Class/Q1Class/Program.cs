using System;

class Program
{
    public static void Main(string[] args)
    {
        Character fighter1 = new Character("Hercules");
        Character fighter2 = new Character("Heracles");
        fighter1.attackPV = 25;
        while (fighter1.lifePV != 0 && fighter2.lifePV != 0)
        {
            fighter1.Attack(fighter2);
            fighter2.Attack(fighter1);
        }
    }
}

public class Character
{
    public string name;
    public int lifePV = 100;
    public int attackPV = 20;
    public int defensePV = 5;

    public Character(string fighterName)
    {
        name = fighterName;
    }

    public bool IsAlive()
    {
        return (lifePV > 0);
    }

    public void Attack(Character attacked)
    {
        if (attacked.lifePV > 0 && attackPV >= attacked.defensePV)
        {
            attacked.lifePV -= (attackPV - attacked.defensePV);
            if (!attacked.IsAlive())
            {
                Console.WriteLine($"{name} wins, {attacked.name} is dead.");
            }
            else
            {
                Console.WriteLine($"{name} attacks, {attacked.name}: life {attacked.lifePV}");
            }
        }
        else
        {
            Console.WriteLine("You can't attacked a dead character");
        }
    }
}

