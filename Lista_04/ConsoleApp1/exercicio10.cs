//Exercício10
using System;
public class Exercicio10{

    //procedimento que é chamado na classe principal
    public static void Rodar()
    {
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
    public static string Categoria(int idade)
    {
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
