// See https://aka.ms/new-console-template for more information
double altura = 0.0;
double largura = 0.0;
Console.WriteLine("Calcula o perímetro, a área e a diagonal de um retângulo");
Console.WriteLine("Digite a altura do retângulo: ");
altura = double.Parse(Console.ReadLine());
Console.WriteLine("Digite a largura do retângulo: ");
largura = double.Parse(Console.ReadLine());
double perimetro = 2 * (altura + largura);
double area = altura * largura;
//double aux = (altura * altura) + (largura * largura);
double diagonal = Math.Sqrt((altura * altura) + (largura * largura));
Console.WriteLine("O perímetro do retângulo de altura " + altura + " e largura " + largura + " é igual a " + perimetro);
Console.WriteLine("ele tem a área de " + area + " e a sua diagonal equivale a " + diagonal);

