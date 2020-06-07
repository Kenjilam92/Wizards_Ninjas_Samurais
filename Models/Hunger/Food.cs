using System;

namespace oop_demo.Models.Hunger
{
    public class Food 
    {
    public string Name;
    public int Calories;
    public bool IsSpicy; 
    public bool IsSweet; 

    public Food (string name, int calories, bool isSpycy, bool isSweet)
    {
        Name = name;
        Calories = calories;
        IsSpicy = isSpycy;
        IsSweet = isSweet;
    }   
    }   
}
