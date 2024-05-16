using System;
class Program
{
    public static void Main()
    {
        double precoCompra, precoVenda;
        int mercadoriasLucroMenor10 = 0, mercadoriasLucroEntre10E20 = 0, mercadoriasLucroMaior20 = 0;
        double totalCompra = 0, totalVenda = 0, lucroTotal = 0;

        Console.WriteLine("Digite o preço de compra (ou 0 para encerrar):");
        precoCompra = double.Parse(Console.ReadLine());

        while (precoCompra != 0)
        {
            Console.WriteLine("Digite o preço de venda:");
            precoVenda = double.Parse(Console.ReadLine());

            double lucro = precoVenda - precoCompra;
            double percentualLucro = (lucro / precoCompra) * 100;

            totalCompra += precoCompra;
            totalVenda += precoVenda;
            lucroTotal += lucro;

            if (percentualLucro < 10)
                mercadoriasLucroMenor10++;
            else if (percentualLucro >= 10 && percentualLucro <= 20)
                mercadoriasLucroEntre10E20++;
            else
                mercadoriasLucroMaior20++;

            Console.WriteLine("Digite o preço de compra (ou 0 para encerrar):");
            precoCompra = double.Parse(Console.ReadLine());
        }

        Console.WriteLine("Quantidade de mercadorias com lucro < 10%: " + mercadoriasLucroMenor10);
        Console.WriteLine("Quantidade de mercadorias com lucro entre 10% e 20%: " + mercadoriasLucroEntre10E20);
        Console.WriteLine("Quantidade de mercadorias com lucro > 20%: " + mercadoriasLucroMaior20);
        Console.WriteLine("Valor total de compra: " + totalCompra);
        Console.WriteLine("Valor total de venda: " + totalVenda);
        Console.WriteLine("Lucro total: " + lucroTotal);

    }
}
