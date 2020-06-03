using System;
using System.Collections.Generic;
using oop_demo.Models;
namespace oop_demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Human A = new Human("Alex");
            Human B = new Human("Bob",4,4,4,150);
            B.Display();
            A.Display().Attack(B);
            B.Display().Attack(A);
            A.Display();
        }
    }
}
