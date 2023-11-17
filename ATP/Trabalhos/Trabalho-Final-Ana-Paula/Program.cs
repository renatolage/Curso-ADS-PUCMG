using System;
using System.Globalization;
class Program
{
    static void ImprimirTabuleiro(char[,] tabuleiro)
    {   Console.Write("   0 1 2 3 4 5 6 7 8 9");
        Console.WriteLine();
        for(int i = 0; i < tabuleiro.GetLength(0); i++)
        {   Console.Write(i + " ");
            for(int j = 0; j < tabuleiro.GetLength(1); j++)
            {
                Console.Write("|"+tabuleiro[i,j]);
            }
            Console.WriteLine("|");
        }
    }
    static char[,] PreencheTabuleiroHumano ()
    {
        char[,] tabuleiroHumano = new char[10,10];
        int[] embarcacoes = {4,3,2,1,1};
        int escolha;
        Console.WriteLine("Digite o tipo de embarcação que deseja posicionar:");
        Console.WriteLine("1 - Submarino");
        Console.WriteLine("2 - Hidroavião");
        Console.WriteLine("3 - Cruzador");
        Console.WriteLine("4 - Encouraçado");
        Console.WriteLine("5 - Porta-Aviões");
        escolha = int.Parse(Console.ReadLine());
        switch (escolha)
        {
            case 1:
                Console.WriteLine("Escolha a posição no tabuleiro abaixo:");            
            break;
        }
        

        return tabuleiroHumano;
    }
    static void Main()
    {
        char[,] teste = new char[10,10];
        ImprimirTabuleiro(PreencheTabuleiroHumano());
    }
}

