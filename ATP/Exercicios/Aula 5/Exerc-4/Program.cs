int ladoA = 0;
int ladoB = 0;
int ladoC = 0;
int cont = 1;
while (cont <=5) {

    Console.WriteLine("Digite o lado A do triangulo " + cont + ":");
    ladoA = int.Parse(Console.ReadLine());
    Console.WriteLine("Digite o lado B do triângulo " + cont + ":");
    ladoB = int.Parse(Console.ReadLine());
    Console.WriteLine("Digite o lado C do triângulo " + cont + ":");
    ladoC = int.Parse(Console.ReadLine());

    if ((ladoA+ladoB>=ladoC) && (ladoA+ladoC>=ladoB) && (ladoB+ladoC>=ladoA)) {
        if(ladoA == ladoB && ladoB == ladoC) {
            Console.WriteLine("Triangulo " + cont + " é equilátero");
        } else if (ladoA!=ladoB && ladoB!=ladoC && ladoC!=ladoA){
            Console.WriteLine("Triangulo " + cont + " é escaleno");
        } else if ((ladoA==ladoB && ladoB!=ladoC) || (ladoA==ladoC && ladoC!=ladoB) || (ladoB==ladoC && ladoC!=ladoA)) {
            Console.WriteLine("Triangulo " + cont + " é isósceles");
        }

    } else {
        Console.WriteLine("Os dados informados não formam um triângulo");
    }
    cont++;    
}
