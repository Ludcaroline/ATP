using System;
public class lista05{
    public static void Main(){
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

            }
        }
        
    }

}