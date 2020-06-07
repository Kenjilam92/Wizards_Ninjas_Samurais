
namespace oop_demo.Models.NWS
{
    public class Samurai : Human
    {   
        public Samurai(string name):base(name)
        {
            health = 200;
        }
        public override Human Attack(Human target)
        {
            if (target.Health < 50 )
            {
                System.Console.WriteLine("**************************************");
                System.Console.WriteLine($"{Name} attacked {target.Name}");
                System.Console.WriteLine("Ultimate slash");
                target.damage(target.Health);
            }
            else
            {
                base.Attack(target);
            }
            return this;
        }

        public Samurai Meditate ()
        {   System.Console.WriteLine($"{Name} meditated, health fully recovered");
            base.heal(200-Health);
            return this;
        } 
        
    }
}