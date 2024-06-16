using System;
class Program
{
    public static void Main ()
    {
        /* Fazer um programa para:
        • Ler um símbolo do teclado;
        • Identificar com a estrutura SWITCH e mostrar as seguintes mensagens, segundo o
        caso:
                o "SINAL DE MENOR"
        o "SINAL DE MAIOR"
        o "SINAL DE IGUAL"
        o "OUTRO SINAL"*/

        //Declaração da variável e entrada de dados
        Console.Write("Digite um símbolo do teclado: ");
        char simbolo = char.Parse(Console.ReadLine());

        //Condição para saber qual foi o símbolo e impressão das mensagens
        switch (simbolo)
        {
            case '<':
                Console.WriteLine("SINAL DE MENOR");
                break;
            case '>':
                Console.WriteLine("SINAL DE MAIOR");
                break;
            case '=':
                Console.WriteLine("SINAL DE IGUAL");
                break;
            default:
                Console.WriteLine("OUTRO SINAL");
                break;              
        }
    }
}