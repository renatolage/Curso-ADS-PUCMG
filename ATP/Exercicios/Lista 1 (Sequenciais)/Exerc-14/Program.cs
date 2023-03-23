// See https://aka.ms/new-console-template for more information
float degrau = 0;
float alturaDesejada = 0;
Console.WriteLine("Digite a altura do degrau (em metros):");
degrau = float.Parse(Console.ReadLine());
Console.WriteLine("Digite a altura que deseja alcançar (em metros):");
alturaDesejada = float.Parse(Console.ReadLine());
float qtdDegraus = alturaDesejada / degrau;
Console.WriteLine("Você deverá subir " + qtdDegraus + " degraus para alcançar " + alturaDesejada + "m");
