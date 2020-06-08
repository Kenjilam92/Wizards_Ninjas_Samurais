using System;

namespace oop_demo.Models.Hunger
{
    public class Drink : IConsumable
    {
        public string Name {set;get;}
        public int Calories {set;get;}
        public bool IsSpicy {set;get;} 
        public bool IsSweet {set;get;}
        public string GetInfo()
        {
            return $"{Name} (Drink).\nCalories: {Calories}.\nSpicy?: {IsSpicy}.\nSweet?: {IsSweet}";
        } 

        public Drink (string name, int calories, bool isSpycy, bool isSweet)
        {
            Name = name;
            Calories = calories;
            IsSpicy = isSpycy;
            IsSweet = isSweet;
        }   
    }   
}
