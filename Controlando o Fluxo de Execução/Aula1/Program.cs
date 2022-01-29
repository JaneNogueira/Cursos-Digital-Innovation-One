using System;

class Program
{
    static void Main(string[] args)
    {
        int valor1, valor2, soma;      
    
        Console.WriteLine("Digite seu primeiro valor: ");
        valor1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o segundo valor: ");
        valor2 = int.Parse(Console.ReadLine());
        soma = valor1 + valor2;
        Console.WriteLine($"A soma de seus valores é: {soma}");
        
    }
}

