// See https://aka.ms/new-console-template for more information
int nascimento = 0;
int anoAtual = 0;
Console.WriteLine("Digite seu ano de nascimento:");
nascimento = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o ano atual: ");
anoAtual = int.Parse(Console.ReadLine());
int idade = anoAtual - nascimento;
int idade2050 = (2050 - anoAtual) + idade;
Console.WriteLine("Idade atual: " + idade + " anos");
Console.WriteLine("Idade em 2050: " + idade2050 + " anos");

