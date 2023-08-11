using System;
using System.Net.Http.Headers;

namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {                            
                int num, cont = 0;
                Console.Write("Informe um número: ");            
                while (!int.TryParse(Console.ReadLine(), out num) || (num == ' ' && Console.KeyAvailable == false))
                {
                    Console.Write("Opção inválida. Informe uma opçao válida: ");
                }
                Console.Clear();                    

                if (num > 1)
                {
                    for (int i = 1; i < num; i++)
                    {
                        if (num % i == 0)
                        {
                            cont++;
                        }
                    }
                } else {
                    cont = 1;                   
                }

                if (cont == 1)
                {

                    Console.WriteLine("O número " + num + " é primo");
                }
                else
                {
                    Console.WriteLine("O número " + num + " não é primo");
                }
                Console.WriteLine();
            }
        }
    }
}
