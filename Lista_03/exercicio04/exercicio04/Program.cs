using System;

class Program
{
    public static void Main()
    {   
        //declaração para variavéis
        int n, fatorial=1;
        Console.WriteLine("Digite um número inteiro: ");
        n = int.Parse(Console.ReadLine());
        //condição para número +/-
        if (n > 0)
        {
            //estrutura for, para fatorial
            for (int x = n; x >= 1; x--)
            {
                fatorial = fatorial * x;                
            }
            //impressção do resultado
            Console.WriteLine($"O fatorial de {n} é: {fatorial}");
        }
        else
        {
            Console.Write("Número inválido.");             
        }
    }
}

