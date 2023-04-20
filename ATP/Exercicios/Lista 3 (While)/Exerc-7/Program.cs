// See https://aka.ms/new-console-template for more information
int idade = 1;
string sexo = "";
string experiencia = "";
int totalCandiFem = 0;
double totalCandMas = 0;
int homensCExpe = 0;
int totalIdadeHomensCExp = 0;
double homensMais45 = 0;
int mulheresMenos21CExp = 0;
int mulherMenosIdadeCExp = 999;

while (idade != 0) {

    Console.WriteLine("Digite a idade do(a) condidato(a): ");
    idade = int.Parse(Console.ReadLine());

    if (idade > 0) {

        Console.WriteLine("Qual o sexo do(a) candidato(a)? (f)eminino ou (m)asculino");
        sexo = Console.ReadLine();
        Console.WriteLine("O(a) candidato(a) tem experiência no serviço? (s)im ou (n)ão");
        experiencia = Console.ReadLine();

        if (sexo == "m") {
            totalCandMas++;
            if (idade > 45) {
                homensMais45++;
            }
            if (experiencia == "s") {
                homensCExpe++;
                totalIdadeHomensCExp += idade;
            }
        } else if (sexo == "f") {
            totalCandiFem++;
            if (experiencia == "s") {
                if (mulherMenosIdadeCExp > idade) {
                    mulherMenosIdadeCExp = idade;
                }
                if (idade < 21) {
                    mulheresMenos21CExp ++;
                }
            }
        }
    }
}
double idadeMediaHomensCExp = 0;
double porcHomensMais45 = 0;
if (homensCExpe > 0) {
    idadeMediaHomensCExp = totalIdadeHomensCExp / homensCExpe;
}
if (homensMais45 > 0) {
    porcHomensMais45 = (homensMais45 / totalCandMas) * 100;
}
Console.WriteLine("Número de candidatos do sexo FEMININO: " + totalCandiFem);
Console.WriteLine("Número de condidatos do sexo MASCULINO: " + totalCandMas);
Console.WriteLine("Idade média de homens com experiência: " + Math.Round(idadeMediaHomensCExp,2));
Console.WriteLine("Porcentagem de homens com mais de 45 anos: " + porcHomensMais45 + "%");
Console.WriteLine("Quantidade de mulheres menores de 21 anos com experiência: " + mulheresMenos21CExp);
Console.WriteLine("Menor idade entre as mulheres com experiência: " + mulherMenosIdadeCExp);