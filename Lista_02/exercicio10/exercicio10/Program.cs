using System;
class Program
{
    public static void Main()
    { /*Leia a velocidade máxima permitida em uma avenida e a velocidade com que o motorista 
estava dirigindo nela. Se o motorista estiver dentro do limite de velocidade, imprima a 
mensagem “Motorista respeitou a lei”. Se o motorista tiver ultrapassado a velocidade 
máxima permitida, calcule e imprima o valor da multa a ser cobrada, sabendo que os 
valores a serem cobrados são os seguintes:
• 50 reais se o motorista ultrapassar em até 10km/h a velocidade permitida (ex: se a 
velocidade máxima for 50km/h e o motorista estiver a 60km/h ou a 56km/h);
• 100 reais, se o motorista ultrapassar de 11km/h a 30km/h a velocidade permitida;
• 200 reais, se estiver acima de 30km/h da velocidade permitida*/

        //declaração das variáveis
        int velmaxper, velmotor;

        //entrada de dados
        Console.Write("Digite qual a velocidade máxima permitida da avenida: ");    
        velmaxper = int.Parse(Console.ReadLine());
        Console.Write("Digite qual a velocidade com que o motorista passou por ela: ");
        velmotor = int.Parse(Console.ReadLine());

        //processo e condição para saber se o motorista receberá multa ou não 
        if (velmotor < velmaxper)
        {
            Console.WriteLine("Motorista respeitou a lei");
        }
        else if (velmotor >= velmaxper && velmotor <= (velmaxper + 10))
        {
            Console.WriteLine("O motorista receberá uma multa de R$50,00");
        }
        else if (velmotor >= (velmaxper + 11) && velmotor <= (velmaxper + 30))
        {
            Console.WriteLine("O motorista receberá uma multa de R$100,00");
        }
        else
        {
            Console.WriteLine("O motrista receberá uma multa de R$200,00");
        }

    }
}