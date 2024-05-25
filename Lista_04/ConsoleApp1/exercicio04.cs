//Exercicio04
using System;
public class Exercicio04
{
    //método para realizar a soma e condição dos triângulos
    public static void Comprimentos()
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
    //método para rodar quando for chamado pela classe principal 
    //condição utilizada, DO WHILE, onde é chamada o método comprimento. 
    public static void Rodar()
    {
        string resp;
        Console.WriteLine("Que tal conferir se é um triangulo? ");
        do
        {
            Comprimentos();           
            Console.WriteLine("Deseja continuar?  digite (sim/não)");            
            resp = Console.ReadLine().ToUpper();             
        } while (resp == "SIM");
        Console.WriteLine("Opção inválida");
    }
}
        