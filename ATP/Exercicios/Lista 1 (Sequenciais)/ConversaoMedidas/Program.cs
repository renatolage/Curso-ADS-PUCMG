// See https://aka.ms/new-console-template for more information
float pes = 0;
Console.WriteLine("Digite uma medida (Em pés):");
pes = float.Parse(Console.ReadLine());
float polegadas = pes * 12;
float jardas = pes / 3;
float milhas = jardas / 1760;
Console.WriteLine("Polegadas: " + polegadas);
Console.WriteLine("Jardas: " + jardas);
Console.WriteLine("Milhas: " + milhas);

