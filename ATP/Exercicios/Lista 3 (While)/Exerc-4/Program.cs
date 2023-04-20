// See https://aka.ms/new-console-template for more information
double vlrDivida = 0;
double vlrJuros = 0;
double qtdParcelas = 0;
double vlrParcelas = 0;
int numDividas = 0;
int contador = 1;
Console.WriteLine("Quantas dívidas você deseja cadastrar?");
numDividas = int.Parse(Console.ReadLine());
while (numDividas > 0 ) {
    Console.WriteLine("Insira o valor da dívida " + contador);
    vlrDivida = double.Parse(Console.ReadLine());
    Console.WriteLine("Qual o valor total de parcelas?");
    qtdParcelas = int.Parse(Console.ReadLine());
}