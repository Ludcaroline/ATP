using System;
using System.IO;

class Exercicio06{
    public static void Rodar(){  //programa chamado pelo MAIN(Pragram.cs)
        //declaração das variáveis 
        int n = 0, somaDivisores =0;
        string divisores = string.Empty;

        Console.Write("Digite um número: ");
        n = int.Parse(Console.ReadLine());

        Console.WriteLine($"Os divisores de {n} são: "); 
        for (int i = 1; i <= n; i++) //repetição e condição if para encontrar e imprimir todos os divisores
        {
           if (n % i == 0)
            {
                Console.WriteLine(i);
                divisores += i + " ";
                somaDivisores += i;
            }
        }

        
        string arquivo = @"C:\Users\ludmi\Documents\Faculdade\ATP\Lista_06\Arquivos\somaDivisores.txt"; //variável para salvar o resultado em um arquivo
        try
        {
            using (StreamWriter sw = new StreamWriter(arquivo)) //função para salvar o no arquivo 
            {
                sw.WriteLine($"A soma dos divisores de {n} é: {somaDivisores}");
            }
            Console.WriteLine($"A soma dos divisores foi salva no arquivo: {arquivo}");
        }
        catch (Exception e)
        {
            Console.WriteLine($"Ocorreu um erro ao salvar o arquivo: {e.Message}");
        }
    }
}