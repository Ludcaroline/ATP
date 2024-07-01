using System;

class Program {
  public static void Main() {
    double a, b, perimetro, area, diagonal;
    Console.Write("Digite a base do retangulo: ");
    a=double.Parse(Console.ReadLine());
    Console.Write("Digite a altura do retangulo: ");
    b=double.Parse(Console.ReadLine());
    //perimetro=2*(base+altura)
    perimetro=2*(a+b);
    //area=base*altura
    area=a*b;
    //diagonal=raiz quadrada de a²+b²
    diagonal=Math.Sqrt(Math.Pow(a,2)+Math.Pow(b,2));
    Console.WriteLine("O perímetro do retângulo é igual a: " + perimetro); 
    Console.WriteLine("A area do retângulo é igual a: " + area);
    Console.WriteLine("A diagonal do retângulo é igual a: " + diagonal);
    
  }
}