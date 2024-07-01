using System;

class Exercicio02{
    public static void Rodar(){  //programa chamado pelo MAIN(Pragram.cs)
        //declaração das varíaveis
        string frase = string.Empty, vogais = "AaEeIiOoUu", newFrase = string.Empty;
         

        Console.WriteLine("Digite um frase, sem acento:");
        frase = Console.ReadLine(); //entrada de dados pelo usuário

            foreach(char letra in frase){ //repetição  e condição que verifica quando a  
                if (!vogais.Contains(letra)) //letra não é uma vogal, e a acrescenta na nova variável
                    newFrase += letra;
            }

        Console.WriteLine("A frase sem as vogais, seria: " + newFrase); //impressão da nova frase

    }
}