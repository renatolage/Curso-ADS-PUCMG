// See https://aka.ms/new-console-template for more information
int num = 0;
Console.WriteLine("Digite um número: ");
num = int.Parse(Console.ReadLine());
if ((num % 2 == 0) && (num < 0)){
    Console.WriteLine("O número é par e negativo");
}
else if ((num % 2 == 0) && (num > 0)){
    Console.WriteLine("O numero é par e positivo");
}
else if ((num % 2 == 1) && (num < 0)){
    Console.WriteLine("O número é ímpar e negativo");
}
else if ((num % 2 == 1) && (num > 0)){
    Console.WriteLine("O número é impar e positivo");
}
else
{
    Console.WriteLine("O valor digitado não é válido.");
}
