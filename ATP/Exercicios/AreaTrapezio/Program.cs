// See https://aka.ms/new-console-template for more information
float baseMaior = 0;
float baseMenor = 0;
float altura = 0;
Console.WriteLine("Digite o valor da base MAIOR: ");
baseMaior = float.Parse(Console.ReadLine());
Console.WriteLine("Digite o valor da base MENOR: ");
baseMenor = float.Parse(Console.ReadLine());
Console.WriteLine("Digite o valor da Altura: ");
altura = float.Parse(Console.ReadLine());
float area = ((baseMaior + baseMenor) * altura) / 2;
Console.WriteLine("O valor da área do trapézio: " + area );





