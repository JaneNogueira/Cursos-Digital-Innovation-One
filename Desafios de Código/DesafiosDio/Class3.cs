//using System;

//class DesafioMedia
//{
//    static void Main()
//    {
//        int recebeNota = 0;
//        bool Opcao;
//        double X = 0;

//        while (recebeNota < 2)
//        {
//            Opcao = true;
//            double Nota = double.Parse(Console.ReadLine());

//            if (Nota < 0 || Nota > 10)
//            {
//                Console.WriteLine("nota invalida");
//            }
//            else if (recebeNota == 0)
//            {
//                X = Nota;
//                recebeNota++;
//            }
//            else if (recebeNota == 1)
//            {
//                double resultadoMedia = (X + Nota) / 2;

//                Console.Write("media = ");
//                Console.WriteLine(resultadoMedia.ToString("N2"));

//                while (Opcao == true)
//                {
//                    Console.WriteLine("novo calculo (1-sim 2-nao)");
//                    double Resultado = double.Parse(Console.ReadLine());

//                    if (Resultado == 1)
//                    {
//                        Opcao = false;
//                        recebeNota = 0;
//                    }

//                    else if (Resultado == 2)
//                    {
//                        Opcao = false;
//                        recebeNota++;
//                    }
//                }
//            }
//        }
//    }
//}