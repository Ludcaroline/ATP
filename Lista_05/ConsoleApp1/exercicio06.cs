using System;

class Exercicio06{
    public static void Rodar(){
        //declaração das variaveis e do vetor com 31 poisções
        double media = 0;
        int menorTemp = 40, maiorTemp = 0, soma = 0, dias = 0;
        int [] temperatura = new int [31];

        Console.WriteLine("As temperaturas no mês de outubro, foram:");
        Console.WriteLine();

        //repetição e Random p/ preencher o vetor com elementos aleatórios
        Random r = new Random();
        for(int i = 0; i < temperatura.Length; i++){ 
            temperatura[i] = r.Next(15,41);
            Console.WriteLine($"Dia {i+1}: {temperatura[i]}°C. ");
        }

        foreach(int item in temperatura){ //repetição para ler os elementos dos vetores
            if(item < menorTemp){ //condição para ver qual é a menor temperatura do mês
                menorTemp = item;
            }
            if(item > maiorTemp){ //condição para ver qual é a maior temperatura do mês
                maiorTemp = item;
            }
            soma += item; //soma para calcular o total das temperaturas
        }
         media = soma/31; // calculo da media da temperatura
         
         foreach(int item in temperatura){ // repertição para ler cada item do vetor e                                             
            if(item < media){              //verificar quantos dias a temp. foi menor que a media.
                dias++;
            }
         }

        //impressão dos resultados
        Console.WriteLine();
        Console.WriteLine($"A menor temperatura registrada no mês foi de {menorTemp}°C.");
        Console.WriteLine($"A maior temperatura registrada no mês foi de {maiorTemp}°C.");
        Console.WriteLine($"A temperatura média do mês foi de {media}°C.");
        Console.WriteLine($"Foi registrado, um total de {dias} dias com a temperaruta inferior a temperatura média.");   
        Console.WriteLine();     
    }
}