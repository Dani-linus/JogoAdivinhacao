using System;

namespace JogoAdivinhacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Versão 3: Verificar se o jogador acertou
            Console.WriteLine("---------------------------");
            Console.WriteLine("Jogo de Adivinhação");
            Console.WriteLine("---------------------------");

            Random geradornumero = new Random();
            int numeroaleatorio = geradornumero.Next(1, 5);

            Console.Write("Digite um número entre 1 a 10: ");
            int numero = Convert.ToInt32(Console.ReadLine());

           

            if (numero == numeroaleatorio)
            {
                Console.WriteLine("---------------------------");
                Console.WriteLine("Parabens, você acertou o número secreto: ");
                Console.WriteLine("---------------------------");
                
            }
            else if (numero < numeroaleatorio)
            {
                Console.WriteLine("---------------------------");
                Console.WriteLine("O número digitado é menor que o número aleatório");
                Console.WriteLine("---------------------------");
            }
            else
            {
                Console.WriteLine("---------------------------");
                Console.WriteLine("O número digitado é maior que o número aleatório");
                Console.WriteLine("---------------------------");
            }
            }
        }
}
