using System;
class Program
{
    public static void Main()
    {
        int x, soma=0;
        Console.WriteLine("Digite um valor positivo: ");
        x = int.Parse(Console.ReadLine());
        while(x > 0){
            soma += x++;
        }
        Console.WriteLine("Resultado {0}", soma );

    }
    }

