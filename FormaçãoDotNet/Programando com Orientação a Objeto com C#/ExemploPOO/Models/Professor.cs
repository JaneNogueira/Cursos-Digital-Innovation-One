using System;
namespace ExemploPOO.Models
{
    public class Professor : Pessoa
    {
        public int Salario { get; set; }
        public override void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome} e sou um professor com salário R$:{Salario}");
        }
    }
}