// See https://aka.ms/new-console-template for more information
float vlrEspetaculo = 0;
float vlrConvite = 0;
Console.WriteLine("Digite o valor de custo do espetáculo:");
vlrEspetaculo = float.Parse(Console.ReadLine());
Console.WriteLine("Digite o valor do convite:");
vlrConvite = float.Parse(Console.ReadLine());
float qtdConvites = vlrEspetaculo / vlrConvite;
Console.WriteLine("Deverão ser vendidos " + qtdConvites + " convites para cobrir o valor do espetáculo.");
