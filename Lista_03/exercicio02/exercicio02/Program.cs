using System;
class Program
{
    public static void Main()
    {
        int x, pos = 0, neg = 0, zero = 0, total = 0;
        double percpos, percneg, perczer;
        string resp;

        Console.WriteLine("Digite o valor de um número inteiro: ");

        do //comando para repetição
        {
            x = int.Parse(Console.ReadLine());
            if (x > 0) //se x for maior que 0, realiza esse comando
            {
                pos++;
            }
            else if (x < 0) //se não, se x for menor que 0, realizar esse comando
            {
                neg++;
                
            }
            else //se não for nenhuma das opções acima, realizar esse comenado
            {
                zero++;
            }
            total++;       
            Console.Write("Deseja continuar? (sim/não) ");
            resp = Console.ReadLine();

        } while (resp == "sim" || resp == "SIM"); //para parar o looping

        //calcular as porcentagens     
        percpos = (double)pos/total*100;
        percneg = (double)neg/total*100;
        perczer = (double)zero/total*100;
        //impressão do resultado
        Console.WriteLine($"O número de valores positivos, negativos e zeros, foram:{pos}, {neg} e {zero}, respectivamente.");
        Console.WriteLine($"O percentuais são: {percpos:0.0}% positivo, {percneg:0.0}% negativo e {perczer:0.0}% de zero.");
    }
}