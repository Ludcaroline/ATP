/*Faça um programa para preencher uma matriz 4 x 4, em seguida apresentar na tela a soma
dos elementos abaixo da diagonal principal. Mostre na tela os elementos da diagonal
principal também. */
using System;

class Exercicio08 {
    public static void Rodar()
    { 
        int soma = 0;
        int [,] mt = new int [4,4];
        Random r = new Random();
        for(int l = 0; l < mt.GetLength(0); l++)
        {
            for(int c = 0; c < mt.GetLength(1); c++)
            {
                mt[l,c] = r.Next(1,11);
                 Console.Write(mt[l, c] + " ");

                if(l > c){
                    soma += mt[l,c];
                }             
            }
            Console.WriteLine();   
        }
        Console.WriteLine();
        Console.WriteLine($"A soma dos elementos abaixo da diagonal principal é {soma} ");

        Console.Write("Os elementos da diagonal principal são: ");
        Console.ForegroundColor = ConsoleColor.Green;

        for(int l = 0; l < mt.GetLength(0); l++)
        {
            for(int c = 0; c < mt.GetLength(1); c++)
            {
            if(l==c)
                {
                    Console.Write(mt[l,c] + " ");
                }
            }
        }
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.White;
    }
}