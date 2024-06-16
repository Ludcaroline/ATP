using System;

class Exercicio03{
    public static void Rodar(){//procedimento principal 
        double [] x = new double [10];//declaração e instaciamento do vetor

        PreencherVetor(ref x); //chamar procedimento

        double [] negativos = TrocaVetor(x);//novo vetor com os elementos negativos e chamar a função

        Console.WriteLine("    ---------------------------------------");
        Console.WriteLine();

        Console.WriteLine($"    Os valores negativos do vetor são: ");
        ImprimirDados(negativos);//procedimento para imprir os dados na interface
        Console.WriteLine();
       
    }

    //procedimento para preencher o vetor x
    public static void PreencherVetor(ref double [] x){
        for(int i = 0; i < x.Length; i++){
            Console.WriteLine($" Digite o {i + 1}° valor: ");
            x[i] = double.Parse(Console.ReadLine());
        }

    }

    //função que retorna o vetor com os elementos negativos 
    public static double[] TrocaVetor(double [] x){
       int tamanhovetor = 0;
       int valor = 0;
        foreach(double item in x){ //repetição para ler quantos valores negativos tem no vetor, e saber o tamanho do novo vetor negativo
            if(item < 0){
                tamanhovetor++;
            }
        }
        
        double[] negativos = new double[tamanhovetor];//vetor com o n° de posições necessárias

        foreach(double item in x){//repetição para ler os vetores negativos do vetor x e preencher o novo vetor com esses elementos
            if(item < 0){
                negativos[valor++] = item;
            }
        }

        return negativos;

    }

    //procedimento que imprime os elementos negativos do novo vetor
    public static void ImprimirDados(double [] vetor){

        for(int i = 0; i<vetor.Length; i++){
            Console.WriteLine($"        {i + 1}: {vetor[i]}        ");
        }

    }
}