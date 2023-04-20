// See https://aka.ms/new-console-template for more information
double salCarlos = 0;
Console.WriteLine("Insira o valor do salário de Carlos:");
salCarlos = double.Parse(Console.ReadLine());
int contador = 1;
double salJoao = salCarlos / 3;
while (salJoao <= salCarlos) {
    double txPoupanca = 0.02;
    double txRendaFixa = 0.05;
    salCarlos = (salCarlos * txPoupanca) + salCarlos;
    salJoao = (salJoao * txRendaFixa) + salJoao;
    contador++;
}
Console.WriteLine("Salário do Carlos: R$" + salCarlos.ToString("N2") + " Salário do João: R$" + salJoao.ToString("N2") + " Quantidade de Mêses: " + contador);