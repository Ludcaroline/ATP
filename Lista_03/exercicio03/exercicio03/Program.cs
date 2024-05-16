using System;
class Program
{
    public static void Main()
    {
        //declaração das variavéis
        int n=0, divall=0, div3e9=0, div9e5=0, div2e5=0, div2=0, div5=0;
        Console.WriteLine("Digite um número: ");
        //usando for, por ter quantidade exata de repetição 
        for (int x = 0; x<10; x++)           
        {
            //comandos
            n = int.Parse(Console.ReadLine());
            if (n % 9 == 0 && n % 2 == 0 && n % 5 == 0)
            {
                divall++;
            }
            else if (n % 9 == 0 && n % 5 == 0)
            {
                div9e5++;
            }
            else if (n % 2 == 0 && n % 5 == 0)
            {
                div2e5++;
            }
            else if (n % 9 == 0)
            {
                div3e9++;
            }
            else if (n % 2 == 0)
            {
                div2++;
            }
            else if (n%5 == 0)
            {
                div5++;
            }else
            {
                Console.WriteLine("Número não é divisível por nenhum desses valores.");
            }            
        }
        //impressão dos resultados 
        Console.WriteLine("O total de números que são divisíveis por 3 e 9 ao mesmo tempo é: " + (div3e9+divall+div9e5));
        Console.WriteLine("O total de números que são divisíveis por 2 é: " + (div2+divall+div2e5));
        Console.WriteLine("O total de números que são divisíveis por 5 é: " + (div5+divall+div2e5+div9e5));

    }
}