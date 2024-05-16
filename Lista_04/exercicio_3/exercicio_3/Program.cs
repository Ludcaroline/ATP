using System;
    class Program
    {   //procedimento que recebe os 3 valores 
        static void parametro()
        {
        int v1, v2, v3, a, b, c, resultado;
        v1 = int.Parse(Console.ReadLine());
        v2 = int.Parse(Console.ReadLine());
        v3 = int.Parse(Console.ReadLine());
        //condição para colocar em ordem crescente       
        if (v1 > v2)
        {
            a = v1;
            v1 = v2;   //v1 fica sendo o menor número
            v2 = a;

        }
        if (v2 > v3)
        {
            b = v2;
            v2 = v3; //v3 fica sendo o maior número
            v3 = b;
        }
        if (v1 > v2)
        {
            c = v1;
            v1 = v2; //v2 fica sendo o número do meio 
            v2 = c;
        }
        Console.WriteLine($"A ordem crescente desse conjunto é: {v1}, {v2} e {v3}");
    }
    static void Main(string[] args)
        { //conjunto total de valores (N)
            Console.WriteLine("Digite um valor para o tatal de conjuntos: ");
            int n = int.Parse(Console.ReadLine());
            //repetição para chamar o procedimento para cada conjunto
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Digite 3 valores inteiros: ");
                parametro();
            }         
        }
    }

