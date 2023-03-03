float valorKwh = 0;
int consumo = 0;
Console.WriteLine("Informe o valor (em R$) do Kw/H: ");
valorKwh = float.Parse(Console.ReadLine());
Console.WriteLine("Informe a quantidade de Kw/H consumida: ");
consumo = int.Parse(Console.ReadLine());
float contaDeLuz = valorKwh * consumo;
Console.WriteLine("O valor da conta de luz é de R$" + contaDeLuz);
