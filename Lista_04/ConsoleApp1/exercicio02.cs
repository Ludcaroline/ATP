//Exercicio02
using System;
public class Exercicio02
    {
        //procedimento para ler os dados da pesquisa
        public static void Menu(ref double sal)
        {   int filhos;  
            Console.WriteLine("Qual o seu salário: ");
            sal = double.Parse(Console.ReadLine());
            Console.WriteLine("Quantos filhos você tem? ");
            filhos = int.Parse(Console.ReadLine());
        }     
        public static void Rodar()
        {   
        double saltotal = 0;
        int populacao = 0;
        //repetição para quantidade N parar o programa
        for (int i=0; i<5; i++)
        {   //chamando o procedimento e somando os valores
            double sal = 0; 
            Menu(ref sal);
            populacao++;
            saltotal += sal;     
        }
        //calculo da média
        double media = saltotal/populacao;
        Console.WriteLine($"A média de salário da populãção é: {media:0.00}");
        }
    }

