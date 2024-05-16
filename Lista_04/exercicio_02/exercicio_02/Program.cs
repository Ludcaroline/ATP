using System;
   class Program
    {
        //procedimento para ler os dados da pesquisa
        static void menu(ref double sal, ref int filhos)
        {            
            Console.WriteLine("Qual o seu salário: ");
            sal = double.Parse(Console.ReadLine());
            Console.WriteLine("Quantos filhos você tem? ");
            filhos = int.Parse(Console.ReadLine());
        }     
        static void Main()
        {   
        double saltotal = 0;
        int populacao = 10;
        //repetição para quantidade N parar o programa
        for (int i=0; i<10; i++)
        {   //chamando o procedimento e somando os valores
            double sal = 0; int filhos=0;
           menu(ref sal, ref filhos);
            saltotal += sal;
            populacao += filhos;
        }
        //calculo da média
        double media = saltotal/populacao;
        Console.WriteLine($"A média da populãção é: {media:0.00}");
        }
    }

