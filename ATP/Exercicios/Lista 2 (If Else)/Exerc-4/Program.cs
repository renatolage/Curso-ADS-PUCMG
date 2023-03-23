// See https://aka.ms/new-console-template for more information
int numero1 = 0;
int numero2 = 0;
int numero3 = 0;
Console.WriteLine("Digite o primeiro número:");
numero1 = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o segundo número:");
numero2 = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o terceiro número:");
numero3 = int.Parse(Console.ReadLine());

if ((numero1 < numero2) && (numero2 < numero3)) {
    Console.WriteLine(numero1);
    Console.WriteLine(numero2);
    Console.WriteLine(numero3);
} else if ((numero1 < numero2) && (numero3 < numero2)) {
    Console.WriteLine(numero1);
    Console.WriteLine(numero3);
    Console.WriteLine(numero2);
} else if ((numero2 < numero1) && (numero1 < numero3)) {
    Console.WriteLine(numero2);
    Console.WriteLine(numero1);
    Console.WriteLine(numero3);
} else if ((numero2 < numero3) && (numero3 < numero1)) {
    Console.WriteLine(numero2);
    Console.WriteLine(numero3);
    Console.WriteLine(numero1);
} else if ((numero3 < numero1) && (numero1 < numero2)) {
    Console.WriteLine(numero3);
    Console.WriteLine(numero1);
    Console.WriteLine(numero2);
}else if ((numero3 < numero2) && (numero2 < numero1)) {
    Console.WriteLine(numero3);
    Console.WriteLine(numero2);
    Console.WriteLine(numero1);
}
