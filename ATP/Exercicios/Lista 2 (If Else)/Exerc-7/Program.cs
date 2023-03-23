// See https://aka.ms/new-console-template for more information
double salMinimo = 0;
double numHoras = 0;
double numDependentes = 0;
double qtdHorasExtras = 0;
double irrf = 0;
double vlrGratificacao = 0;
Console.WriteLine("Qual o valor do salário mínimo?:");
salMinimo = double.Parse(Console.ReadLine());
Console.WriteLine("Qual número de horas trabalhadas?:");
numHoras = double.Parse(Console.ReadLine());
Console.WriteLine("Possui quantos depentes?:");
numDependentes = double.Parse(Console.ReadLine());
Console.WriteLine("Qual a quantia de horas extras trabalhadas?:");
qtdHorasExtras = double.Parse(Console.ReadLine());
double valorHorasTrab = salMinimo / 5;
double salMes = numHoras * valorHorasTrab;
double valorHoraExtra = valorHorasTrab * 1.5;
double salarioBruto = salMes + (numDependentes*32) + (valorHoraExtra * qtdHorasExtras);
if (salarioBruto < 200){
    irrf = 0;
} else if ((salarioBruto >= 200) && (salarioBruto <= 500)) {
    irrf = salarioBruto * 0.1;
} else if ((salarioBruto > 500)){
    irrf = salarioBruto * 0.2;
}
double salarioLiquido = salarioBruto - irrf;
if (salarioLiquido <= 350){
    vlrGratificacao = 100;
} else {
    vlrGratificacao = 50;
}
double salarioReceber = salarioLiquido + vlrGratificacao;
Console.WriteLine("Valor da hora trabalhada: R$" + valorHorasTrab);
Console.WriteLine("Valor do salário do mês: R$" + salMes);
Console.WriteLine("Valor das horas extras: R$" + valorHoraExtra * qtdHorasExtras);
Console.WriteLine("Valor do salário bruto: R$" + salarioBruto);
Console.WriteLine("Valor do Imposto de Renda: R$" + irrf);
Console.WriteLine("Valor da gratificação: R$" + vlrGratificacao);
Console.WriteLine("Valor da ajuda dependentes: R$" + numDependentes * 32);
Console.WriteLine("O valor do salário a receber é de R$" + salarioReceber);


