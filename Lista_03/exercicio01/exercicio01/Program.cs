using System;
class Program
{
    public static void Main()
    {
        int pos = 0, neg = 0, zero = 0;
        string resp;

        Console.WriteLine("Digite o valor de um número inteiro: ");
        do //comando para repetição
        {            
            int x = int.Parse(Console.ReadLine());
            if (x > 0) //se x for maior que 0, realiza esse comando
            {
                pos++;
            }
            else if (x < 0) //se não, se x for menor que 0, realizar esse comando
            {
                neg++;
            }
            else // se não for nenhuma das opções acima, realizar esse comenado
            {
                zero++;
            }
            Console.WriteLine("Deseja continuar? (sim/não)");
            resp = Console.ReadLine();
        } while (resp == "sim" || resp == "SIM"); //para parar o looping
        
        //impressão do resultado                                         
        Console.WriteLine($"O número de valores positivos, negativos e zeros, foram:{pos}, {neg} e {zero}, respectivamente.");
      
    }
}