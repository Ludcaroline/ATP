using System;
class Program
{
    public static void Main()
    {
        //declaração das variavéis 
        int filhos = 0, totalfilhos = 0, totalpessoa = 0, salate100 = 0;
        double sal = 0, totalsal = 0, medsal = 0, percsal = 0, maiosal = 0, medfil = 0;

        //estrutura para repetição 
        while (sal >= 0)
        {
            Console.Write("Qual o valor do seu salário: ");
            sal = double.Parse(Console.ReadLine());
            if (sal > 0) { 
            Console.Write("Quantos filhos você tem: ");
            filhos = int.Parse(Console.ReadLine());

            totalpessoa++;
            totalfilhos += filhos;

            //soma total salário
            totalsal += sal;

            //maior salário
            if (sal > maiosal)
            {
                maiosal = sal;
            }

            if (sal < 100)
            {
                salate100++;
            }
        } else
        {
            Console.WriteLine("Finalizada a leitura de dados");
        }

        }
        //media salário
        medsal = totalsal /totalpessoa;

        //media dos filhos
        medfil = totalfilhos / (double)totalpessoa;

        //percentual de salário até 100,00.
        percsal = (salate100 /(double)totalpessoa) * 100;
        
        //impressão dos resultados
        Console.WriteLine("A média do salário da população é: " + medsal);
        Console.WriteLine("A média do númeo de filho é: " + medfil);
        Console.WriteLine("O maior salário é de: R$" + maiosal);
        Console.WriteLine("O percentual de pessoas com salário até R$100,00 é: " + percsal);
    }
}


  
