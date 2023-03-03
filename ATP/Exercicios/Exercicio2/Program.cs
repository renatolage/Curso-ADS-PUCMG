// See https://aka.ms/new-console-template for more information
float num = 0;
Console.WriteLine("Digite um número: ");
num = float.Parse(Console.ReadLine());
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
