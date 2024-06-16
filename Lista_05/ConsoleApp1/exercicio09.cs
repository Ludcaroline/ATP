using System;

class Exercicio09
{
    public static void Rodar() //procedimento pricipale e que chamado pelo Main
    {
        // declarações das matrizes e instaciadas com a quantidade solicitada       
        int [,] A = new int [4,6];
        int [,] B = new int [4,6];

        PreencherMatriz(A, B); //chamar o procedimento 

        //novas matrizes declaradas para guardar a matriz gerada no acionamento das funfções
        int [,] mtsoma = SomarMatrizes(A, B); 
        int [,] mtdiferenca = DiferencaMatrizes(A, B);

        //impressão dos dados acionando um procedimento para escrever cada uma delas
        Console.WriteLine(" A matriz resultante da soma das matrizes A e B é: ");
        Console.WriteLine();
        EscreverMatriz(mtsoma); //chamar procedimento

        Console.WriteLine();

        Console.WriteLine(" A matriz resultante da diferença das matrizes A e B é: ");
        Console.WriteLine();
        EscreverMatriz(mtdiferenca); //chamar procedimento

    }

    //procedimento para preencher as matrizes com elementos aleatórios com o Random 
    public static void PreencherMatriz(int [,] a, int [,] b)
    {
        Random r = new Random();
        for(int l =0; l < a.GetLength(0); l++)
        {
            for(int c = 0; c < a.GetLength(1); c++)
            {
                a[l,c] = r.Next(1,11);
                b[l,c] = r.Next(1,11);
            }           
        }
    }

    //função para gerar uma nova matriz, sendo a soma das matrizes A E B
    public static int [,] SomarMatrizes(int[,] a, int[,] b)
    {
        int [,] mt = new int [4,6]; 
        for(int l = 0; l < a.GetLength(0); l++) // repetição para ler cada elemento das matrizes
        {
            for(int c = 0; c < a.GetLength(1); c++)
            {
                mt[l,c] = a[l,c] + b[l,c]; //operação para realizar a soma com elemento por elemento de cada matriz
            }
        }
        return mt; //retorna a nova matriz gerada
    }

    //função para gerar uma nova matriz, sendo a diferença das matrizes A E B
    public static int [,] DiferencaMatrizes(int [,] a, int [,] b)
    {
        int [,] mt = new int [4,6];

        for(int l = 0; l < a.GetLength(0); l++)
        {
            for(int c = 0; c < a.GetLength(1); c++)
            {
                mt[l,c] = a[l,c] - b[l,c]; //operação para realizar a soma com elemento por elemento de cada matriz
            }
        }
        return mt;
    }

    //procedimento criado para fazer a impressão dos dados de cada matriz que for soslicitada 
    public static void EscreverMatriz(int [,]x)
    {         
        for(int l = 0; l < x.GetLength(0); l++) 
        {
            Console.Write("        ");
            for(int c = 0; c < x.GetLength(1); c++)
            {
                Console.Write(x[l, c] + " ");
            }
            Console.WriteLine();
        }
    }
}