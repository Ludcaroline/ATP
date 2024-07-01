using System;
class Program
{
    public static void Main()
    {
        int cc, c, d, u, numin, m, c2, d2, u2, mm, mc, md, mu, soma;
        Console.Write("Digite o número da sua conta corrente, últimos 3 dígitos: ");
        cc = int.Parse(Console.ReadLine());
        c = cc/100;
        d = (cc%100)/10;
        u = cc%10;
        numin = u*100+d*10+c+cc;
        m = numin/1000;
        c2 = (numin%1000)/100;
        d2 = (numin%100)/10;
        u2 = numin%10;
        mm = m*0;
        mc = c2*1;
        md = d2*2;
        mu = u2*3;
        soma = mm+mc+md+mu;
        Console.WriteLine("O dígito verificador da sua conta, é o ultimo dígito do número: " + soma);

    }
}