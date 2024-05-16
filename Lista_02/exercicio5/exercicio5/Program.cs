using System;
class Program
{
    public static void Main()
    {
        /*Faça um algoritmo que, segundo uma nota informada pelo usuário, verifique em qual faixa
a mesma se encaixa e imprima para o usuário a mensagem correspondente conforme a
tabela abaixo:   Faixa das notas Mensagem
Nota > 10 Nota inválida
Nota >= 8 e Nota <= 10 Ótimo
Nota >= 7 e Nota< 8 Bom
Nota >= 5 e Nota< 7 Regular
Nota < 5 Insatisfatório
Nota < 0 Nota inválida*/

        //declaração de variáveis e entrada de dados
        Console.Write("Insira o valor da sua nota: ");
        double nota = double.Parse(Console.ReadLine());

        //Condição para verificar a faixa do usuário
        if (nota >10 || nota < 0)
        {
            Console.WriteLine("Nota inválida");
        }
        else if (nota >=8 && nota <= 10)
        {
            Console.WriteLine("Ótima");
        }
        else if (nota >= 7)
        {
            Console.WriteLine("Bom");
        }
        else if (nota >= 5)
        {
            Console.WriteLine("Regular");
        }
        else
        {
            Console.WriteLine("Insatisfatório");
        }
    }

}