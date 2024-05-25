//exercicio01
using System;

public class Exercicio01{
       public static void Media()
    {
        double n1, n2, n3, media;
        char op;
        
        n1 = double.Parse(Console.ReadLine());
        n2 = double.Parse(Console.ReadLine());
        n3 = double.Parse(Console.ReadLine());
        Console.WriteLine("Escolha a opção 'A' para média aritmética ou 'P' para média ponderada");
        op = char.Parse(Console.ReadLine());
        //condição if para calcular a média escolhida
        if (op == 'A' || op=='a')
        {
            media = n1 + n2 + n3 / 3;
            Console.WriteLine("A média aritmética do aluno é: " + media);
        } else if (op == 'P' || op=='p')
        {
            media = (n1 * 5 + n2 * 3 + n3 * 2) / 10;
            Console.WriteLine("A média ponderada do aluno é: " + media);
        }
        else
        {
            Console.WriteLine("Opção inválida");
        }
    } 
    public static void Rodar()
    {
        Console.WriteLine("Digite o número de alunos: ");
        int n = int.Parse(Console.ReadLine());
        //repetição para chamar a media e lançar as notas dos alunos 
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Digite as 3 notas do aluno {i+1}");
            Media();
        }
    }
}

  