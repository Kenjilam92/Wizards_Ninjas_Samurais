using System;

namespace oop_demo.Models.Hunger
{
    public class Food : IConsumable
    {
        public string Name {set;get;}
        public int Calories {set;get;}
        public bool IsSpicy {set;get;} 
        public bool IsSweet {set;get;}
        public string GetInfo()
        {
            return $"{Name} (Food).\nCalories: {Calories}.\nSpicy?: {IsSpicy}.\nSweet?: {IsSweet}";
        } 

        public Food (string name, int calories, bool isSpycy, bool isSweet)
        {
            Name = name;
            Calories = calories;
            IsSpicy = isSpycy;
            IsSweet = isSweet;
        }   
    }   
}
