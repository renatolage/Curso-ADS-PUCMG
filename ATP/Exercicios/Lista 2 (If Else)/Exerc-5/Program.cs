// See https://aka.ms/new-console-template for more information
int numero = 0;
Console.WriteLine("Digite um numero:");
numero = int.Parse(Console.ReadLine());
if (numero % 2 == 0){
    Console.WriteLine("Numero digitado é par");
} else {
    Console.WriteLine("Número digitado é ímpar");
}
