//Exercício10
using System;
public class Exercicio10{

    //procedimento que é chamado na classe principal
    public static void Rodar(){
        Console.WriteLine("Digite a idade do nadador: ");
        int idade = int.Parse(Console.ReadLine());
        //condição para vericar a categoria do nadador recebendo a entrada de dado idade
        if(idade>=5){
        Console.WriteLine("A categoria do nadador é: " + Categoria(idade) + ".");//chama a função categoria e imprime o resultado
        } else {
            Console.WriteLine("Idade não permitida para competir");
        }

    }
    //função com a condição "if" para verificar a categoria de acordo com a idade do nadador 
    public static string Categoria(int idade){
        string res = "";
        if (idade>4 && idade<8 ) {
            res = "F";
        } else if (idade>=8 && idade<11){
            res = "E";
        } else if (idade>=11 && idade<14){
            res =  "D";
        } else if (idade>=14 && idade<16){
            res = "C";
        } else if (idade >=16 && idade<17){
            res = "B";
        }else if (idade>=18){
            res = "A";
        }
        return res; //retorna o resultado 
   }
}

using System;

class Program 
{
    // Método principal que inicia a execução do programa
    public static void Main()
    {
        // Solicita a idade do nadador
        Console.WriteLine("Digite a idade do nadador: ");
        
        // Lê a entrada do usuário e converte para um número inteiro
        int idade = int.Parse(Console.ReadLine());
        
        // Verifica se a idade é permitida para competir
        if (idade >= 5)
        {
            // Chama a função Categoria e imprime a categoria do nadador
            Console.WriteLine($"A categoria do nadador é:  {Categoria(idade)}.");
        } 
        else 
        {
            // Informa que a idade não é permitida para competir
            Console.WriteLine("Idade não permitida para competir");
        }
    }

    // Função que determina a categoria do nadador com base na idade
    public static string Categoria(int idade)
    {
        string res = "";
        
        // Verifica a faixa etária e define a categoria correspondente
        if (idade > 4 && idade < 8) 
        {
            res = "F";
        } 
        else if (idade >= 8 && idade < 11)
        {
            res = "E";
        } 
        else if (idade >= 11 && idade < 14)
        {
            res = "D";
        } 
        else if (idade >= 14 && idade < 16)
        {
            res = "C";
        } 
        else if (idade >= 16 && idade < 18)
        {
            res = "B";
        }
        else if (idade >= 18)
        {
            res = "A";
        }
        
        // Retorna a categoria determinada
        return res; 
    }
}