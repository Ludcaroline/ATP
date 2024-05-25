//exercicio07
using System;

public class Exercicio07{

    //método para realizar a condição IF, para saber as notas dos alunos;
    public static void Media(){
        
        double x;
        x = double.Parse(Console.ReadLine());

        if(x <= 39){
            Console.WriteLine("Nota: F");        
        } 
        else if (x > 39 && x < 60) {
            Console.WriteLine("Nota: E");
        }
        else if (x > 60 && x < 70 ){
            Console.WriteLine("Nota: D");
        }
        else if (x > 70 && x < 80 ){
            Console.WriteLine("Nota: C");
        }
        else if (x > 80 && x < 90){
            Console.WriteLine("Nota: B");
        }
        else {
            Console.WriteLine("Nota: A");
        }
    }
    //método chamado na classe principal do progama
    //repetição utilizada foi o for para rodar o número de alunos exatos
    public static void Rodar(){
        Console.WriteLine("Digete o número de alunos: ");
        int n = int.Parse(Console.ReadLine());
        for(int i = 0; i < n; i++){
            Console.WriteLine($"Digite a média final do aluno {i+1}");
            Media(); //chamar o método "Média"
        }     
    }   
}