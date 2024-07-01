using System;

class Exercicio01{
    public static void Rodar(){ //programa chamado pelo MAIN(Pragram.cs)
    
        string frase = string.Empty; //declaração das variáveis
        int N = 0;
        
        Console.WriteLine("Digite uma frase");
        frase = Console.ReadLine(); //esntrada de dados pelo usuário

        foreach ( char e in frase) //leitura de cada caractere dentro da variável frase
        {
            if (e == ' ') { //condição para ver quantos espaços em brancos existem e som 
                N++;
            }
        }
        Console.WriteLine("O número de espaços em branco na frase digitada é: " + N); //saída de dados 

    }

}

