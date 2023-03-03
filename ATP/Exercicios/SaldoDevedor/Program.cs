// See https://aka.ms/new-console-template for more information
float numPrest = 0;
float prestPagas = 0;
float valorPrest = 0;
Console.WriteLine("Insira e número total de prestações: ");
numPrest = float.Parse(Console.ReadLine());
Console.WriteLine("Quantas prestações já foram pagas? ");
prestPagas = float.Parse(Console.ReadLine());
Console.WriteLine("Qual o valor de cada prestação? ");
valorPrest = float.Parse(Console.ReadLine());
float saldoDevedor = (numPrest - prestPagas) * valorPrest;
Console.WriteLine("Saldo devedor é de R$" + saldoDevedor);




