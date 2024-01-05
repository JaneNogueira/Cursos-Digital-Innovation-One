//using System;

//class MinhaClasse
//{

//    static void Main(string[] args)
//    {

//        int qtdTeste = int.Parse(Console.ReadLine());
//        string v1, v2;
//        int bazinga = 1;
//        int deNovo = 2;
//        int rajTrapaceou = 3;

//        for (int T = 1; T <= 100; T++)
//        {
//            string[] valores = Console.ReadLine().Split();
//            v1 = valores[0];
//            v2 = valores[1];
//            if ((v1 == "tesoura") || (v2 == "papel")
//                || (v1 == "papel") || (v2 == "pedra")
//                || (v1 == "pedra") || (v2 == "lagarto")
//                || (v1 == "lagarto") || (v2 == "Spock")
//                || (v1 == "Spock") || (v2 == "tesoura"))
//                {
//                    Console.WriteLine($"Caso #{bazinga}: Bazinga!");
//                }
//            else if (v1 == v2)
//                {
//                    Console.WriteLine($"Caso #{deNovo}: De novo!");
//                }

//            else
//                {
//                    Console.WriteLine($"Caso #{rajTrapaceou}: Raj trapaceou!");
//                }
//        }

//    }

//}
