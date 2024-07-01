using System;

class Program {
    public static void Main() {
        //hipotenusa=h²=a²+b²=raiz quadrada de a²+b²
        double a, b, hipotenusa;
        Console.Write("Digite o valor do cateto a: ");
        a = double.Parse(Console.ReadLine());
        Console.Write("Digite o valor do contato b: ");
        b = double.Parse(Console.ReadLine());
        hipotenusa = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
        Console.WriteLine("O valor da hiponetusa é: {0: 0.00}",hipotenusa);
   }
}