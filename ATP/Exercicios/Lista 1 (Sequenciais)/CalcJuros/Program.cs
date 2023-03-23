// See https://aka.ms/new-console-template for more information
float deposito = 0;
float txJuros = 0;
Console.WriteLine("Digite o valor do depósito:");
deposito = float.Parse(Console.ReadLine());
Console.WriteLine("Dgite o valor da taxa de juros:");
txJuros = float.Parse(Console.ReadLine());
float rendimento = (deposito * txJuros) / 100;
float vlrTotal = deposito + rendimento;
Console.WriteLine("O valor do rendimento é de R$" + rendimento + " e o valor após o rendimento é de R$" + vlrTotal);