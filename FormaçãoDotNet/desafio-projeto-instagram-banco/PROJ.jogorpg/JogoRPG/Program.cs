using System;
using JogoRPG.src.Entities;

namespace dotnet_poo
{
    class Program
    {
        static void Main(string[]args)
        {
            Knight arus = new Knight("Arus", 23, "Knight");
            Wizard wizard = new Wizard("Jennica", 25, "White Wizard");
       
            Console.WriteLine(wizard.Attack(1));
            Console.WriteLine(wizard.Attack(8));
            
        }
    }
}

