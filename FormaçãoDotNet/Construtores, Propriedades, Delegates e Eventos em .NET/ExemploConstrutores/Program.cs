using System;
using ExemploConstrutores.Models;

namespace ExemploConstrutores
{
    class Program
    {
        public delegate void Operacao(int x, int y);
        static void Main(string[] args)
        {
            Matematica m = new Matematica (10, 20);
            m.Somar();
            //Operacao op = Calculadora.Somar;
            // Operacao op = new Operacao(Calculadora.Somar);
            // op += Calculadora.Subtrair;

            // op.Invoke(10, 10);

            //op(10, 10); também posso chamar o delegate dessa forma. 
            // const double pi = 3.14;
            // System.Console.WriteLine(pi);

            // Data data = new Data ();
             //data.SetMes(2);

            // data.Mes = 12;
            // System.Console.WriteLine(data.Mes);

            // data.ApresentarMes();

            // Log log = Log.GetInstance();
            // log.PropriedadeLog = "Teste instancia";

            // Log log2 = Log.GetInstance();
            // System.Console.WriteLine(log2.PropriedadeLog);

            // Aluno p1 = new Aluno("Jane", "Nogueira", "Disciplina Teste");
            // p1.Apresentar();
        }
    }
}
