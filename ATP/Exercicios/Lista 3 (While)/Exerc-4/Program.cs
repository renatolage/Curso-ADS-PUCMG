// See https://aka.ms/new-console-template for more information
double vlrDivida = 0;
double vlrJuros = 0;
double qtdParcelas = 1;
double vlrParcelas = 0;
double txJuros = 0;
Console.WriteLine("Insira o valor da dívida:");
vlrDivida = double.Parse(Console.ReadLine());
Console.WriteLine("Valor da Dívida " + " " + " Valor do Juros " + " " + " Quantidade de Parcelas " + " " + " Valor da Parcela");
while (qtdParcelas <= 12) {
    double vlrDividaInicial = vlrDivida;
    switch (qtdParcelas) {
        case 1:
            txJuros = 0;
        break;
        case 3:
            txJuros = 0.1;
        break;
        case 6:
            txJuros = 0.15;
        break;
        case 9:
            txJuros = 0.2;
        break;
        case 12:
            txJuros = 0.25;
        break;
    }
    vlrJuros = vlrDivida * txJuros;
    vlrParcelas = (vlrDivida + vlrJuros) / qtdParcelas;
    vlrDividaInicial += vlrJuros;
    Console.WriteLine("  R$" + vlrDividaInicial.ToString("N2") + "          R$" + vlrJuros.ToString("N2") + "                " + qtdParcelas + "                R$" + vlrParcelas.ToString("N2"));
    if (qtdParcelas == 1) {
        qtdParcelas += 2;
    } else {
        qtdParcelas += 3;
    }

    }