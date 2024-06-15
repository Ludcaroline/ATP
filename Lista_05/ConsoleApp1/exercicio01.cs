using System;

class Exercicio01{

    public static void Rodar(){
        int P = 0;
        //declarar vetor e fazer o mesmo ser preenchido por sorteio, com o Random
        int [] N = new int[20];
        Random r = new Random(); 
        for(int i =0; i < N.Length; i++){
            N[i] =r.Next(1, 101);}   

        int M = N[0];
        
        // Repetição para encontrar o menor elemento e sua posição
        for (int i = 1; i < N.Length; i++)
        {
            if (N[i] < M)
            {
                M = N[i];
                P = i;
            }
        }
       
        Console.WriteLine("           Os elementos são:         ");
        Console.WriteLine("   =================================");

        //Impressão dos valores do vetor
        for(int i= 0; i<N.Length; i++){
        Console.WriteLine(" - " + N[i]);}

        //impressão da resultado do menor vetor e sua posição
        Console.WriteLine();
        Console.WriteLine($"O menor elemento de N é {M} e sua posição dentro do vetor é:{P}");
        Console.WriteLine();
    }
}
