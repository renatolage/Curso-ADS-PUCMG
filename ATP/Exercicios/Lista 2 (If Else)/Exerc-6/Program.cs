// See https://aka.ms/new-console-template for more information
int codigo = 0;
double salario = 0;
double vlrAumento = 0;
double novoSalario = 0;
Console.WriteLine("Digite o código do funcionário:");
codigo = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o salário do funcionário:");
salario = double.Parse(Console.ReadLine());
if (codigo == 1){
    vlrAumento = salario * 0.5;
    novoSalario = salario + vlrAumento;
    Console.WriteLine("O funcionário é um escrituário.\nO Valor do aumento é de R$"+vlrAumento+"\nSeu novo salário é de R$"+novoSalario);
} else if (codigo ==2){
    vlrAumento = salario * 0.35;
    novoSalario = salario + vlrAumento;
    Console.WriteLine("O funcionário é um secretário.\nO Valor do aumento é de R$"+vlrAumento+"\nSeu novo salário é de R$"+novoSalario);
} else if (codigo == 3){
        vlrAumento = salario * 0.2;
    novoSalario = salario + vlrAumento;
    Console.WriteLine("O funcionário é um caixa.\nO Valor do aumento é de R$"+vlrAumento+"\nSeu novo salário é de R$"+novoSalario);
} else if (codigo == 4) {
    vlrAumento = salario * 0.1;
    novoSalario = salario + vlrAumento;
    Console.WriteLine("A funcionário é um gerente.\nO Valor do aumento é de R$"+vlrAumento+"\nSeu novo salário é de R$"+novoSalario);
} else if (codigo == 5) {
    vlrAumento = salario * 0.5;
    novoSalario = salario + vlrAumento;
    Console.WriteLine("A funcionário é um gerente e não terá aumento.\nSeu salário é de R$"+salario);
}
