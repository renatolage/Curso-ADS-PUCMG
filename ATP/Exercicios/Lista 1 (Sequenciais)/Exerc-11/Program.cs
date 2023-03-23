// See https://aka.ms/new-console-template for more information
double horas = 0;
double salMinimo = 0;
Console.WriteLine("Insira a quantia de horas trabalhadas:");
horas = double.Parse(Console.ReadLine());
Console.WriteLine("Insira o valor do salário mínimo:");
salMinimo = double.Parse(Console.ReadLine());
double valHora = salMinimo / 2;
double salBruto = valHora * horas;
double impostos = salBruto * 0.03;
double salLiquido = salBruto - impostos;
Console.WriteLine("O valor do salário a receber é de R$" + salLiquido);
