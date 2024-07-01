using System;

class Program {
  public static void Main () {
    
    double x1, x2, y1, y2, d;
    Console.Write("Digite um ponto qualquer no plano cartesiano: ");
    x1= double.Parse(Console.ReadLine());
    y1= double.Parse(Console.ReadLine());
    Console.Write("Digite outro ponto qualquer no plano cartesiano: ");
    x2= double.Parse(Console.ReadLine());
    y2= double.Parse(Console.ReadLine());
    d=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2));
    Console.WriteLine("A distância entre esses dois pontos é: {0:0.00}", d);    
    
  }
}