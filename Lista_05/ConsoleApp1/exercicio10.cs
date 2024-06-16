using System;

class Exercicio10
{
    public static void Rodar()
    {
        int [,] mt = new int[10,10]; //matriz declarada com 10 posições (linha e coluna)

        Console.WriteLine("     Matriz Original");
        PreencherMatriz(mt); //chamar procedimento para preencher a matriz
        Console.WriteLine();

        Console.WriteLine("     Matriz com a linha 2 e 8 trocadas");
        TrocarLinha(mt); //chamar procedimento para fazer a troca das linhas na matriz
        Console.WriteLine();

        Console.WriteLine("     Matriz com a coluna 4 e 10 trocadas");
        TrocarColuna(mt); //chamar procedimento para fazer a troca das colunas na matriz
        Console.WriteLine();

        Console.WriteLine("     Matriz com as diagonais trocadas");
        TrocarDiagonais(mt); //chamar procedimento para fazer a troca das diagonais na matriz
        Console.WriteLine();

        Console.WriteLine("     Matriz com a linha 5 e a coluna 10 trocadas");
        TrocarLinhaEColuna(mt); //chamar procedimento para fazer a troca da linha e coluna na matriz
        Console.WriteLine();

    }

    //procedimento para preencher a matrize com elementos aleatórios com o Random 
    public static void PreencherMatriz(int [,] mt)
    {
        Random r = new Random();
        for(int l =0; l < mt.GetLength(0); l++) //repetições para preencher cada posição
        {
            for(int c = 0; c < mt.GetLength(1); c++)
            {
                mt[l,c] = r.Next(1,11);
            }           
        }
        EscreverMatriz(mt);
    }

    public static void TrocarLinha(int[,] mt) //procedimento que faz a troca das linhas
    {
        for(int c = 0; c < mt.GetLength(1); c++) //repetição for, para ler cada elemento
        {
            int reserva = mt[7,c]; //variável que guarda uma linha para a troca 
            mt[7,c] = mt[1,c];
            mt[1,c] = reserva;
        }
        EscreverMatriz(mt); //chamar procedimento para fazer a impressão da nova matriz
    }

    public static void TrocarColuna(int[,] mt) //procedimento que faz a troca das colunas
    {
        for(int l = 0; l < mt.GetLength(0); l++)
        {
            int reserva = mt[l,3]; //variável que guarda uma coluna para a troca
            mt[l,3] = mt[l,9];
            mt[l,9] = reserva; //trocas de linhas
        }
        EscreverMatriz(mt); //chamar procedimento para fazer a impressão da nova matriz
    }

    public static void TrocarDiagonais(int[,] mt) //procedimento que faz a troca das diagonais
    {
        for(int i = 0; i < 10; i++)
        {
            int reserva = mt[i,i];  
            mt[i,i] = mt[i, 10-1-i];         //trocas das diagonais com variável para guardar uma delas
            mt[i,10-1-i] = reserva; 
        }
        EscreverMatriz(mt);   //chamar procedimento para fazer a impressão da nova matriz
    }

    public static void TrocarLinhaEColuna(int[,] mt) //procedimento que faz a troca da linha 5 com a coluna 10
    {
        for(int c = 0; c < mt.GetLength(1); c++)
        {
            int reserva = mt[4,c];
            mt[4,c] = mt[c,9];            //trocas feita com variável para guardar a linha e depois colocar no lugar da coluna
            mt[c,9] = reserva;
        }
        EscreverMatriz(mt);  //chamar procedimento para fazer a impressão da nova matriz
    }

    //procedimento criado para fazer a impressão dos dados de cada matriz que for soslicitada 
    public static void EscreverMatriz(int [,]x)
    {         
        for(int l = 0; l < x.GetLength(0); l++) 
        {
            Console.Write("        ");
            for(int c = 0; c < x.GetLength(1); c++)
            {
                Console.Write(x[l, c] + "   ");
            }
            Console.WriteLine();
        }
    }
}


