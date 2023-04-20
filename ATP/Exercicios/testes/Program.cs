// See https://aka.ms/new-console-template for more information
string continua = "sim";
int numero = 0;
while (continua == "sim"){
    Console.WriteLine("Digite um número:");
    numero = int.Parse(Console.ReadLine());
    Console.WriteLine(numero * 3);
    Console.WriteLine("Deseja Continuar?");
    continua = Console.ReadLine();
}





