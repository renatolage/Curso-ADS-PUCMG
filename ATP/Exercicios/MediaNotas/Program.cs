// See https://aka.ms/new-console-template for more information
Console.Clear();
float nota1, nota2, nota3;
Console.WriteLine("Digite a nota 1: ");
nota1 = float.Parse(Console.ReadLine());
Console.WriteLine("Digite a nota 2: ");
nota2 = float.Parse(Console.ReadLine());
Console.WriteLine("Digite a nota 3: ");
nota3 = float.Parse(Console.ReadLine());

float media = (nota1 + nota2 + nota3) / 3;

Console.WriteLine("A média das 3 notas é " + media);
