using System;
using System.ComponentModel.Design;
using System.Numerics;

namespace JogoAdivinhacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int totaltentativa = 0;
            int[] historicoNumeros;

            while (true)
            {

                // Armazenar e exibir números já digitados.
                //Não permitir o uso de números repetidos ao chutar.

                Console.Clear();
                Console.WriteLine("---------------------------");
                Console.WriteLine("Jogo de Adivinhação");
                Console.WriteLine("---------------------------");

                Console.WriteLine("Escolha um nível de dificuldade ");
                Console.WriteLine("1 - Fácil (10 tentativas)");
                Console.WriteLine("2 - Médio (5 tentativas)");
                Console.WriteLine("3 - Difícil (3 tentativas)");
                Console.WriteLine("----------------------------------------");


                int nivel = Convert.ToInt32(Console.ReadLine());
               

                Random geradornumero = new Random();
                int numeroaleatorio = geradornumero.Next(1, 5);
                Console.WriteLine("Numero" + numeroaleatorio);
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

                historicoNumeros = new int[totaltentativa];

                for (int tentativa = 0; tentativa <= totaltentativa; tentativa++)
                {

                    if (tentativa == totaltentativa)
                    {
                        Console.WriteLine("----------------------------------------");
                        Console.WriteLine($"Que pena! Você usou todas as tentativas. O número era {numeroaleatorio}.");
                        Console.WriteLine("----------------------------------------");
                        Console.ReadLine();
                        break;
                    }
                    else

                    Console.Write("Digite um número entre 1 a 5: ");
                    int numero = Convert.ToInt32(Console.ReadLine());

                    historicoNumeros[tentativa] = numero;

                    if (tentativa == 1)
                    {
                        for (int i = 0; i <= historicoNumeros[tentativa]; i++)
                        {
            
                            if (historicoNumeros[i] == numero && numero != numeroaleatorio)
                            {
                                Console.WriteLine("O número já foi digitado, por gentileza tentar outro");
                            }
                            else
                            {
                                if (numero == numeroaleatorio)
                                {

                                    Console.WriteLine("---------------------------");
                                    Console.WriteLine("Parabens, você acertou o número secreto");
                                    Console.WriteLine("---------------------------");

                                    Console.ReadLine();
                                    break;
                                }

                                else if (numeroaleatorio < numero)
                                {
                                    Console.WriteLine("---------------------------");
                                    Console.WriteLine("O número secreto é menor que o número digitado");
                                    Console.WriteLine("---------------------------");

                                }
                                else if (numeroaleatorio > numero)
                                {
                                    Console.WriteLine("---------------------------");
                                    Console.WriteLine("O número secreto é maior que o número digitado");
                                    Console.WriteLine("---------------------------");

                                }

                            }
                        }

                        Console.WriteLine("Aperte ENTER para continuar...");
                        Console.ReadLine();
                    }              
                }
            }

        }
    }
}


