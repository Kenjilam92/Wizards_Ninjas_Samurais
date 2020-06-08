using System;
using System.Collections.Generic;
using oop_demo.Models.Hunger;
namespace oop_demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Buffet Menu = new Buffet();
            SweetTooth A = new SweetTooth("Candice");
            SpiceHound B =  new SpiceHound("Hot Rod");
            A.Eat(Menu.Server()).Eat(Menu.Server()).Eat(Menu.Server()).Eat(Menu.Server()).Eat(Menu.Server()).Eat(Menu.Server()).Eat(Menu.Server()).Eat(Menu.Server()).Eat(Menu.Server()).Eat(Menu.Server()).Eat(Menu.Server()).Eat(Menu.Server()).Eat(Menu.Server()).Eat(Menu.Server()).Eat(Menu.Server()).Eat(Menu.Server()).Eat(Menu.Server()).Display();

            B.Eat(Menu.Server()).Eat(Menu.Server()).Eat(Menu.Server()).Eat(Menu.Server()).Eat(Menu.Server()).Eat(Menu.Server()).Eat(Menu.Server()).Eat(Menu.Server()).Eat(Menu.Server()).Eat(Menu.Server()).Eat(Menu.Server()).Eat(Menu.Server()).Eat(Menu.Server()).Eat(Menu.Server()).Eat(Menu.Server()).Eat(Menu.Server()).Eat(Menu.Server()).Display();
            
            System.Console.WriteLine($"{A.Name} consumed {A.ConsumingHistory.Count} items");
            System.Console.WriteLine($"{B.Name} consumed {B.ConsumingHistory.Count} items");
            if (A.ConsumingHistory.Count > B.ConsumingHistory.Count )
            {
                System.Console.WriteLine($"The winner is {A.Name}");
            }
            else if (A.ConsumingHistory.Count < B.ConsumingHistory.Count )
            {
                System.Console.WriteLine($"The winner is {A.Name}");
            }
            else
            {
                System.Console.WriteLine("Draw");
            }


        }
    }
}
