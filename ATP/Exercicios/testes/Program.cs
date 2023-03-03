// See https://aka.ms/new-console-template for more information
using System;

namespace testes
{
    class Program
    {
        static void Main()
        {
            int num1 = 0;
            int num2 = 0;
            var operacao = "";
            int resultado = 0;
            Console.WriteLine("Digite um número");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite uma operação");
            operacao = Console.ReadLine();

            Console.WriteLine("Digite Outro número");
            num2 = int.Parse(Console.ReadLine());

            /*
            int soma = num1 + num2;
            int sub = num1 - num2;
            int mult = num1 * num2;
            double divisao = num1 / num2;
            */


            switch (operacao) {
                case "+":
                    resultado = num1 + num2;
                    Console.WriteLine("O resultado da soma entre " + num1 + " e " + num2 + " é igual a " + resultado);
                    break;
                
                case "-":
                    resultado = num1 - num2;
                    Console.WriteLine("O resultado da subtração entre " + num1 + " e " + num2 + " é igual a " + resultado);
                    break;
                case "*":
                    resultado = num1 * num2;
                    Console.WriteLine("O resultado da multiplicação entre " + num1 + " e " + num2 + " é igual a " + resultado);
                    break;
                case "/":
                    resultado = num1 / num2;
                    Console.WriteLine("O resultado da divisão entre " + num1 + " e " + num2 + " é igual a " + resultado);
                    break;
                default:
                    Console.WriteLine("Operação inválida");
                    break;
                }
        }
    }
}




