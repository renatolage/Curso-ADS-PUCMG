// See https://aka.ms/new-console-template for more information
double salario = 0;
Console.WriteLine("Digite o valor do salário: ");
salario = double.Parse(Console.ReadLine());
double novoSalario = salario * 1.25;
Console.WriteLine("O valor do novo salário é de R$" + novoSalario);

