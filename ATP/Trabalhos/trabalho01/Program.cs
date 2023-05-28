using System;

class Program
{
    //Declaração de todas as variáveis utilizadas no sistema, incluindo os vetores.

    static int capacidadeMaxima = 100;
    static string[] codigosVoos = new string[capacidadeMaxima];
    static int[] distanciasVoos = new int[capacidadeMaxima];
    static int[] assentosDisponiveisVoos = new int [capacidadeMaxima];
    static string[,] passageirosVoos = new string[capacidadeMaxima, capacidadeMaxima];
    static string[] codigosPassageiros = new string[capacidadeMaxima];
    static string[] nomesPassageiros = new string[capacidadeMaxima];
    static int numVoos = 0;
    static int numPassageiros = 0;

    /*
    Método responsável pela função de construir o menu INICIAL. 
    Esse método utiliza o comando WHILE para manter o menu presente até que uma opção válida seja digitada pelo usuário. 
    O Comando SWITCH identifica o código digitado pelo usuário e chama o método referente aquela opção.
    Ao digitar a opção "9", o valor de "sair" é alterado para "true", fazendo com que o programa seja finalizado.
    */

    static void Main()
    {

        bool sair = false;
        while (!sair)
        {
            Console.WriteLine();
            Console.WriteLine("=== Menu ===");
            Console.WriteLine("1. Cadastrar Voos");
            Console.WriteLine("2. Cadastrar passageiros");
            Console.WriteLine("3. Ver Voos");
            Console.WriteLine("4. Ver passageiros");
            Console.WriteLine("5. Alterar um passageiro");
            Console.WriteLine("6. Excluir passageiro");
            Console.WriteLine("7. Alterar um Voo");
            Console.WriteLine("8. Excluir Voo");
            Console.WriteLine("9. Sair");
            Console.Write("Escolha uma opção: ");
            string opcao = Console.ReadLine();
            Console.WriteLine();

            switch (opcao)
            {
                case "1":
                    CadastrarVoos();
                    break;
                case "2":
                    CadastrarPassageiros();
                    break;
                case "3":
                    VerVoos();
                    break;
                case "4":
                    VerPassageiros();
                    break;
                case "5":
                    AlterarPassageiro();
                    break;
                case "6":
                    ExcluirPassageiro();
                    break;
                case "7":
                    AlterarVoo();
                    break;
                case "8":
                    ExcluirVoo();
                    break;
                case "9":
                    sair = true;
                    Console.WriteLine("Programa encerrado.");
                    break;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }

            Console.WriteLine();
        }
    }

    /*
    Método responsável pela função de cadastrar Voos.
    Neste método, o usuário deverá preencher os dados conforme solicitado, são eles: Código do voo, distância e quantidade de assentos disponíveis
    */
    static void CadastrarVoos()
    {
        Console.WriteLine("=== Cadastrar Voos ===");

        if (numVoos >= codigosVoos.Length)
        {
            Console.WriteLine("Capacidade máxima de voos atingida.");
            return;
        }

        Console.Write("Código do Voo: ");
        string codigoVoo = Console.ReadLine();

        Console.Write("Distância a ser percorrida (em km): ");
        int distanciaVoo = int.Parse(Console.ReadLine());

        Console.Write("Quantidade de assentos disponíveis: ");
        int assentosDisponiveis = int.Parse(Console.ReadLine());

        codigosVoos[numVoos] = codigoVoo;
        distanciasVoos[numVoos] = distanciaVoo;
        assentosDisponiveisVoos[numVoos] = assentosDisponiveis;

        numVoos++;

        Console.WriteLine("Voo cadastrado com sucesso.");
    }

