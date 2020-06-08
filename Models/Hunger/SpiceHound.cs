using System.Collections.Generic;
namespace oop_demo.Models.Hunger 
{
    class SpiceHound : HungryNinja
    {
        public override bool IsFull
        {
            get {return calorieIntake>=12000;}
        }
        public SpiceHound (string name):base(name){}

        public override HungryNinja Eat(IConsumable item)
        {
            // provide override for Consume
            if (IsFull)
            {
                System.Console.WriteLine("********************************************");
                System.Console.WriteLine($"Ninja {Name} is full");
            }
            else 
            {
                System.Console.WriteLine("********************************************");
                if (item is Food)
                {
                System.Console.WriteLine($"{Name} eats {item.Name}");
                }
                else if (item is Drink)
                {
                System.Console.WriteLine($"{Name} drinks {item.Name}");
                }
                ConsumingHistory.Add(item);
                calorieIntake+= item.Calories;
                if (item.IsSpicy)
                {
                    System.Console.WriteLine("Yum! I love Spicy stuffs");
                    calorieIntake+=10;
                }
            }
            return this;
        } 
        
    }
}