// See https://aka.ms/new-console-template for more information
int codProduto = 0;
double vlrProduto = 0;
double reajuste = 0;
Console.WriteLine("Digite o código do produto :");
codProduto = int.Parse(Console.ReadLine());
Console.WriteLine("Qual o valor do produto?:" );
vlrProduto = float.Parse(Console.ReadLine());
if (vlrProduto <= 100)
{
    reajuste = (vlrProduto * 1.1);
    Console.WriteLine("O valor do produto reajustado " + codProduto + " é de R$" + reajuste);
}
else if (vlrProduto <= 500)
{
    reajuste = (vlrProduto * 1.13);
    Console.WriteLine("O valor do produto reajustado  " + codProduto + " é de R$" + reajuste);
}
else if (vlrProduto <= 800)
{
    reajuste = (vlrProduto * 1.15);
    Console.WriteLine("O valor do produto reajustado " + codProduto + " é de R$" + reajuste);
}
else if (vlrProduto <= 1500)
{
    reajuste = (vlrProduto * 1.08);
    Console.WriteLine("O valor do produto reajustado" + codProduto + " é de R$" + reajuste);
}
else
{
    Console.WriteLine("Valor so salário acima ds faixas de reajuste.");
}