    /*
    Método responsável pela função de cadastrar passageiros.
    Neste método, o usuário deverá preencher os dados conforme solicitado, são eles: Código do passageiro, 
    nome e código do voo.
    */
    static void CadastrarPassageiros()
    {
        Console.WriteLine("=== Cadastrar Passageiros ===");

        if (numPassageiros >= codigosPassageiros.Length)
        {
            Console.WriteLine("Capacidade máxima de passageiros atingida.");
            return;
        }

        Console.Write("Código do passageiro: ");
        string codigoPassageiro = Console.ReadLine();

        Console.Write("Nome do passageiro: ");
        string nomePassageiro = Console.ReadLine();

        Console.Write("Código do Voo: ");
        string codigoVoo = Console.ReadLine();

        int vooIndex = Array.IndexOf(codigosVoos, codigoVoo);
        if (vooIndex == -1)
        {
            Console.WriteLine("Voo não encontrado.");
            return;
        }

        int assentosDisponiveis = assentosDisponiveisVoos[vooIndex];
        if (assentosDisponiveis <= 0)
        {
            Console.WriteLine("Não há assentos disponíveis para este Voo.");
            return;
        }

        for (int i = 0; i < numPassageiros; i++)
        {
            if (codigosPassageiros[i] == codigoPassageiro)
            {
                Console.WriteLine("Já existe um passageiro com esse código.");
                return;
            }
        }

        passageirosVoos[numPassageiros, vooIndex] = codigoPassageiro;
        codigosPassageiros[numPassageiros] = codigoPassageiro;
        nomesPassageiros[numPassageiros] = nomePassageiro;

        numPassageiros++;
        assentosDisponiveisVoos[vooIndex]--;

        Console.WriteLine("Passageiro cadastrado com sucesso.");
    }

    /*
    Método responsável pela função de construir o menu de VOOS.
    O Comando SWITCH identifica o código digitado pelo usuário e chama o método referente aquela opção.
    */
    static void VerVoos()
    {   
        Console.WriteLine();
        Console.WriteLine("=== Ver Voos ===");

        if (numVoos == 0)
        {
            Console.WriteLine("Nenhum Voo cadastrado.");
            return;
        }

        Console.WriteLine("1. Ver todos os Voos");
        Console.WriteLine("2. Ver Voos com mais passageiros");
        Console.WriteLine("3. Ver Voos com menos passageiros");
        Console.WriteLine("4. Ver Voo com maior distância");
        Console.WriteLine("5. Ver Voo com menor distância");
        Console.WriteLine("6. Ver ocupação média dos Voos");
        Console.WriteLine("7. Voltar ao menu inicial");
        Console.Write("Escolha uma opção: ");
        string opcao = Console.ReadLine();

        switch (opcao)
        {
            case "1":
                VerTodosVoos();
                break;
            case "2":
                VooMaisPassageiros();
                break;
            case "3":
                VooMenosPassageiros();
                break;
            case "4":
                VooMaiorDistancia();
                break;
            case "5":
                VooMenorDistancia();
                break;
            case "6":
                OcupacaoMediaVoos();
                break;
            case "7":
                Main();
                break;
            default:
                Console.WriteLine("Opção inválida.");
                break;
        }
    }

    /*
    Método responsável pela função de listar todos os voos
    */

    static void VerTodosVoos(){
        Console.WriteLine("=== Todos os Voos ===");
        for (int i = 0; i < numVoos; i++)
        {
            Console.WriteLine($"Voo: {codigosVoos[i]}, Distância: {distanciasVoos[i]} km, Assentos Disponíveis: {assentosDisponiveisVoos[i]}");
        }
        VerVoos();
    }

    /*
    Método responsável pela função de identificar o voo com MAIOR número de passageiros.
    */
    static void VooMaisPassageiros(){
        Console.WriteLine("=== Voos com mais Passageiros ===");
        int maxPassageiros = -1;
        for (int i = 0; i < numVoos; i++)
        {
            int passageiros = ContarPassageiros(i);
            if (passageiros > maxPassageiros)
            {
                maxPassageiros = passageiros;
            }
        }
        for (int i = 0; i < numVoos; i++)
        {
            int passageiros = ContarPassageiros(i);
            if (passageiros == maxPassageiros)
            {
                Console.WriteLine($"Voo: {codigosVoos[i]}, Passageiros: {passageiros}");
            }
        }
        VerVoos();
    }

