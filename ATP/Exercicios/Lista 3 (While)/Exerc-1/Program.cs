// See https://aka.ms/new-console-template for more information
double termos = 0;
double exp = 2;
double n1 = 0;
double fatorial = 1;
double resultado = 0;
Console.WriteLine("Insira um numero inteiro e positivo:");
n1 = double.Parse(Console.ReadLine());
Console.WriteLine("Insira a quantidade de termos:");
termos = double.Parse(Console.ReadLine());
while (exp <= (termos + 1)) {
    fatorial *= (exp - 1);
    if (exp % 2 == 0) {
        resultado -= (Math.Pow(n1, exp)/fatorial);
    } else {
        resultado += (Math.Pow(n1, exp)/fatorial);
    }
    exp++;
}
Console.WriteLine(resultado);



