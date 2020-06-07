using System;
namespace oop_demo.Models.NWS
{
    public class Ninja : Human
    {   
        public Ninja (string name): base(name){
            Dexterity = 175;
        }
        public override Human Attack(Human target)
        {   
            System.Console.WriteLine("**************************************");
            System.Console.WriteLine($"{Name} attacked {target.Name}");
            target.damage(5*Dexterity);
            Random chance = new Random();
            if (chance.Next(1,10)>8)
            {
                System.Console.WriteLine("BONUS DAMAGE!!!!");
                target.damage(10);
            }
            return this;
        } 

        public Ninja Steal (Human target)
        {
            System.Console.WriteLine("**************************************");
            System.Console.WriteLine($"{Name} stole {target.Name}");
            base.heal(5);
            target.damage(5);
            return this;
        }

    }
}