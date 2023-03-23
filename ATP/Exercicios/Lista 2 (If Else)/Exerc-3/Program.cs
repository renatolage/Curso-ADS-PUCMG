// See https://aka.ms/new-console-template for more information
double nota1 = 0;
double nota2 = 0;
double nota3 = 0;
Console.WriteLine("Insira a nota do trabalho de laboratório:");
nota1 = double.Parse(Console.ReadLine());
Console.WriteLine("Insira a nota da avaliação semestral:");
nota2 = double.Parse(Console.ReadLine());
Console.WriteLine("Insira a nota do exame final:");
nota3 = double.Parse(Console.ReadLine());
double mediaPonderada = ((nota1 * 2) + (nota2 * 3) + (nota3 * 5))/(2+3+5);
Console.WriteLine("A media ponderada é de " + mediaPonderada);
if (mediaPonderada < 5) {
    Console.WriteLine("E");
} else if (mediaPonderada < 6) {
    Console.WriteLine("D");
} else if (mediaPonderada < 7) {
    Console.WriteLine("C");
} else if (mediaPonderada < 8) {
    Console.WriteLine("B");
} else if (mediaPonderada <= 10) {
    Console.WriteLine("A");
}
