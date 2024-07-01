using System;

/*classe principal, com chamada das outras classes(execícios), por meio do switch para as opções selecionadas. 
Repetição while para continuar a rodar o programa*/
public class lista06{
    public static void Main(){
        bool parar = false;

        while (!parar)
        {
            Console.WriteLine("_____________________________________________________________________________________________");
            Console.WriteLine();
            Console.WriteLine("Informe:");
            Console.WriteLine("A) Para executar o exercício A.");
            Console.WriteLine("B) Para executar o exercício B.");
            Console.WriteLine("C) Para executar o exercício C");
            Console.WriteLine("D) Para executar o exercício D.");
            Console.WriteLine("E) Para executar o exercício E.");
            Console.WriteLine("F) Para executar o exercício F.");
            Console.WriteLine("G) Para executar o exercício G.");
            Console.WriteLine("H) Para executar o exercício H.");
            Console.WriteLine("I) Para executar o exercício I.");
            Console.WriteLine("J) Para executar o exercício J.");
            Console.WriteLine("K) Para parar o programa.");
            Console.WriteLine();
            string escolha = Console.ReadLine().ToUpper();
            Console.WriteLine();
            
            
            switch (escolha)
            { 
                case "A":
                Exercicio01 exercicio01 = new Exercicio01();
                Exercicio01.Rodar();
                break;
                case "B":
                Exercicio02 exercicio02 = new Exercicio02();
                Exercicio02.Rodar();
                break;
                case "C":
                Exercicio03 exercicio03 = new Exercicio03();
                Exercicio03.Rodar();
                break;
                case "D":
                Exercicio04 exercicio04 = new Exercicio04();
                Exercicio04.Rodar();
                break;
                case "E":
                Exercicio05 exercicio05 = new Exercicio05();
                Exercicio05.Rodar();
                break;
                case "F":
                Exercicio06 exercicio06 = new Exercicio06();
                Exercicio06.Rodar();
                break;
                case "G":
                Exercicio07 exercicio07 = new Exercicio07();
                Exercicio07.Rodar();
                break;
                case "H":
                Exercicio08 exercicio08 = new Exercicio08();
                Exercicio08.Rodar();
                break;
                case "I":
                Exercicio09 exercicio09 = new Exercicio09();
                Exercicio09.Rodar();
                break;
                case "J":
                Exercicio10 exercicio10 = new Exercicio10();
                Exercicio10.Rodar();
                break;
                case "K":
                Console.WriteLine("Até mais!");
                parar = true;
                break;
                default:
                Console.WriteLine("Opção inválida, digite novamente");
                break;            
            }            
        }        
    }
}