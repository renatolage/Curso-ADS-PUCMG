// See https://aka.ms/new-console-template for more information
int lado1 = 0;
int lado2 = 0;
int lado3 = 0;
Console.WriteLine("Digite a medida do lado 1:");
lado1 = int.Parse(Console.ReadLine());
Console.WriteLine("Digite a medida do lado 2:");
lado2 = int.Parse(Console.ReadLine());
Console.WriteLine("Digite a medida do lado 3:");
lado3 = int.Parse(Console.ReadLine());
if ((lado1 == lado2) && (lado2 == lado3)) {
    Console.WriteLine("Triangulo Equilátero");
} else if ((lado1 == lado2) || (lado2 == lado3) || (lado3 == lado1)){
    Console.WriteLine("Triangulo Isósceles");
} else if ((lado1 != lado2) && (lado2 != lado3) && (lado3 != lado1)) {
    Console.WriteLine("Triangulo Escaleno");
}
