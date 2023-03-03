using System;

class Program {
  public static void Main (string[] args) {
    
        int nFunc = 0, qtdHorasTrab = 0, vlrHoraTrab = 0, salario = 0;
    
        Console.WriteLine ("Digite o número do funcionário");
        nFunc = int.Parse(Console.ReadLine());
    
        Console.WriteLine ("Digite aquantidade de horas trabahadas");
        qtdHorasTrab=int.Parse(Console.ReadLine());
    
        Console.WriteLine ("Digite o valor da hora de trabalho");
        vlrHoraTrab=int.Parse(Console.ReadLine());
    
        salario=qtdHorasTrab * vlrHoraTrab;
    
        Console.WriteLine("O funcionário " + nFunc + " receberá o salário R$ " + salario);
  }
}