//Exercicio05
using System;
    public class Exercicio05
    {
        //método chamado no método no Rodar
        //condição while para realizar o cálculo do mdc
        public static double Mdc (int x, int y)
    {   int z;
        while(y!=0)
        {
           z = y;           
           y = x % y;          
           x = z;           
        }
        return (x);
    }
        //Método onde tem a declaração das variáveis e chama o método "Mdc"
       public static void Rodar()
        {
        int x, y;
        Console.WriteLine("Digite dois números para calcularmos o MDC");
        x = int.Parse(Console.ReadLine());
        y = int.Parse(Console.ReadLine());
        Console.WriteLine("A resposta é: " + Mdc(x, y));        
        }
    }

