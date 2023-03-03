// See https://aka.ms/new-console-template for more information
int num1, num2;
Console.WriteLine("Insira um número: ");
num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Insira outro número: ");
num2 = int.Parse(Console.ReadLine());
 if (num1 > num2){
    Console.WriteLine(num1 + " é maior que " + num2);
 }
 else if (num1 == num2){
    Console.WriteLine("Os dois números são iguais!");
 }
 else
 {
    Console.WriteLine(num2 + " é maior que " + num1);
 }