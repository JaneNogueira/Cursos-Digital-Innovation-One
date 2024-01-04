using System;
using System.Collections.Generic;
using Colecoes.Helper;


namespace Colecoes
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] arrayNumeros = new int[10] {100, 1, 4, 0, 8, 15, 19, 19, 4, 100 };

            var minimo = arrayNumeros.Min();
            var maximo = arrayNumeros.Max();
            var medio = arrayNumeros.Average();
            var soma = arrayNumeros.Sum();
            var arrayUnico = arrayNumeros.Distinct().ToArray();

            System.Console.WriteLine($"O Valor mínimo é: {minimo}\r\nO valor máximo é: {maximo} \r\nE o valor médio é: {medio}\r\nA soma desses valores é: {soma}\r\nE seu novo array de valores únicos é: {string.Join(", ", arrayUnico)}");


            // var numerosParesQuery = 
            //         from num in arrayNumeros
            //         where num % 2 == 0
            //         orderby num
            //         select num;

            // var numerosParesMetodo = arrayNumeros.Where(x => x % 2 ==0).OrderBy(x => x).ToList();

            // System.Console.WriteLine("Números pares query:" + string.Join(", ", numerosParesQuery));
            // System.Console.WriteLine("Números pares método: " + string.Join(", ", numerosParesMetodo));    

            // Dictionary<string, string> estados = new Dictionary<string, string>();

            // estados.Add("SP", "São Paulo");
            // estados.Add("MG", "Minas Gerais");
            // estados.Add("BA", "Bahia");

            // foreach (KeyValuePair<string, string> item in estados)
            // {
            //     System.Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
            // }

            // string valorProcurado = "BA";

            // if(estados.TryGetValue(valorProcurado, out string estadoEncontrado))
            // {
            //     System.Console.WriteLine(estadoEncontrado);
            // }
            // else
            // {
            //     System.Console.WriteLine($"Chave {valorProcurado} não existe no dicionário");
            // 

            // System.Console.WriteLine($"Removendo o valor: {valorProcurado}");

            // estados.Remove(valorProcurado);


            // System.Console.WriteLine("Valor Original: ");
            // System.Console.WriteLine(estados[valorProcurado]);

            // estados[valorProcurado] = "BA - teste atualização";

            // System.Console.WriteLine("Valor Atualizado:");
            // System.Console.WriteLine(estados[valorProcurado]);



            // Stack<string> pilhalivros = new Stack<string>();

            // pilhalivros.Push(".NET");
            // pilhalivros.Push("DDD");
            // pilhalivros.Push("Código Limpo");

            // while (pilhalivros.Count > 0)
            // {
            //      System.Console.WriteLine($"Próximo livro para leitura: {pilhalivros.Peek()}");
            //      System.Console.WriteLine($"{pilhalivros.Pop()} lido com sucesso");
            // }

            // System.Console.WriteLine($"Livros para leitura: {pilhalivros.Count}");



            // Queue<string> fila = new Queue<string>();

            // fila.Enqueue("Jane");
            // fila.Enqueue("Mikael");
            // fila.Enqueue("Isaac");

            // System.Console.WriteLine($"Pessoas na fila: {fila.Count}");

            // while (fila.Count > 0)
            // {
            //      System.Console.WriteLine($"Vez de: {fila.Peek()}");
            //      System.Console.WriteLine($"{fila.Dequeue()} atendido");
            // }


            // OperacoesLista opLista = new OperacoesLista();
            // List<string> estados = new List<string> {"SP", "MG", "BA"};
            // string[] estadosArray = new string[2] {"SC", "MT"};

            // // estados.Add("SP");
            // // estados.Add("MG");
            // // estados.Add("BA");

            // System.Console.WriteLine($"Quantidade de elementos na lista: {estados.Count}");

            // opLista.ImprimirListaString(estados);

            // // System.Console.WriteLine("Removendo o elemento");

            // // estados.Remove("MG");

            // // estados.AddRange(estadosArray);

            // estados.Insert(1, "RJ");

            // opLista.ImprimirListaString(estados);

          
            
            //Outra forma de fazer a exibição em console

            // foreach (var item in estados)
            // {
            //     System.Console.WriteLine(item);
            // }

            // OperacoesArray op = new OperacoesArray();
            // int[] array = new int [5] {6, 3, 8, 1, 9};
            // int[] arrayCopia = new int [10];
            // string[] arrayString = op.ConverterParaArrayString(array);

            // // int valorProcurado = 8;
            // //int valorAchado = op.ObterValor(array, valorProcurado);

            // System.Console.WriteLine($"Capacidade atual do array: {array.Length}");

            // op.RedimencionarArray(ref array, array.Length * 2);

            // System.Console.WriteLine($"Capacidade atual do array após redimencionar: {array.Length}");

            // int indice = op.ObterIndice(array, valorProcurado);

            // if(indice > -1)
            // {
            //     System.Console.WriteLine($"O índice do elemento {valorProcurado} é: {indice}");
            // }
            // else
            // {
            //     System.Console.WriteLine("Valor não existente no array");
            // }
            // if(valorAchado > 0)
            // {
            //     System.Console.WriteLine("Encontrei o valor");
            // }
            // else
            // {
            //     System.Console.WriteLine("Não encontrei o valor");
            // }


            // bool todosMaiorQue = op.TodosMaiorQue(array, valorProcurado);

            // if(todosMaiorQue)
            // {
            //     System.Console.WriteLine("Todos os valores são maiores que {0}", valorProcurado);
            // }
            // else
            // {
            //     System.Console.WriteLine("Existe valores que não são maiores do que {0}", valorProcurado);
            // }

            // bool existe = op.Existe(array, valorProcurado);

            // if(existe)
            // {
            //     System.Console.WriteLine("Encontrei o valor {0}", valorProcurado);
            // }
            // else
            // {
            //     System.Console.WriteLine("Não encontrei o valor{0}", valorProcurado);
            // }


            // System.Console.WriteLine("Array original: ");
            // op.ImprimirArray(array);

            // op.OrdenarBubbleSort(ref array);
            // op.Ordenar(ref array);

            // System.Console.WriteLine("Array Ordenado: ");
            // op.ImprimirArray(array);

            // System.Console.WriteLine("Array antes da cópia: ");
            // op.ImprimirArray(arrayCopia);

            // op.Copiar(ref array, ref arrayCopia);
            // System.Console.WriteLine("Array após a cópia: ");
            // op.ImprimirArray(arrayCopia);
            
            // int[,] matriz = new int[4, 2]
            // {
            //     {8, 8},
            //     {10, 20}, 
            //     {50, 100}, 
            //     {90, 200}
            // };

            // for (int i = 0; i < matriz.GetLength(0); i++)
            // {
            //     for (int j = 0; j < matriz.GetLength(1); j++)
            //     {
            //         System.Console.WriteLine(matriz[i, j]);
            //     }
            // }

            // int[] arrayInteiros = new int[3];
            // arrayInteiros[0] = 10;
            // arrayInteiros[1] = 20;
            // arrayInteiros[2] = 30;

            // System.Console.WriteLine("Percorrendo o array pelo For");
            // for (int i = 0; i < arrayInteiros.Length; i++)
            // {
            //     System.Console.WriteLine(arrayInteiros[i]);
            // }

            // System.Console.WriteLine("Percorrendo o array pelo ForEach");
            // foreach (int item in arrayInteiros)
            // {
            //     System.Console.WriteLine(item);
            // }
            
        }
    }
}