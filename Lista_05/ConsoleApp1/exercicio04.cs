/*Faça um procedimento que preencha 2 vetores X e Y com 10 elementos cada um (ocupando
as posições de 0 a 9 em cada vetor). Faça um outro procedimento que receba dois vetores
preenchidos e gera um novo vetor com os elementos desses 2 vetores intercalados de tal
forma que nas posições ímpares do novo vetor estejam os elementos do primeiro vetor e nas
posições pares, os elementos do segundo vetor recebido por parâmetro. Faça um
procedimento que receba e exiba o conteúdo de um vetor. Faça um programa que faça as
devidas declarações e acione os módulos para exemplificar o seu uso.*/
using System;
class Exercicio04{
    public static void Rodar(){ //procedimento principal chamado pelo Main
    //declaração e instaciamento dos vetores com 10 posições, cada um
        int [] x = new int[10];
        int [] y = new int [10];
        PreencherVetor(ref x, ref y); // chamar procedimento 
        
        //chamar procedimentos que faz a impressão dos dados de cada vetor
        Console.WriteLine("  Os valores do vetor x são:"  );
        ImprimirVetor(x); 
        Console.WriteLine("------------------------------");

        Console.WriteLine("  Os valores do vetor y são:"  );
        ImprimirVetor(y);
        Console.WriteLine("------------------------------");

        int [] z = new int [20]; //novo vetor com 20 posições
        MixVetores(ref x, ref y, ref z);

        Console.WriteLine(" Valores dos vetores x e y intercalados:" );
        ImprimirVetor(z);
        Console.WriteLine("-----------------------------------------");
    }

    //procedimento que preenche os vetores x e y de forma aleatória com o Random
    public static void PreencherVetor( ref int [] x, ref int [] y){
        Random r = new Random();
        for(int i = 0; i < x.Length; i++){
            x[i] = r.Next(1, 101);
            y[i] = r.Next(1, 101);
        }
    }

    //procedimento que preenche o vetor z, intercalando os elementos de x e y
    public static void MixVetores(ref int [] x, ref int [] y, ref int [] z){        
         for(int i = 0; i<x.Length; i++){
            z[i * 2] = x[i];
            }
         for(int i = 0; i<y.Length; i++){
            z[i * 2 + 1] = y[i];
            }         
    }

    //procedimento que imprime os valores de um vetor solicitado
    public static void ImprimirVetor( int [] vetor){
        for(int i = 0; i < vetor.Length; i++){
            Console.WriteLine($"          {i + 1}: {vetor[i]}     ");
        }


    }
}