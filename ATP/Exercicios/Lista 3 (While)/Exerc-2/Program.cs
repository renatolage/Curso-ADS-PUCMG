// See https://aka.ms/new-console-template for more information
int alunos = 1;
string status = "";
int nReprovados = 0;
int nExames = 0;
int nAprovados = 0;
double mediaClasse = 0;
while (alunos <= 6) {
    Console.WriteLine("Digite a nota 1 do aluno " + alunos);
    double nota1 = double.Parse(Console.ReadLine());
    Console.WriteLine("Digite a nota 2 do aluno " + alunos);
    double nota2 = double.Parse(Console.ReadLine());
    double mediaArit = (nota1 + nota2) / 2;
    if (mediaArit <= 3) {
        status = "Reprovado";
        nReprovados++;
    } else if ((mediaArit > 3) && (mediaArit < 7)) {
        status = "em Exame";
        nExames++;
    } else if (mediaArit >= 7) {
        status = "Aprovado";
        nAprovados++;
    }
    Console.WriteLine("A média aritimética das notas do aluno " + alunos + " é igual a " + mediaArit + " e o aluno está " + status);
    alunos++;
    mediaClasse += mediaArit;

}
double mediaAritClasse = mediaClasse / 6;
Console.WriteLine("Total de alunos aprovados: " + nAprovados);
Console.WriteLine("Total de alunos em exame: " + nExames);
Console.WriteLine("Total de alunos reprovados: " + nReprovados);
Console.WriteLine("A média aritimética da classe é de: " + mediaAritClasse);