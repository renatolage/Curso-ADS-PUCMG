// See https://aka.ms/new-console-template for more information
float qtdRacao = 0;
Console.WriteLine("Digite a quantidade de ração:");
qtdRacao = float.Parse(Console.ReadLine());
if (qtdRacao > 100){
    Console.WriteLine("Quantidade suficiente.");
} else if (qtdRacao < 50) {
    Console.WriteLine("Quantidade abaixo do ideal.");
} else if (qtdRacao <= 100) {
    Console.WriteLine("Quantidade em alerta");
}
