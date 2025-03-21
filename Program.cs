using System;

namespace JogoAdivinhacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Versão 2: Gerar um número secreto aleatório
            Console.WriteLine("---------------------------");
            Console.WriteLine("Jogo de Adivinhação");
            Console.WriteLine("---------------------------");

            Random geradornumero = new Random();
            int numeroaleatorio = geradornumero.Next(1, 11);

            Console.Write("Digite um número entre 1 a 10: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Você digitou o seguinte número: " + numero);
            Console.WriteLine($"O número secreto é: {numeroaleatorio}");
            Console.ReadLine();

            
        }
    }
}
