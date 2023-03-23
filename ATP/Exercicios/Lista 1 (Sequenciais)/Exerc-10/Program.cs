// See https://aka.ms/new-console-template for more information
float precoFabrica = 0;
float percLucro = 0;
float percImposto= 0;
Console.WriteLine("Digite o preço de fábrica:");
precoFabrica = float.Parse(Console.ReadLine());
Console.WriteLine("Digite o percentual de lucro do distribuidor:");
percLucro = float.Parse(Console.ReadLine());
Console.WriteLine("Digite o percentual de impostos:");
percImposto = float.Parse(Console.ReadLine());
float lucroDistrib = (precoFabrica * percLucro) / 100;
float impostos = (precoFabrica * percImposto) / 100;
float precoFinal = precoFabrica + lucroDistrib + impostos;
Console.WriteLine("O lucro do distribuidor é de R$" + lucroDistrib);
Console.WriteLine("O valor dos impostos é R$" + impostos);
Console.WriteLine("O valor final do veículo é de R$" + precoFinal);

