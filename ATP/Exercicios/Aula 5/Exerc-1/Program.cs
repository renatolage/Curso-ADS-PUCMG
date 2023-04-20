// See https://aka.ms/new-console-template for more information
double num1 = 2;
double resultado = 0;
while ((num1 <= 99)) {
    resultado = (1 - (1/Math.Pow(num1,num1)));
    num1++;
    Console.WriteLine(resultado);
}
