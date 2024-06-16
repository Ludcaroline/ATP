using System;
class Program
{
    public static void Main()
    {
        /* Faça um programa para ler os coeficientes de uma equação do primeiro grau (ax + b = 0), 
calcular e escrever a raiz da equação.*/

        //ax + b = 0 => x = -b/a

        //Declaração das variáveis
        double a, b, x, n;

        //entrada de dados 
        Console.WriteLine("Digite o valor de a: ");
        a = double.Parse(Console.ReadLine());
        Console.WriteLine("Digite o valor de b: ");
        b = double.Parse(Console.ReadLine());

          
       //Condição para verificar as raízes da equação e impressão dos valores
       if (a != 0)
        {
            x = -b / a;
            Console.WriteLine("A raiz é: " + x);
       }
        else
        {
            Console.WriteLine("Não tem raiz, não existe divisão por zero.");
        }
               
    }
}