// See https://aka.ms/new-console-template for more information
float salario = 0;
float reajuste = 0;
Console.WriteLine("Digite o salário:");
salario = float.Parse(Console.ReadLine());
Console.WriteLine("Dgite o valor do reajuste em %: ");
reajuste = float.Parse(Console.ReadLine());
float vlrReajuste = (salario * reajuste) / 100;
float novoSalario = salario + vlrReajuste;
Console.WriteLine("O valor do reajuste é de R$" + vlrReajuste + " e o novo valor do salário é de R$" + novoSalario);

