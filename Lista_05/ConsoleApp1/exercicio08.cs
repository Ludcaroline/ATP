/*Faça um programa para preencher uma matriz 4 x 4, em seguida apresentar na tela a soma
dos elementos abaixo da diagonal principal. Mostre na tela os elementos da diagonal
principal também. */
using System;

class Exercicio08 {
    public static void Rodar() //procedimento chamado pela classe principal
    {  //declaração dda variável e da matriz com 4 posições (linhas, colunas)
        int soma = 0;
        int [,] mt = new int [4,4];

        Random r = new Random(); //random para preencher a matriz com elementos aleatórios de 1 até 11

        for(int l = 0; l < mt.GetLength(0); l++) //repetição para preencher cada linha e coluna com outro for dentro
        {     
            for(int c = 0; c < mt.GetLength(1); c++)
            {
                mt[l,c] = r.Next(1,11);          

                if(l > c){ //abaixo da diagonal principal, a posição da linha sempre é maior que a posição da coluna
                    soma += mt[l,c]; //opreção para somar os elementos abaixo da diagonal principal
                }             
            }  
        }
        Console.WriteLine();
        Console.WriteLine($"A soma dos elementos abaixo da diagonal principal é = {soma} ");

        Console.Write("Os elementos da diagonal principal são: ");
        Console.ForegroundColor = ConsoleColor.Green;

        for(int l = 0; l < mt.GetLength(0); l++) //repertição for para selecionar somente os elementos da diagonal principal
        {
            for(int c = 0; c < mt.GetLength(1); c++)
            {
            if(l==c) //condição para selecionar os elementos requisitados acima 
                {
                    Console.Write(mt[l,c] + " "); //saída dos dados na tela
                }
            }
        }
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.White;
    }
}