
namespace oop_demo.Models.NWS
{
    public class Wizard : Human
    {   
        public Wizard(string name):base(name){
            health = 50;
            Intelligence = 25;
        }
        public override Human Attack (Human target)
        {   
            System.Console.WriteLine("**************************************");
            System.Console.WriteLine($"{Name} attacks {target.Name}");
            target.damage(5*Intelligence);
            health += 5*Intelligence; 
            return this;
        }
        public Wizard Heals(Human target)
        {   
            System.Console.WriteLine("**************************************");
            System.Console.WriteLine($"{Name} heals {target.Name}");
            target.heal(Intelligence*10);
            return this;
        }
        


    }
}