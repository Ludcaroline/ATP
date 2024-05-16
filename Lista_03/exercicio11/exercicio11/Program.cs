using System;
class Program
{
    public static void Main()
    {
        int voto = 0, candidato1 = 0, candidato2 = 0, candidato3 = 0, candidato4 = 0, votosNulos = 0, votosEmBranco = 0;

        do
        {
            Console.WriteLine("Digite o código do candidato (1 a 4), 5 para voto nulo, 6 para voto em branco, ou 0 para encerrar:");
            voto = int.Parse(Console.ReadLine());

            switch (voto)
            {
                case 1:
                    candidato1++;
                    break;
                case 2:
                    candidato2++;
                    break;
                case 3:
                    candidato3++;
                    break;
                case 4:
                    candidato4++;
                    break;
                case 5:
                    votosNulos++;
                    break;
                case 6:
                    votosEmBranco++;
                    break;
                default:
                    Console.WriteLine("Código inválido. Tente novamente.");
                    break;
            }
        } while (voto != 0);

        Console.WriteLine("Total de votos para o Candidato 1: " + candidato1);
        Console.WriteLine("Total de votos para o Candidato 2: " + candidato2);
        Console.WriteLine("Total de votos para o Candidato 3: " + candidato3);
        Console.WriteLine("Total de votos para o Candidato 4: " + candidato4);
        Console.WriteLine("Total de votos nulos: " + votosNulos);
        Console.WriteLine("Total de votos em branco: " + votosEmBranco);
    }
}





                 