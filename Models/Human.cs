using System;
namespace oop_demo.Models
{
    public class Human
    {
        public string Name;
        public int Strength;
        public int Intelligence;
        public int Dexterity;
        private int health ;

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
        public Human Display(){
            System.Console.WriteLine("*************************************");
            System.Console.WriteLine($"Name:         {Name}");
            System.Console.WriteLine($"Strength:     {Strength}");
            System.Console.WriteLine($"Intelligence: {Intelligence}");
            System.Console.WriteLine($"Dexterity:    {Dexterity}");
            System.Console.WriteLine($"Health:       {health}");
            return this;
        }
        public Human Attack (Human target)
        {
            System.Console.WriteLine("**************************************");
            System.Console.WriteLine($"{Name} attacked {target.Name}");
            target.health -= Strength * 5;
            return this;
        }
    }
}