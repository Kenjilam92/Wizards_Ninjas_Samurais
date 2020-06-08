using System.Collections.Generic;
using System;
namespace oop_demo.Models.Hunger
{
    class Buffet
    {
        public List<IConsumable> Menu = new List<IConsumable>{};
    
        public Buffet () 
        {
            Menu.Add(new Food("Chicken",1500,true,false));
            Menu.Add(new Food("Spaghetti ",900,true,false));
            Menu.Add(new Food("Icy Cream",700,false,true));
            Menu.Add(new Food("Candy",300,false,false));
            Menu.Add(new Food("Korean Fried Chicken",1800,true,true));
            Menu.Add(new Drink("Soda",350,false,true));
            Menu.Add(new Drink("Coffee",450,false,false));
            Menu.Add(new Drink("RedBull",580,false,true));
            Menu.Add(new Drink("Water",10,false,false));
            Menu.Add(new Drink("Cocktail",250,true,true));
        }
        public IConsumable Server()
        {   
            Random select = new Random();        
            IConsumable Disc = Menu[select.Next(0,Menu.Count)];
            // System.Console.WriteLine($"{Disc.Name} is selected");
            return Disc;
        }
    }
}