// See https://aka.ms/new-console-template for more information
float tamBase = 0, tamAltura = 0;
Console.WriteLine("Digite o valor da base: ");
tamBase = float.Parse(Console.ReadLine());
Console.WriteLine("Digite o valor da altura: ");
tamAltura = float.Parse(Console.ReadLine());
float area = (tamBase * tamAltura) / 2;
Console.WriteLine("A área do triângulo é de " + area);

