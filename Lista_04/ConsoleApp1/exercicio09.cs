//Exercicio09
using System;
public class Exercicio09{
    //função que é chamada pelo Rodar. 
    public static double Media(int n){
        double nota, total=0; 
        int alunos= 0;
        //repetição para entrar os dados das notas dos alunos e calcular a média
        for(int i = 0; i<n; i++){
             Console.WriteLine($"Digite as notas do aluno: {i+1} ");
            nota = double.Parse(Console.ReadLine());            
            if(nota >= 6 ){            
            total+=nota;   
            alunos++;       
            }           
        }
        //retonrar o valor para o procedimento
         return total/alunos;            
    }         
    //procedimento que é chamado pela classe principal
    public static void Rodar(){
        double resultado=0;
        Console.Write("Digite o número de alunos que serão avaliados: ");
        int n = int.Parse(Console.ReadLine()); 
        //chamar a função para calcular a média das notas dos alunos aprovados        
        resultado =  Media(n);     
        //condição para imprimir o resultado final
        if(resultado>0)
        {
            Console.WriteLine($"A media da nota dos alunos aprovados é =  {resultado:F2}.");
        } 
        else{
            Console.WriteLine("Não teve alunos aprovados.");
        }
    }
}
