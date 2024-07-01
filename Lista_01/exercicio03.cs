using System;

class Program
{
    public static void Main()
    {
        //100kw custa 1/7 do salário mínimo 
        double sm, kw, vu, valor, desconto;
        Console.Write("Qual o valor do salário mínimo? ");
        sm = double.Parse(Console.ReadLine());
        Console.Write("Digite o valor do KW: ");
        kw = double.Parse(Console.ReadLine());
        vu = (sm / 7) / 100;
        valor = vu * kw;
        desconto = valor - (valor * 0.1);
        Console.WriteLine("Cada KW custa: R${0:0.00}.", vu);
        Console.WriteLine("O valor a ser pago por essa residência, será: R${0:0.00}", valor);
        Console.WriteLine("O valor a ser pago com o desconto, será: R${0:0.00}", desconto);

    }
}