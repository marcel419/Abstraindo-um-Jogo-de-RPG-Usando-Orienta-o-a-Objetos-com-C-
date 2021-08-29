using System;
using RPG_POO.src.Entities;

namespace RPG_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Knight arus  = new Knight("Arus", 23, "Knight");
            Wizard wizard = new Wizard("Jenica", 22, "White Wizard");


            Console.WriteLine(wizard.Attack(1));
            Console.WriteLine(wizard.Attack(7));
        }
    }
}
