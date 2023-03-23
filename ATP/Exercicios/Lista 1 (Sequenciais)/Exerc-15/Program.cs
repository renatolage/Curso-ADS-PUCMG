// See https://aka.ms/new-console-template for more information
double vlrSalarioMin = 0;
double qtdKw = 0;
Console.WriteLine("Digite o valor do salário mínimo:");
vlrSalarioMin = double.Parse(Console.ReadLine());
Console.WriteLine("Digite a quantidade de Kw consumida:");
qtdKw = double.Parse(Console.ReadLine());
double vlrKw = vlrSalarioMin / 5;
double vlrDevido = vlrKw * qtdKw;
double vlrDesconto = vlrDevido - (vlrDevido * 0.15);
Console.WriteLine("Valor do Kw: R$" + vlrKw);
Console.WriteLine("Valor total a ser pago: R$" + vlrDevido);
Console.WriteLine("Valor com desconto: R$" + vlrDesconto);