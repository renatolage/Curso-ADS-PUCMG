// See https://aka.ms/new-console-template for more information
float totalEleitores = 0;
float votosBrancos = 0;
float votosNulos = 0;
float votosValidos = 0;

Console.WriteLine("Total de eleitores: ");
totalEleitores = float.Parse(Console.ReadLine());
Console.WriteLine("Total de votos em branco: ");
votosBrancos = float.Parse(Console.ReadLine());
Console.WriteLine("Total de votos nulos: ");
votosNulos = float.Parse(Console.ReadLine());
Console.WriteLine("Total de votos válidos: ");
votosValidos = float.Parse(Console.ReadLine());
float brancos = (votosBrancos/totalEleitores) * 100;
float nulos = (votosNulos/totalEleitores) * 100;
float validos = (votosValidos/totalEleitores) * 100;
Console.WriteLine("Os votos em branco representam " + brancos + "% dos eleitores.");
Console.WriteLine("Os votos nulos representam " + nulos + "% dos eleitores.");
Console.WriteLine("Os votos válidos representam " + validos + "% dos eleitores.");