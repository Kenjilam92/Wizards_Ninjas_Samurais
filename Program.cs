using System;
using System.Collections.Generic;
using oop_demo.Models;
namespace oop_demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Ninja A = new Ninja("kenji");
            Buffet Meal = new Buffet();
            A.Display();

            A.Eat(Meal.Server()).Eat(Meal.Server()).Eat(Meal.Server()).Eat(Meal.Server()).Eat(Meal.Server()).Display();
            A.WhatDidYouEat();

            Ninja B = new Ninja("Jin");
            B.WhatDidYouEat();
            while (B.IsFull==false)
            {
                B.Eat(Meal.Server());
            }
            B.WhatDidYouEat();
        }
    }
}
