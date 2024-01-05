//using System;
//using System.Collections.Generic;

//class MinhaClasse
//{
//    public static void Main(string[] args)
//    {
//       //primeiro declara o limite do contator

//        int limit = int.Parse(Console.ReadLine());
//       //é criada uma lista
//        List<string> listaCompra = new List<string>();

//        for (int i = 0; i < limit; i++)
//        {
//            if (i > 100)
//            {
//                return;
//            }
//            //cria-se um array para armazenar/receber os itens
//            string[] line = Console.ReadLine().Split(" ");


//            //o length retorna a quantidade de caracteres que tem na palavra
//            for (int itemMercado = 0; itemMercado < line.Length; itemMercado++)
//            {
//                if (itemMercado > 1000)
//                {
//                    return;
//                }

//                if (!listaCompra.Contains(line[itemMercado]))
//                {
//                    listaCompra.Add(line[itemMercado]);
//                }
//            }

//            // o método sort ordena a lista por menor valor de caractere
//            listaCompra.Sort();
//            Console.WriteLine(string.Join(" ", listaCompra));
//            listaCompra.Clear();
//        }
//    }
//}