    /*
    Método responsável pela função de identificar o voo com MENOR número de passageiros.
    */
    static void VooMenosPassageiros(){
        Console.WriteLine("=== Voos com menos Passageiros ===");
        int minPassageiros = int.MaxValue;
        for (int i = 0; i < numVoos; i++)
        {
            int passageiros = ContarPassageiros(i);
            if (passageiros < minPassageiros)
            {
                minPassageiros = passageiros;
            }
        }
        for (int i = 0; i < numVoos; i++)
        {
            int passageiros = ContarPassageiros(i);
            if (passageiros == minPassageiros)
            {
                Console.WriteLine($"Voo: {codigosVoos[i]}, Passageiros: {passageiros}");
            }
        }
        VerVoos();
    }

    /*
    Método responsável pela função de identificar o voo com MAIOR distância.
    */
    static void VooMaiorDistancia(){
        Console.WriteLine("=== Voo com Maior Distância ===");
        int maxDistancia = -1;
        int vooIndexMaxDistancia = -1;
        for (int i = 0; i < numVoos; i++)
        {
            if (distanciasVoos[i] > maxDistancia)
            {
                maxDistancia = distanciasVoos[i];
                vooIndexMaxDistancia = i;
            }
        }
        Console.WriteLine($"Voo: {codigosVoos[vooIndexMaxDistancia]}, Distância: {maxDistancia} km");
        VerVoos();
    }

    /*
    Método responsável pela função de identificar o voo com MENOR distância.
    */
    static void VooMenorDistancia(){
        Console.WriteLine("=== Voo com Menor Distância ===");
        int minDistancia = int.MaxValue;
        int vooIndexMinDistancia = -1;
        for (int i = 0; i < numVoos; i++)
        {
            if (distanciasVoos[i] < minDistancia)
            {
                minDistancia = distanciasVoos[i];
                vooIndexMinDistancia = i;
            }
        }
        Console.WriteLine($"Voo: {codigosVoos[vooIndexMinDistancia]}, Distância: {minDistancia} km");
        VerVoos();
    }

    /*
    Método responsável pela função de calcular a média de ocupação dos voos.
    */
    static void OcupacaoMediaVoos(){
        Console.WriteLine("=== Ocupação Média dos Voos ===");
        if (numVoos == 0)
        {
            Console.WriteLine("Nenhum Voo cadastrado.");
        }
        else
        {
            int totalPassageiros = 0;
            int totalAssentos = 0;
            for (int i = 0; i < numVoos; i++)
            {
                totalPassageiros += ContarPassageiros(i);
            }
            totalAssentos = SomarAssentos(0) + totalPassageiros;
            double ocupacaoMedia = (double)totalPassageiros / totalAssentos;
            Console.WriteLine("Total de Passageiros: " + totalPassageiros);
            Console.WriteLine("Total de assentos: " + totalAssentos);
            Console.WriteLine($"Ocupação média dos Voos: {ocupacaoMedia:P}");
        }
        VerVoos();
    }

    /*
    Método responsável pela função de construir o menu de PASSAGEIROS.
    O Comando SWITCH identifica o código digitado pelo usuário e chama o método referente aquela opção.
    */
    static void VerPassageiros()
    {
        Console.WriteLine();
        Console.WriteLine("=== Ver Passageiros ===");

        if (numPassageiros == 0)
        {
            Console.WriteLine("Nenhum passageiro cadastrado.");
            return;
        }

        Console.WriteLine("1. Passageiro específico");
        Console.WriteLine("2. Ver todos passageiros de um Voo");
        Console.WriteLine("3. Voltar ao menu inicial");
        Console.Write("Escolha uma opção: ");
        string opcao = Console.ReadLine();

        switch (opcao)
        {
            case "1":
                VerPassageiroEspecifico();
                break;
            case "2":
                VerTodosPassageiros();
                break;
            case "3":
                Main();
                break;
            default:
                Console.WriteLine("Opção inválida.");
                break;
        }
    }

