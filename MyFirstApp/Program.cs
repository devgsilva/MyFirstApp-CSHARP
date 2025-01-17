using System;
using System.Collections.Generic;

namespace MyFirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            
            short currentNumber = 0;
            List<int> validatedNumbers = new List<int>();
            int total;

            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine($"Digite 3 números para somá-los (um de cada vez). Range permitido: {short.MinValue} até {short.MaxValue}\n");

            do
            {
                Console.Write("Digite os números a serem somados: ");
                string input = Console.ReadLine();

                if (short.TryParse(input, out currentNumber))
                {
                    if (currentNumber >= short.MinValue && currentNumber <= short.MaxValue)
                    {
                        validatedNumbers.Add(currentNumber);
                    }
                    else
                    {
                        Console.WriteLine($"O número informado está fora do permitido que é {short.MinValue} até {short.MaxValue}");
                    }
                }
                else
                {
                    Console.WriteLine("Entrada inválida. Por favor, digite apenas números.\n");
                }
            } while (validatedNumbers.Count < 3);

            total = validatedNumbers .Sum();
            Console.WriteLine("\n===== Resultado =====");
            Console.WriteLine("A soma dos números digitados é: " + total);
        }
    }
}
