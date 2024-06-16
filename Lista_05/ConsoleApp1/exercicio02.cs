using System;

class Exercicio02{
    public static void Rodar(){ //procedimento principal 
         double [] Notas = new double[10]; //declaração e instaciamento do vetor

        Console.WriteLine("    Calcular a média da sala    ");
        Console.WriteLine("================================");  

        //chamar os procedimentos      
        VetorNotas(ref Notas);
        Media(Notas);
        

    }

    //procedimento para preencher o vetor com as notas dos alunos
    public static void VetorNotas(ref double[] Notas){
        
        for(int i = 0; i < Notas.Length; i++){
            Console.WriteLine($"Digite a nota do aluno {1 + i}");
            Notas[i] = double.Parse(Console.ReadLine());            
       }

    //procedimento para calcular a media da turma e contar quantos alunos ficaram acima da media    
    }
    public static void Media(double [] Notas){
        double soma = 0, media = 0;
        int acimaMedia = 0;
        //repetição para somar todas as notas
        for(int i = 0; i < Notas.Length; i++){
            soma += Notas[i];           
        }
        media = soma/10; //calcular a media 
        //ler as notas no vetor e contar quantos alunos ficaram aimca da media
        foreach (double item in Notas){
            if (item > media){
                acimaMedia++;
            }
        }
        
        //imprimir os resultados
        Console.WriteLine();
        Console.WriteLine($"A média da turma foi: {media:0.00}");
        Console.WriteLine("O número de alunos com a nota acima da média, foi: " + acimaMedia);  
        Console.WriteLine();         
    }
    
}