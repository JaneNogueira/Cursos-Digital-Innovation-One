using System;
using System.Collections.Generic;

public class Desafio8
{
    public static void Main()
    {
        int limite = int.Parse(Console.ReadLine());

        for (int i = 0; i < limite; i++)
        {
            if (i > 1000) return;

            int pessoas = int.Parse(Console.ReadLine());
            List<int> lista = new List<int>();
            string[] line = Console.ReadLine().Split(" ");

            foreach (string item in line)
            {
                if (lista.Count > 1000) return;
                lista.Add(int.Parse(item));
            }

            lista.Sort((a, b) => b.CompareTo(a));
            int quantidade = pessoas;

            for (int x = 0; x < lista.Count; x++)
            {
                if (int.Parse(line[x]) != lista[x])
                {
                    quantidade--;
                }
            }
            Console.WriteLine(quantidade);
        }
    }
}