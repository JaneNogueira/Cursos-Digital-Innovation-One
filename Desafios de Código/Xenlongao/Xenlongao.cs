namespace DesafioCodigoDio
{
    class Xenlongao
    {
        static void Main(string[] args)
        {
            int Numero = Convert.ToInt32(Console.ReadLine());
            while(Numero -- > 0)
            {
                int valor = Convert.ToInt32(Console.ReadLine());
                int novoValor = (int)Math.Sqrt(valor);     
                int resposta = valor - novoValor;
                Console.WriteLine(resposta);
            }
        }
    }
}