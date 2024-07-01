using System;

class Program
{
    public static void Main()
    {
        double a, b, aux;
        Console.Write("Digite o valor de A: ");
        a = int.Parse(Console.ReadLine());
        Console.Write("Digite o valor de B: ");
        b = int.Parse(Console.ReadLine());
        aux = b;
        b = a;
        a = aux;

        Console.WriteLine("O valor de A é: {0} e o valor de B é: {1}.", a, b);

    }
}