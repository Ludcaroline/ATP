using System;
class Program
{
    public static void Main()
    {
        //declaração de variável
        double x = 0, termo = 1, s = 0;

        Console.Write("Digite um número, inteiro e positivo: ");
        x = double.Parse(Console.ReadLine());
        // Caso não seja um número positivo
        if (x < 0)
        {
            Console.WriteLine("Número inválido");
        }
        //estrutura de repetição, quantidade exata
        for (int i = 1; i <= x; i++)
        {
            //comanndos - soma dos termos
            termo = 1.0 / i;
            Console.WriteLine("1/" + i + " = " + termo);
            s += termo;
        }
        Console.WriteLine($"O valor final de S, é: {s:F3}");

    }
}