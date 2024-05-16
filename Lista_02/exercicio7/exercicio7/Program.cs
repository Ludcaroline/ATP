using System;
class Program
{
    public static void Main()
    {
        //Declaração das variáveis
        double x, y;

        //Entrada de dados
        Console.Write("Digite o valor de de x: ");
        x= double.Parse(Console.ReadLine());

        //condição para descobrir o valor de y
        if (x <= 1)
        {
            y = 1;
        }
        else if (x > 1 && x <= 2)
        {
            y = 2;
        }
        else if (x > 2 && x <= 3)
        {
            y = Math.Pow(x, 2);
        }
        else
        {
            y = Math.Pow(x, 3);
        }
        Console.WriteLine("O valor de y é = " + y);
    }
}