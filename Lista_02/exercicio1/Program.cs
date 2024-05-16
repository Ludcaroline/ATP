using System;
class Program
{
    public static void Main()
    {
        //declaração da variável e entrada de dados//
        Console.WriteLine("Digite um número: ");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Digite um outro número: ");
        double b = double.Parse(Console.ReadLine());

        //Condição para saber qual o número é maior e impressão do resultado

        if (a > b)
        {
            Console.WriteLine($"O número {a} é maior.");
        }
        else if (a == b)
        {
            Console.WriteLine("Os números são iguais.");
        }
        else
        {
            Console.WriteLine($"O número {b} é maior.");
        }
       
    }
}