//exercicio06
using System;
public class Exercicio06
{
    //método utilizado para realizar a condição do número (+ou-); 
    public static bool Valor (double x)
    {
        if (x > 0)
        {
           Console.WriteLine("Esse número é positivo.");
            return true;
        }
        else
        {
            Console.WriteLine("Esse número é negativo.");
            return false;

        }
    }
    //método que é chamado pela classe principal
    //condição for para rodar o número n escolhido e onde chama o método "valor"
    public static void Rodar()
    {
        int n;
        Console.WriteLine("Digite um número.");
        n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Agora, digite um valor inteiro: ");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine(Valor (x));
        }        
    }
}
