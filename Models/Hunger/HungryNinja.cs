using System.Collections.Generic;
namespace oop_demo.Models.Hunger 
{
    abstract class HungryNinja
    {
        protected int calorieIntake;
        public List<IConsumable> ConsumingHistory = new List<IConsumable>();
        
        public string Name;

        
        //constructor
        public HungryNinja(string name, int _calorieIntake = 0)
        {   
            Name = name;
            calorieIntake = _calorieIntake;
        }

        public abstract bool IsFull {get;}
    
        public abstract HungryNinja Eat(IConsumable item);
        
        public HungryNinja Display()
        {
            System.Console.WriteLine("********************************************");
            System.Console.WriteLine($"Name: {Name}");
            System.Console.WriteLine($"Calories Intake: {calorieIntake}");
            System.Console.WriteLine($"Is Full? {IsFull}");
            return this;
        }
        public HungryNinja WhatDidYouEat()
        {
            System.Console.WriteLine("********************************************");
            if (ConsumingHistory.Count == 0)
            {
                System.Console.WriteLine($"{Name} ate nothing");
            }
            else {
                System.Console.WriteLine($"{Name} ate following items:");
                foreach(Food item in ConsumingHistory)
                {
                    System.Console.Write($"{item.Name}, ");
                }
                System.Console.WriteLine();
            }
            return this;
        }
    }
}