    /*
    Método responsável pela função de exibir um passageiro. Neste método, o usuário deverá informar o código de um passageiro específico.
    */
    static void VerPassageiroEspecifico(){
        Console.Write("Código do passageiro: ");
        string codigoPassageiro = Console.ReadLine();
        int passageiroIndex = Array.IndexOf(codigosPassageiros, codigoPassageiro);
        if (passageiroIndex == -1)
        {
            Console.WriteLine("Passageiro não encontrado.");
            return;
        }
        Console.WriteLine();
        Console.WriteLine("=== Passageiro por código ===");
        Console.WriteLine($"Nome do passageiro: {nomesPassageiros[passageiroIndex]}");
        VerPassageiros();
    }

    /*
    Método responsável pela funçã de listar todos os passageiros cadastrados no sistema.
    */
    static void VerTodosPassageiros(){
        Console.Write("Código do Voo: ");
        string codigoVoo = Console.ReadLine();
        int vooIndex = Array.IndexOf(codigosVoos, codigoVoo);
        if (vooIndex == -1)
        {
            Console.WriteLine("Voo não encontrado.");
            return;
        }
        Console.WriteLine();
        Console.WriteLine($"=== Passageiros do Voo {codigoVoo} ===");
        for (int i = 0; i < numPassageiros; i++)
        {
            if (passageirosVoos[i, vooIndex] != null)
            {
                Console.WriteLine($"Código: {codigosPassageiros[i]}, Nome: {nomesPassageiros[i]}");
            }
        }
        VerPassageiros();
    }

    /*
    Método responsável pela função de alterar os dados de um passageiro. Para realizar a alteração, o usuário deverá informar o código do passageiro
    Este método altera apenas o NOME do passageiro. Caso o usuário queira alterar outros dados, ele deverá utilizar o método "ExcluirPassageiro"
    e em seguida, o método "InserirPassageiro".
    */
    static void AlterarPassageiro()
    {
        Console.WriteLine("=== Alterar Passageiro ===");

        if (numPassageiros == 0)
        {
            Console.WriteLine("Nenhum passageiro cadastrado.");
            return;
        }

        Console.Write("Código do passageiro: ");
        string codigoPassageiro = Console.ReadLine();
        int passageiroIndex = Array.IndexOf(codigosPassageiros, codigoPassageiro);
        if (passageiroIndex == -1)
        {
            Console.WriteLine("Passageiro não encontrado.");
            return;
        }

        Console.Write("Novo nome do passageiro: ");
        string novoNome = Console.ReadLine();

        nomesPassageiros[passageiroIndex] = novoNome;

        Console.WriteLine("Passageiro alterado com sucesso.");
    }

    /*
    Método responsável pela função de EXCLUIR os dados de um passageiro. Para realizar a exclusão, o usuário deverá informar o código do passageiro
    */
    static void ExcluirPassageiro()
    {
        Console.WriteLine("=== Excluir Passageiro ===");

        if (numPassageiros == 0)
        {
            Console.WriteLine("Nenhum passageiro cadastrado.");
            return;
        }

        Console.Write("Código do passageiro: ");
        string codigoPassageiro = Console.ReadLine();
        int passageiroIndex = Array.IndexOf(codigosPassageiros, codigoPassageiro);
        if (passageiroIndex == -1)
        {
            Console.WriteLine("Passageiro não encontrado.");
            return;
        }

        string nomePassageiro = nomesPassageiros[passageiroIndex];
        string[,] novaMatrizPassageirosVoos = new string[codigosPassageiros.Length, codigosVoos.Length];
        string[] novoCodigoPassageiros = new string[codigosPassageiros.Length];
        string[] novoNomePassageiros = new string[codigosPassageiros.Length];

        for (int i = 0, k = 0; i < numPassageiros; i++)
        {
            if (i != passageiroIndex)
            {
                novoCodigoPassageiros[k] = codigosPassageiros[i];
                novoNomePassageiros[k] = nomesPassageiros[i];
                for (int j = 0; j < numVoos; j++)
                {
                    novaMatrizPassageirosVoos[k, j] = passageirosVoos[i, j];
                }
                k++;
            }
        }

        passageirosVoos = novaMatrizPassageirosVoos;
        codigosPassageiros = novoCodigoPassageiros;
        nomesPassageiros = novoNomePassageiros;
        numPassageiros--;

        Console.WriteLine($"Passageiro {nomePassageiro} excluído com sucesso.");
    }

