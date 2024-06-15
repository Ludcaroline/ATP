/*Faça uma função que sorteie 3 números (entre 10 e 50) e retorne em um vetor. Depois crie
um procedimento que leia as tentativas do usuário para acertar um destes números. O
programa só deve parar quando o usuário acertar um número sorteado.*/
using System;

class Exercicio05{
    public static void Rodar(){ //procedimento principal chamado pelo Main
        Console.WriteLine("                     Vamos jogar um jogo? :D"                      );
        Console.WriteLine("==================================================================");
        int [] sorteio = new int [3]; //declaração e instaciamento do vetor com 3 posições
        Sorteio(ref sorteio); //chamar função

        Console.WriteLine();
        Tentativas(sorteio);//chamar procedimento que realiza as tentativas do usuário
    }

    //função que preenche o vetor e sorteia 3 números com o Random
    public static int [] Sorteio(ref int [] vetor){
        Random r = new Random();
        for(int i = 0; i < 3; i++){
            vetor[i]=r.Next(10,51);         
        }
        Console.WriteLine("Os números foram sorteados, agora é a sua vez de tentar adivinhar");
        return vetor; //retorna o valor 
    }

    //procedimento que lê as tentativas do usuário e que tem a condição while para parar o jogo
    public static void Tentativas(int [] sorteio){
        bool acertou = false;
        int n = 0;
        
        while(!acertou){
            Console.Write("             Escolha e digite um número de 10 até 50: "             );
            n = int.Parse(Console.ReadLine());
            foreach(int item in sorteio){ //repetição para ler os números sorteados e comparar com o n° escolhido pelo usuário
                if(n == item){//se for igual a um dos 3 números, encerra o jogo
                    Console.WriteLine("PARABÉNSS, você acertou, já pode jogar na Mega Sena!");
                    acertou = true;
                    break;
                }
                if(!acertou){//se não for igual, volta para a repetição até achar acertar
                    Console.WriteLine("Não foi dessa vez, tente novamente!");
                }
            }
        }
    }
}
