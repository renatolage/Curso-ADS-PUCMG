// See https://aka.ms/new-console-template for more information
string sexo = "";
int numHorasAula = 0;
int codigo = 1;
double salLiquido = 0;
double totalSalMasc = 0;
double totalSalFem = 0;
double totalMasc = 0;
double totalFem = 0;

while (codigo != 99999) {
    Console.WriteLine("Digite o código do professor:");
    codigo = int.Parse(Console.ReadLine());
    Console.WriteLine("Qual o sexo do(a) professor(a): (m)asculino ou (f)eminino");
    sexo = Console.ReadLine();
    Console.WriteLine("Quantas horas dadas no mês?");
    numHorasAula = int.Parse(Console.ReadLine());
    double salBruto = numHorasAula * 30;
    double desconto = 0;
    if (sexo == "m") {
        desconto = 0.1;
        salLiquido = salBruto - desconto;
        totalMasc++;
        totalSalMasc += salLiquido;
    } else if (sexo == "f") {
        desconto = 0.05;
        salLiquido = salBruto - desconto;
        totalFem++;
        totalSalFem += salLiquido;
    }
    Console.WriteLine("Código do professor:" + codigo);
    Console.WriteLine("Salário bruto: R$" + salBruto.ToString("N2"));
    Console.WriteLine("Salário líquido: R$" + salLiquido.ToString("N2") + "\r\n");
}
double mediaSalMasc = totalSalMasc / totalMasc;
double mediaSalFem = totalSalFem / totalFem;
Console.WriteLine("Média dos salários líquidos MASCULINOS: R$" + mediaSalMasc.ToString("N2"));
Console.WriteLine("Média dos salários líquidos FEMININOS: R$" + mediaSalFem.ToString("N2"));