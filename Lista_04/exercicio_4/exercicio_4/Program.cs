using System;
class Program
{
    static void comprimentos()
    {
        double x, y, z;
        Console.WriteLine("Digite 3 valores reais: ");
        x = double.Parse(Console.ReadLine());
        y = double.Parse(Console.ReadLine());
        z = double.Parse(Console.ReadLine());
        if(x+y>z & y+z>y & x + z > y)
        {
            Console.Write("É um triângulo: ");
            if (x == y & y == z & x == z)
            {
                Console.WriteLine("equilátero");
            }
            else if (x == y || y == z || x == z)
            {
                Console.WriteLine("isósceles");
            }
            else if (x!=y & y != z & x != z)
            {
                Console.WriteLine("escaleno");
            }
        }
        else
        {
            Console.WriteLine("Não é possível formar um triângulo com esses valores.");
        }

    }
    static void Main()
    {
        string resp;
        Console.WriteLine("Que tal conferir se é um triangulo? ");
        do
        {
            Console.ForegroundColor = ConsoleColor.White;
            comprimentos();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Deseja continuar?  digite (sim/não)");
            Console.ForegroundColor = ConsoleColor.Blue;
            resp = Console.ReadLine();
        } while (resp == "sim" || resp == "SIM");
    }
}
        
