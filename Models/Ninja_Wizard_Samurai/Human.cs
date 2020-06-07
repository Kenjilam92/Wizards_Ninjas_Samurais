using System;
namespace oop_demo.Models.NWS
{
    public class Human
    {
        public string Name;
        public int Strength;
        public int Intelligence;
        public int Dexterity;
        protected int health ;

        public int Health 
        {
            get 
            {
                return health;
            }
        }

        public Human (string name, int strength=3, int intelligence=3, int dexterity = 3, int _health =100)
        {
            Name= name;
            Strength = strength;
            Intelligence = intelligence;
            Dexterity = dexterity;
            health = _health;
        }
        // public Human (string name, int strength, int intelligence, int dexterity, int _health)
        // {
        //     Name= name;
        //     Strength = 3;
        //     Intelligence = 3;
        //     Dexterity = 3;
        //     health = 100;
        // }
        public Human Display(){
            System.Console.WriteLine("*************************************");
            System.Console.WriteLine($"Name:         {Name}");
            System.Console.WriteLine($"Strength:     {Strength}");
            System.Console.WriteLine($"Intelligence: {Intelligence}");
            System.Console.WriteLine($"Dexterity:    {Dexterity}");
            System.Console.WriteLine($"Health:       {health}");
            return this;
        }
        public virtual Human Attack (Human target)
        {
            System.Console.WriteLine("**************************************");
            System.Console.WriteLine($"{Name} attacked {target.Name}");
            target.damage (Strength * 5);
            return this;
        }
        public void damage(int amount)
        {
            health -= amount;
            if (health < 0)
            {
                health = 0;
            } 
        }
        public void heal (int amount)
        {
            health+= amount;
        }
    }
}