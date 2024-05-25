//exercicio08
using System;

public class Exercicio08{
    //função para realizar o cálculo e retornar o valor para o método Rodar
    public static double Calculo(int n){
        double s=0, parametro;
        //repetição para calcular o valor de S
        for(int i=1; i<=n; i++){
            parametro = (Math.Pow(n,2)+1)/n+3;
            s += parametro;
        }
        
        return s;

    }
    //procedimento que é chamado na classe principal
    public static void Rodar(){
        //método para a entrada do dado N 
        Console.WriteLine("Digeite um valor inteiro e positivo");
        int n = int.Parse(Console.ReadLine());
        double resultado = Calculo(n); //chamar a função Calculo
        Console.WriteLine("O valor de S é = " + resultado);

    }

}