using System;
using System.Collections.Generic;
using oop_demo.Models.NWS;
namespace oop_demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Ninja A = new Ninja ("Kenji"); 
            Wizard B = new Wizard ("Gandal");
            Samurai C = new Samurai ("Shogun");
           
            A.Display();
            B.Display();

            A.Attack(B);
            B.Display();
            C.Display();
            B.Heals(B).Display().Attack(C);
            C.Display();
            C.Meditate().Display();


        }
    }
}
