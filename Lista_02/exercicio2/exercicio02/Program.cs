using System;
class Program
{
    public static void Main()
    {
        //declaração das variáveis//
        int x, y, s, r;
        
        //Entrada de dados e soma das variáveis//
        Console.WriteLine("Digite um número: ");
        x = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite um outro número: ");
        y = int.Parse(Console.ReadLine());
        s = x + y;

        //Condição para saber se a soma é maior ou igual a 10 e saída de dados//
        if (s >= 10) 
        {
            r = s + 5;
            Console.WriteLine("O resultado final é: " + r);
        }
        else
        {
            r = s + 7;
            Console.WriteLine("O resultado final é: " + r);
        }
       
    }
}