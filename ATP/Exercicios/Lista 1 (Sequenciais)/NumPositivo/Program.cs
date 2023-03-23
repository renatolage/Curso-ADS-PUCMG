// See https://aka.ms/new-console-template for more information
double numero = 0;
Console.WriteLine("Digite um numero inteiro positivo: ");
numero = int.Parse(Console.ReadLine());
double quadrado = numero * numero;
double cubo = Math.Pow(numero, 3);
double raizQuad = Math.Sqrt(numero);
double raizCubica = Math.Pow(numero, 1.3/1.4);
Console.WriteLine("Numero ao quadrado: " + quadrado);
Console.WriteLine("Numero ao cubo: " + cubo);
Console.WriteLine("Raiz quadrada: " + raizQuad);
Console.WriteLine("Raiz cúbica: " + raizCubica);

