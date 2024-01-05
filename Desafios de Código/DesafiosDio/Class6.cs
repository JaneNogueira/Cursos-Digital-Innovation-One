//using System;

//namespace Start
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            double nota1, nota2, nota3, nota4, media;
//            string[] notas = Console.ReadLine().Split(' ');
//            nota1 = double.Parse(notas[0]) * 2;
//            nota2 = double.Parse(notas[1]) * 3;
//            nota3 = double.Parse(notas[2]) * 4;
//            nota4 = double.Parse(notas[3]) * 1;
//            media = (nota1 + nota2 + nota3 + nota4) / 10;

//            Console.WriteLine("Media: " + media.ToString("0.0"));

//            if (media >= 7.0)
//            {
//                Console.WriteLine("Aluno aprovado.");
//            }

//            else if (media < 5.0)
//            {
//                Console.WriteLine("Aluno reprovado.");
//            }

//            else if (media >= 5.0 && media <= 6.9)
//            {
//                double notaExame = double.Parse(Console.ReadLine());
//                Console.WriteLine("Aluno em exame.");
//                Console.WriteLine($"Nota do exame: {media}");
                
//                media = (media + notaExame) / 2;

//                if (media >= 5.0)
//                {
//                    Console.WriteLine("Aluno aprovado.");
//                }
//                else if (media <= 4.9)
//                {
//                    Console.WriteLine("Aluno reprovado.");
//                }
//                else 
//                {
//                    Console.WriteLine("Media final: " + media.ToString("0.0"));
//                }   
//            }

//            Console.ReadKey();
//        }
//    }
//}
