using System;

class Program {
  
    public static void Main() {
        //p * ((1+i)n-1/i//
        // p= apli. mensal, i= taxa, n= meses, va= valor acumado, r= rendimento//
      double p, i, n, r;
      Console.Write("Digite o valor constante, que será aplicado mensalmente: ");
      p = double.Parse(Console.ReadLine());
      Console.Write("Digite o valor da taxa aplicada: ");
      i = double.Parse(Console.ReadLine());
      Console.Write("Digite a quantidade de meses que fará a aplicação: ");
      n = double.Parse(Console.ReadLine());
      r=p*(Math.Pow(1+i,n)-1)/i;
      Console.WriteLine("Valor total é: "+ r);
      
    }
}