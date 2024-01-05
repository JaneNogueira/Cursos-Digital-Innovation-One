using System;
using System.Text.RegularExpressions;

class Desafio
{
    static void Main()
    {
        while (true)
        {
            string senha = Console.ReadLine();

            // Caso o campo de senha esteja vazio:
            if (string.IsNullOrEmpty(senha))
                break;

            // Utilização do método Regex para verificar ocorrências repetidas de palavras em uma cadeia de caracteres.
            Regex regras = new Regex("^(?=.*[0-9])(?=.*[a-z])(?=.*[A-Z])[a-zA-Z0-9]{6,32}$");
            Match match = regras.Match(senha);

            if (match.Success)
            {
                Console.WriteLine("Senha valida.");
            }

            else
            {
                Console.WriteLine("Senha invalida.");
            }
        }
    }
}