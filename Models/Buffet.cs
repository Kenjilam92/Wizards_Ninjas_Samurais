using System.Collections.Generic;
using System;
namespace oop_demo.Models 
{
    class Buffet
    {
        public List<Food> Menu = new List<Food>{};
    
        public Buffet () 
        {
            Menu.Add(new Food("Chicken",1500,true,false));
            Menu.Add(new Food("Spaghetti ",900,true,false));
            Menu.Add(new Food("Icy Cream",700,false,true));
            Menu.Add(new Food("Candy",300,false,false));
            Menu.Add(new Food("Korean Fried Chicken",1800,true,true));
        }
        public Food Server()
        {   
            Random select = new Random();        
            Food Disc = Menu[select.Next(0,Menu.Count)];
            // System.Console.WriteLine($"{Disc.Name} is selected");
            return Disc;
        }
    }
}