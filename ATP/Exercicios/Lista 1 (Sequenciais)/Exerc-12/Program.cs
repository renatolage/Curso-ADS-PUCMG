// See https://aka.ms/new-console-template for more information
double vlrDeposito = 0;
double vlrcheque1 = 0;
double vlrCheque2 = 0;
double cpmf = 0.038;
Console.WriteLine("Digite o valor do depósito:");
vlrDeposito = double.Parse(Console.ReadLine());
Console.WriteLine("Digite o valor do primeiro cheque:");
vlrcheque1 = double.Parse(Console.ReadLine());
Console.WriteLine("Digite o valor de segundo cheque:");
vlrCheque2 = double.Parse(Console.ReadLine());
double saldoAtual = vlrDeposito - (vlrcheque1 + (vlrcheque1*cpmf)) - (vlrCheque2 + (vlrCheque2*cpmf));
Console.WriteLine("Saldo atual é de R$" + saldoAtual);


