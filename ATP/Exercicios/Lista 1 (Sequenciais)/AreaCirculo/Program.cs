// See https://aka.ms/new-console-template for more information
double raio = 0;
Console.WriteLine("Digite o raio do círculo: ");
raio = double.Parse(Console.ReadLine());
double area = (raio * raio) * 2.14;
Console.WriteLine("A área do círculo é de " + area);