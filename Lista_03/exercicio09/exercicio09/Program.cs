using System;

class Program
{
    public static void Main()
    {
        //declaração de variável
        int l, primeiro = 0, segundo = 1, soma = 0;

        Console.WriteLine("Digite o valor de L:");
        l = int.Parse(Console.ReadLine());

       //estrutura de repetição
        while (primeiro < l)
        {
            //condições
            soma += primeiro;
            int proximo = primeiro + segundo;
            primeiro = segundo;
            segundo = proximo;
        }

        Console.WriteLine("A soma de todos os elementos da sequência de Fibonacci menores que " + l + " é: " + soma);
    }

}