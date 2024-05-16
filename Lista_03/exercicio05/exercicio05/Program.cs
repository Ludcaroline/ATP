/*Escrever um algoritmo que lê um valor N inteiro e positivo e que calcula e escreve o valor 
de E:
E = 1 + 1 / 1! + 1 / 2! + 1 / 3! + .... + 1 / N!*/

using System;
class Program
{
    public static void Main()
    {
        Console.Write("Digite um número inteiro positivo (N): ");
        int n = int.Parse(Console.ReadLine());

        double e = 1.0; // Inicializa com o primeiro termo (1)

        for (int i = 1; i <= n; i++)
        {
            // Calcula o fatorial de i
            double fatorial = 1.0;
            for (int j = 1; j <= i; j++)
            {
                fatorial *= j;
            }

            // Adiciona o próximo termo à soma
            e += 1.0 / fatorial;
        }

        Console.WriteLine($"O valor E de N é aproximadamente: {e:F5}");
    }
}
