//Principal
using System;
/*classe principal, com chamada das outras classes(execícios), por meio do switch para as opções selecionadas. 
Repetição while para rodar o programa*/
public class Lista04{
    public static void Main()
    {
        while (true)
        {
            int escolha;

            Console.WriteLine("Informe:");
            Console.WriteLine("1) Para executar o exercício 01.");
            Console.WriteLine("2) Para executar o exercício 02.");
            Console.WriteLine("3) Para executar o exercício 03.");
            Console.WriteLine("4) Para executar o exercício 04.");
            Console.WriteLine("5) Para executar o exercício 05.");
            Console.WriteLine("6) Para executar o exercício 06.");
            Console.WriteLine("7) Para executar o exercício 07.");
            Console.WriteLine("8) Para executar o exercício 08.");
            Console.WriteLine("9) Para executar o exercício 09.");
            Console.WriteLine("10) Para executar o exercício 10.");
            
            escolha = int.Parse(Console.ReadLine());

            switch (escolha)
            {
                case 1:
                    Exercicio01 exercicio01 = new Exercicio01();
                    Exercicio01.Rodar();
                    break;
                case 2:
                    Exercicio02 exercicio02 = new Exercicio02();
                    Exercicio02.Rodar();
                    break;
                case 3:
                    Exercicio03 exercicio03 = new Exercicio03();
                    Exercicio03.Rodar();
                    break;
                case 4:
                    Exercicio04 exercicio04 = new Exercicio04();
                    Exercicio04.Rodar();
                    break;
                case 5:
                    Exercicio05 exercicio05 = new Exercicio05();
                    Exercicio05.Rodar();
                    break;
                case 6:
                    Exercicio06 exercicio06 = new Exercicio06();
                    Exercicio06.Rodar();
                    break;
                case 7:
                    Exercicio07 exercicio07 = new Exercicio07();
                    Exercicio07.Rodar();
                    break;
                case 8:
                    Exercicio08 exercicio08 = new Exercicio08();
                    Exercicio08.Rodar();
                    break;
                case 9:
                    Exercicio09 exercicio09 = new Exercicio09();
                    Exercicio09.Rodar();
                    break;
                case 10:
                    Exercicio10 exercicio10 = new Exercicio10();
                    Exercicio10.Rodar();
                    break;
                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }
            Console.ReadKey();
            Console.Clear();
        }
        
    }
}