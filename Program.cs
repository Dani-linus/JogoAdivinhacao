using System;

namespace JogoAdivinhacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                //Versão 4: Criar múltiplas tentativas
                Console.WriteLine("---------------------------");
                Console.WriteLine("Jogo de Adivinhação");
                Console.WriteLine("---------------------------");

                Console.WriteLine("Escolha um nível de dificuldade ");
                Console.WriteLine("1 - Fácil (10 tentativas)");
                Console.WriteLine("2 - Médio (5 tentativas)");
                Console.WriteLine("3 - Difícil (3 tentativas)");
                Console.WriteLine("----------------------------------------");

                int nivel = Convert.ToInt32(Console.ReadLine());
                int totaltentativa = 0;

                Random geradornumero = new Random();
                int numeroaleatorio = geradornumero.Next(1, 5);

                if (nivel == 1)
                {
                    totaltentativa = 10;
                }
                else if (nivel == 2)
                {
                    totaltentativa = 5;
                }
                else if (nivel == 3)
                {
                    totaltentativa = 3;
                }

                for (int tentativa = 0; tentativa < totaltentativa; tentativa++)
                {

                    Console.Write("Digite um número entre 1 a 10: ");
                    int numero = Convert.ToInt32(Console.ReadLine());


                    if (numero == numeroaleatorio)
                    {
                        Console.WriteLine("---------------------------");
                        Console.WriteLine("Parabens, você acertou o número secreto");
                        Console.WriteLine("---------------------------");
                        break;
                    }
                    else if (numeroaleatorio < numero)
                    {
                        Console.WriteLine("---------------------------");
                        Console.WriteLine("O número secreto é menor que o número digitado");
                        Console.WriteLine("---------------------------");
                    }
                    else
                    {
                        Console.WriteLine("---------------------------");
                        Console.WriteLine("O número secreto é maior que o número digitado");
                        Console.WriteLine("---------------------------");
                    }
                    Console.WriteLine("Aperte ENTER para continuar...");
                    Console.ReadLine();
                }
            }
        }
        }
}