    /*
    Método responsável pela função de alterar os dados de um VOO. Para realizar a alteração, o usuário deverá informar o código do VOO
    Este método altera apenas a DISTÂNCIA do VOO. Caso o usuário queira alterar outros dados, ele deverá utilizar o método "ExcluirVoo"
    e em seguida, o método "CadastrarVoos".
    */
    static void AlterarVoo()
    {
        Console.WriteLine("=== Alterar Voo ===");

        if (numVoos == 0)
        {
            Console.WriteLine("Nenhum Voo cadastrado.");
            return;
        }

        Console.Write("Código do Voo: ");
        string codigoVoo = Console.ReadLine();
        int vooIndex = Array.IndexOf(codigosVoos, codigoVoo);
        if (vooIndex == -1)
        {
            Console.WriteLine("Voo não encontrado.");
            return;
        }

        Console.Write("Nova distância do Voo (em km): ");
        int novaDistancia = int.Parse(Console.ReadLine());

        distanciasVoos[vooIndex] = novaDistancia;

        Console.WriteLine("Voo alterado com sucesso.");
    }

    /*
    Método responsável pela função de EXCLUIR os dados de um VOO. Para realizar a exclusão, o usuário deverá informar o código do VOO
    */
    static void ExcluirVoo()
    {
        Console.WriteLine("=== Excluir Voo ===");

        if (numVoos == 0)
        {
            Console.WriteLine("Nenhum Voo cadastrado.");
            return;
        }

        Console.Write("Código do Voo: ");
        string codigoVoo = Console.ReadLine();
        int vooIndex = Array.IndexOf(codigosVoos, codigoVoo);
        if (vooIndex == -1)
        {
            Console.WriteLine("Voo não encontrado.");
            return;
        }

        string[,] novaMatrizPassageirosVoos = new string[codigosPassageiros.Length, codigosVoos.Length];
        string[] novoCodigoVoos = new string[codigosVoos.Length];
        int[] novaDistanciasVoos = new int[distanciasVoos.Length];
        int[] novosAssentosDisponiveisVoos = new int[assentosDisponiveisVoos.Length];

        for (int i = 0, k = 0; i < numVoos; i++)
        {
            if (i != vooIndex)
            {
                novoCodigoVoos[k] = codigosVoos[i];
                novaDistanciasVoos[k] = distanciasVoos[i];
                novosAssentosDisponiveisVoos[k] = assentosDisponiveisVoos[i];
                for (int j = 0; j < numPassageiros; j++)
                {
                    novaMatrizPassageirosVoos[j, k] = passageirosVoos[j, i];
                }
                k++;
            }
        }

        passageirosVoos = novaMatrizPassageirosVoos;
        codigosVoos = novoCodigoVoos;
        distanciasVoos = novaDistanciasVoos;
        assentosDisponiveisVoos = novosAssentosDisponiveisVoos;
        numVoos--;

        Console.WriteLine($"Voo {codigoVoo} excluído com sucesso.");
    }

    /*
    Método responsável pela função de CONTAR o número de passageiros. Esse método percorre todo o array "passageirosVoos" e faz a soma
    na variável "passageiros". Após fazer a contagem, ele retorna o valor da variável "passageiros"
    */
    static int ContarPassageiros(int vooIndex)
    {
        int passageiros = 0;
        for (int i = 0; i < numPassageiros; i++)
        {
            if (passageirosVoos[i, vooIndex] != null)
            {
                passageiros++;
            }
        }
        return passageiros;
    }

    /*
    Método responsável pela função de SOMAR o número de assentos DESOCUPADOS de todos os voos cadastrados no sistema. Esse método
    foi criado para implementar o método "OcupacaoMediaVoos".
    */
    static int SomarAssentos(int assentosIndex) {
        int qtdAssentos = 0;
        
        for (int i = 0; i < assentosDisponiveisVoos[i]; i++) 
        {
            if (assentosDisponiveisVoos[i] != 0) 
            {
            qtdAssentos += assentosDisponiveisVoos[i];
            }
        }
        return qtdAssentos;
    }

}
