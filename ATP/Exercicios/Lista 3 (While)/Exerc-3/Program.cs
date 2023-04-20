// See https://aka.ms/new-console-template for more information
int numFunc = 0;
int qtdPecas = 0;
string sexo = "";
int funcionarios = 1;
double salario = 0;
double salarioMin = 1000;
double qtdPecasH = 0;
double qtdPecasM = 0;
int qtdHomens = 0;
int qtdMulheres = 0;
int funcMaiorSalario = 0;
double maiorSalario = 0;
int totalPecas = 0;
double totalFolhaPgto = 0;

while (funcionarios <= 15) {
    Console.WriteLine("Digite o numero do funcionário "+ funcionarios +": ");
    numFunc = int.Parse(Console.ReadLine());
    Console.WriteLine("Quantas peças esse funcionário fabricou?");
    qtdPecas = int.Parse(Console.ReadLine());
    Console.WriteLine("Qual o sexo do(a) funcionário(a)? (f)eminino ou (m)asculino");
    sexo = Console.ReadLine();

    if(sexo == "f") {
        qtdMulheres++;
        qtdPecasM += qtdPecas;
    } else if (sexo == "m") {
        qtdHomens++;
        qtdPecasH += qtdPecas;
    } else {
        Console.WriteLine("Sexo inválido.");
    }

    if (qtdPecas <= 30) {
        salario = salarioMin;
        if (salario > maiorSalario) {
            maiorSalario = salario;
            funcMaiorSalario = numFunc;
        }
    } else if ((qtdPecas > 30) && (qtdPecas <= 35)) {
        int pecasmais = qtdPecas - 30;
        double percentual = salarioMin * 0.03;
        salario = salarioMin + (pecasmais * percentual);
            if (salario > maiorSalario) {
                maiorSalario = salario;
                funcMaiorSalario = numFunc;
            }
    } else if (qtdPecas > 35) {
        int pecasmais = qtdPecas - 35;
        double percentual = salarioMin * 0.05;
        salario = salarioMin + (pecasmais * percentual);
            if (salario > maiorSalario) {
                maiorSalario = salario;
                funcMaiorSalario = numFunc;
            }
    }
    funcionarios++;
    totalPecas += qtdPecas;
    totalFolhaPgto += salario;
    Console.WriteLine("Número do funcionário: " + numFunc + " Salário: R$" + salario);
}

double mediaPecasH = qtdPecasH / qtdHomens;
double mediaPecasM = qtdPecasM / qtdMulheres;
Console.WriteLine("Total da folha de pagamento: R$" + totalFolhaPgto);
Console.WriteLine("Total de peças fabricadas: " + totalPecas);
Console.WriteLine("Média de peças fabricadas por HOMENS: " + mediaPecasH);
Console.WriteLine("Média de peças fabricadas por MULHERES: " + mediaPecasM);
Console.WriteLine("O funcionário de maior salário, é o " + funcMaiorSalario + " com um salário de R$" + maiorSalario);

