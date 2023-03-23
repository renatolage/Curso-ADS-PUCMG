// See https://aka.ms/new-console-template for more information
float pesoSaco = 0;
float qtdFornecida = 0;
Console.WriteLine("Digite o peso do saco de ração (em Kg):");
pesoSaco = float.Parse(Console.ReadLine());
Console.WriteLine("Digite a quantidade de ração fornecida (em Kg): ");
qtdFornecida = float.Parse(Console.ReadLine());
float saldoRacao = pesoSaco - (5 * (qtdFornecida * 2));
Console.WriteLine("Sobrou " + saldoRacao + "Kg de ração no saco.");
