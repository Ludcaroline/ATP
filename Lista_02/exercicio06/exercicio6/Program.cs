using System;

class Program
{
    public static void Main()
    {
        /*Um hotel com 75 apartamentos deseja fazer uma promoção especial de final de semana, 
concedendo um desconto de 25% na diária. Com isso, espera aumentar sua taxa de 
ocupação de 50% para 80%. Sendo dado o valor normal da diária, calcular e imprimir: 
a) O valor da diária promocional; 
b) O valor total arrecadado com 80% de ocupação e diária promocional; 
c) O valor total arrecadado com 50% de ocupação e diária normal;
d) A diferença entre esses dois valores.*/

        //Declaração das variáveis e entrada de dados
        double vd, vd_desc, va80o, va50o, diferenca;
        Console.Write("Digite o valor normal da diária: ");
        vd = double.Parse(Console.ReadLine());

        //processamento
        //letra a
        vd_desc = vd * 0.75;
        Console.WriteLine("O valor da diária com o desconto é de R${0:0.00}", vd_desc);
        //letra b
        va80o = vd_desc * (75 * 0.8); 
        Console.WriteLine("O valor arrecadado com 80% de ocupação com a promoção é de R${0:0.00}", va80o);
        //letra c
        va50o = vd * (75 * 0.5);
        Console.WriteLine("O valor arrecado com 50% de ocupação e sem o desconto é de R${0:0.00}", va50o);
        //letra d
        diferenca = va80o - va50o;
        Console.WriteLine("A diferença entre esse dois valores é de R${0:0.00}", diferenca);
    }
}
