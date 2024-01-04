namespace ExemploConstrutores.Models
{
    public class Matematica
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Matematica(int x, int y)
        {
            X = x;
            Y = y;

            Calculadora.EventoCalculadora += EventHandLer;
        }

        public void Somar()
        {
            Calculadora.Somar(X, Y);
        }

        public void EventHandLer()
        {
            System.Console.WriteLine("Método executado");
        }
    }
}