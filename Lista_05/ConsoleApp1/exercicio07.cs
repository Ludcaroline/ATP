using System;

class Exercicio07{
    public static void Rodar() //procedimento principal chamado pelo Main
    {  //declaração das vairáveis e matriz com as posições solicitadas
        int somaL4 = 0, somaC2 = 0, somaDP = 0, somaDS = 0, somaTE = 0; 
        int [,] M = new int [5,5];

        Console.WriteLine("A matriz é: ");

        PreencherMatriz(M); //pocedimento para preencher a matriz
        somaL4 = SomaLinha(M); //função para somar os elementos da linha 4 
        somaC2 = SomaColuna(M); //função para somar os elementos da coluna 2
        somaDP = SomaDiagonalPrincipal(M); //função para somar os elementos da diagonal principal
        somaDS = SomaDiagonalSecundaria(M); //função para somar os elementos da diagona secundária
        somaTE = SomaTodosElementos(M); //função para somar todos os elementos

        //saída dos resultados para o usuário
       Console.WriteLine($"A soma da linha 4 é: {somaL4}");
       Console.WriteLine($"A soma da coluna 2 é: {somaC2}");
       Console.WriteLine($"A soma da diagonal principal é: {somaDP}");
       Console.WriteLine($"A soma da diagonal secundária é: {somaDS}");
       Console.WriteLine($"A soma de todos os elementos é: {somaTE}");        

    }

    //procedimento que preenche a matriz com a quantidade solicitada de elementos 
    public static void PreencherMatriz(int [,] M){
        ////repetição e Random p/ preencher a matriz com elementos aleatórios
        Random r = new Random(); 
        for(int l = 0; l < M.GetLength(0); l++)
        {
            for(int c = 0; c < M.GetLength(1); c++)
            {
                M[l,c] = r.Next(1,6);
                Console.Write(M[l, c] + " "); //imprimir a matriz lado a lado
            }
            Console.WriteLine();
        }     
    }

    //função que faz a soma da linha
     public static int SomaLinha(int [,] m) 
     {
        int soma = 0;
        for(int c = 0; c < m.GetLength(1); c++)  //repetição para somar os elementos da linha 4
        {
            soma += m[4,c];    
        }     
        return soma;
     }

    //função que faz a soma da coluna com a repetição for
     public static int SomaColuna(int [,]m)
     { 
        int soma = 0;
        for(int l = 0; l < m.GetLength(0); l++)
        {
            soma += m[l,2]; //coluna selecionada para a soma
        }
        return soma;
     }

     //função que soma a diagonal principal 
     public static int SomaDiagonalPrincipal(int [,]m)
     {
        int soma = 0;
        //repetição para somar os elementos
        for(int l = 0; l <m.GetLength(0); l++)
        {
            for(int c =0; c < m.GetLength(1); c++){ 
                if(l==c){ //condição para pegar os elementos da diagonal principal,
                    soma += m[l,c]; //pois o número das posisções são iguais
                }
            }
        }
        return soma;
     }

     //função que soma a diagonal secundária com a repetição for
     public static int SomaDiagonalSecundaria(int [,]m)
     {
        int soma = 0, n = m.GetLength(0)-1; //variável para contar um n° a menos na coluna  
        for(int l = 0; l <= n; l++)
        {         
            soma +=  m[l,n-l]; //soma com a posição da diagonal secundária que é (1, n-1)
         }
        return soma;
     }

    //função para somar todos os elementos da matriz
     public static int SomaTodosElementos(int [,]m)
     {
        int soma = 0;
        //repetição for para somar cada elemento da coluna com cada elemento da linha 
        for(int l = 0; l < m.GetLength(0); l++)
        {
            for(int c = 0; c < m.GetLength(1); c++)
            {
                soma += m[l,c];
            }
        }
        return soma;
     }
    
}
