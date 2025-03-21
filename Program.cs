using System;

namespace JogoAdivinhacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Versão 1: Estrutura básica e entrada do usuário
            Console.WriteLine("---------------------------");
            Console.WriteLine("Jogo de Adivinhação");
            Console.WriteLine("---------------------------");

            Console.Write("Digite um número: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            Console.Write("Você digitou o seguinte número: " + numero);
            Console.ReadLine();
        }
    }
}
