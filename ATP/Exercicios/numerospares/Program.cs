using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 0; //numero que a pessoa quiser 
            Console.WriteLine("Olá me diga um numero!");
            n1 = int.Parse(Console.ReadLine());

            if ((n1 < 0) && (n1 % 2 == 0))
            {
                Console.WriteLine("Este numero é negativo e par.");
            }
            else if ((n1 > 0) && (n1 % 2 == 0))
            {
                Console.WriteLine("Este numero é positivo e par.");
            }
            else if ((n1 < 0) && (n1 % 1 == 0))
            {
                Console.WriteLine("Este numero é negativo e impar.");
            }
            else if ((n1 > 0) && (n1 % 1 == 0))
            {
                Console.WriteLine("Este numero é positivo e impar.");
            }
            else
            {
                Console.WriteLine("O numero digitado é invalido");
            }
            Console.ReadLine();
        }
    }
}