using System;

namespace Animais
{
    class Program
    {
        static void Main(string[] args)
        {
            //definindo as variaveis para cada elemento
            bool leao = true;
            bool cabra = true;
            bool grama = true;
            bool bote = true;

            //Loop que faz a checagem das condições
            //Enquando as condições são verdadeiras, o loop fica em execução
            while (leao || cabra || grama) {
                Console.Clear();
                Console.WriteLine("Status atual:");
                Console.WriteLine("Leão: {0}\n\rCabra: {1}\n\rGrama: {2}\n\rBote: {3}\n\r",
                                  leao ? "Margem A" : "Margem B",
                                  cabra ? "Margem A" : "Margem B",
                                  grama ? "Margem A" : "Margem B",
                                  bote ? "Margem A" : "Margem B");

                //Solicita a próxima ação ao jogador
                Console.WriteLine("Qual elemento você gostaria de transportar?");
                Console.WriteLine("L = Leão\n\rC = Cabra\n\rG = Grama\n\rB = Bote vazio");
                string movimento = Console.ReadLine();

                /*
                Verifica se a jogada pode ou não ser executada: 
                Se a letra digitada, corresponde a algum elemento a ser movido para a outra margem;
                Se o bote e o elemento a ser movido estão na mesma margem;
                Caso as duas condições sejam atendidas, o valor dos elementos são invertidos.
                */
                
                switch (movimento.ToUpper()) {

                    case "L":
                        if (leao == bote) {
                            leao = !leao;
                            bote = !bote;
                        } else {
                            Console.WriteLine("Jogada inválida! Pressine qualquer tecla para tentar novamente...");
                            Console.ReadKey();
                        }
                        break;
                    case "C":
                        if (cabra == bote) {
                            cabra = !cabra;
                            bote = !bote;
                        } else {
                            Console.WriteLine("Jogada inválida! Pressine qualquer tecla para tentar novamente...");
                            Console.ReadKey();
                        }
                        break;
                    case "G":
                        if (grama == bote) {
                            grama = !grama;
                            bote = !bote;
                        } else {
                            Console.WriteLine("Jogada inválida! Pressine qualquer tecla para tentar novamente...");
                            Console.ReadKey();
                        }
                        break;
                    case "B":
                        if (bote || !bote) {
                            bote = !bote;
                        }
                        break;
                    default:
                        Console.WriteLine("Elemento não existe! Pressine qualquer tecla para tentar novamente...");
                        Console.ReadKey();
                        break;
                }

                //Bloco if responsável por chegar as condições de vitória ou derrota.
                if (!leao && !cabra && !grama)
                {
                    Console.WriteLine("Parabéns! Você trasportou todos com segurança.");
                    break;
                } else if ((cabra && leao && !grama && !bote) || (!cabra && !leao && grama && bote)) {
                    Console.WriteLine("Você perdeu! O leão comeu a cabra.");
                    break;
                } else if ((cabra && grama && !leao && !bote) || (!cabra && !grama && leao && bote)) {
                    Console.WriteLine("Você Perdeu! A cabra comeu a grama");
                    break;
                }
            }
        }
    }
}
