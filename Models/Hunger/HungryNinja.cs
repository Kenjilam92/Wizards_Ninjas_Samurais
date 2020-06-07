using System.Collections.Generic;
namespace oop_demo.Models.Hunger 
{
    class HungryNinja
    {
        private int calorieIntake;
        public List<Food> FoodHistory = new List<Food>();
        
        public string Name;
        private bool isFull = false;

        
        //constructor
        public HungryNinja(string name, int _calorieIntake = 0)
        {   
            Name = name;
            calorieIntake = _calorieIntake;
        }

        public bool IsFull
        {
            get 
            {
                return isFull;
            }
        } 
        
        // add a public "getter" property called "IsFull"
        
        // build out the Eat method
        public HungryNinja Eat(Food item)
        {
            if (isFull)
            {
                System.Console.WriteLine("********************************************");
                System.Console.WriteLine($"Ninja {Name} is full");
            }
            else 
            {
                System.Console.WriteLine("********************************************");
                calorieIntake+= item.Calories;
                System.Console.WriteLine($"{Name} ate {item.Name}");
                FoodHistory.Add(item);
                if (calorieIntake > 12000)
                {
                    isFull=true;
                }
            }
            return this;
        }
        public HungryNinja Display()
        {
            System.Console.WriteLine("********************************************");
            System.Console.WriteLine($"Name: {Name}");
            System.Console.WriteLine($"Calories Intake: {calorieIntake}");
            System.Console.WriteLine($"Is Full? {isFull}");
            return this;
        }
        public HungryNinja WhatDidYouEat()
        {
            System.Console.WriteLine("********************************************");
            if (FoodHistory.Count == 0)
            {
                System.Console.WriteLine($"{Name} ate nothing");
            }
            else {
                System.Console.WriteLine($"{Name} ate following items:");
                foreach(Food item in FoodHistory)
                {
                    System.Console.Write($"{item.Name}, ");
                }
                System.Console.WriteLine();
            }
            return this;
        }
    }
}