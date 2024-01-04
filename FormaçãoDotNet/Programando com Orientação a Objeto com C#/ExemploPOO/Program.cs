using System;
using System.IO;
using ExemploPOO.Helper;
using ExemploPOO.Interfaces;
using ExemploPOO.Models;

namespace ExemploPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            var caminho = "E:\\Projetos GitHub\\TrabalhandoComArquivos";
            var caminhoPathCombine = Path.Combine(caminho, "Pasta teste 1");
            var caminhoArquivo = Path.Combine(caminho, "arquivo-teste-stream.txt");
            var novoCaminhoArquivo = Path.Combine(caminho, "Pasta Teste 2", "arquivo-teste-stream.txt");
            var novoCaminhoArquivoTeste = Path.Combine(caminho,"arquivo-teste.txt");
            var novoCaminhoArquivoTesteCopia = Path.Combine(caminho,"arquivo-teste-bkp.txt");

            var listaString = new List<String> { "Linha 1", "Linha 2", "Linha 3" };
            var listaStringContinuacao = new List<String> { "Linha 4", "Linha 5", "Linha 6" };

            FileHelper helper = new FileHelper();
            //helper.ListarArquivosDiretorios(caminho);
            // helper.ListarDiretorios(caminho);
            //System.Console.WriteLine("Criando diretório:" + caminhoPathCombine);
            //helper.CriarDiretorio(caminhoPathCombine);
            //helper.ApagarDiretorio(caminhoPathCombine, true);
            //helper.CriarArquivoTexto(caminhoArquivo, "Olá! Teste de escrita de arquivo");
            //helper.CriarArquivoTextoStream(caminhoArquivo, listaString);
            //helper.AdicionarArquivoTextoStream(caminhoArquivo, listaStringContinuacao);
            //helper.LerArquivoStream(caminhoArquivo);
            //helper.MoverArquivo(caminhoArquivo, novoCaminhoArquivo, false);
            //helper.CopiarArquivo(novoCaminhoArquivoTeste, novoCaminhoArquivoTesteCopia, false);
            helper.DeletarArquivos(novoCaminhoArquivoTesteCopia);
            // ICalculadora calc = new Calculadora();
            // System.Console.WriteLine(calc.Somar(10, 20));
            

            // Computador comp = new Computador();
            // System.Console.WriteLine(comp.ToString());
            // Corrente c = new Corrente();
            // c.Creditar(100);

            // c.ExibirSaldo();

            // Calculadora calc = new Calculadora();
            // System.Console.WriteLine("Resultado da primeira soma: " + calc.Somar(10, 10));
            // System.Console.WriteLine("Resultado da segunda soma: " + calc.Somar(10, 10, 10));


            // Aluno p1 = new Aluno();
            // p1.Nota = 10;
            // p1.Documento = "123456";
            // p1.Nome = "Bob";
            // p1.Idade = 20;
            // p1.Apresentar();
            // Console.WriteLine();

            // Professor p2 = new Professor();
            // p2.Salario = 2000;
            // p2.Documento = "123456";
            // p2.Nome = "David";
            // p2.Idade = 35;
            // p2.Apresentar();
            // Console.WriteLine();

        

            // //Valores válidos
            // Retangulo r = new Retangulo();
            // r.DefinirMedidas(30, 30);
            // System.Console.WriteLine($"Área: {r.ObterArea()}");

            // //Valores inválidos
            // Retangulo r2 = new Retangulo();
            // r2.DefinirMedidas(0, 0);
            // System.Console.WriteLine($"Área: {r2.ObterArea()}");

            //Pessoa p1 = new Pessoa ();

            //p1.Nome = "Bob";
            //p1.Idade = 20;

            //p1.Apresentar();
        }
    }
}
