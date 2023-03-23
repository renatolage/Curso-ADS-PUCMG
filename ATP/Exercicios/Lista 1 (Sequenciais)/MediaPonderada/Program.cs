// See https://aka.ms/new-console-template for more information
float n1 = 0, n2 = 0, n3 = 0;
int p1 = 0, p2 = 0, p3 = 0;
Console.WriteLine("Digite 3 notas: ");
n1 = float.Parse(Console.ReadLine());
n2 = float.Parse(Console.ReadLine());
n3 = float.Parse(Console.ReadLine());
Console.WriteLine("Digite 3 pesos: ");
p1 = int.Parse(Console.ReadLine());
p2 = int.Parse(Console.ReadLine());
p3 = int.Parse(Console.ReadLine());

float mediaP = ((n1 * p1) + (n2 * p2) + (n3 * p3)) / (p1 + p2 + p3);

Console.WriteLine("A média ponderada das 3 notas citas é de: " + mediaP);

