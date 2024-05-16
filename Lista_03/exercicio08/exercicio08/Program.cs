using System;

class Program
{
    public static void Main()
    {
        //declaração de variável
        int num=0, primElem = 0, segElem = 1;
        Console.Write("Digite um número que seja positivo e maior que zero: ");
        num = int.Parse(Console.ReadLine());

        Console.WriteLine("Os " + num + " primeiros elementos da sequência de Fibonaccisão: ");        
        
        Console.Write(primElem + " " + segElem);
        //estrutura para retição com um valor exato
        for (int i = 2; i < num; i++)
        {
            //comando para somas
            int proxElem = primElem + segElem;
            Console.Write(", " + proxElem);
            primElem = segElem;
            segElem = proxElem;
        }
    }
}