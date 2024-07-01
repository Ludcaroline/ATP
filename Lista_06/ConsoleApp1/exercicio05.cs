using System;
using System.IO;

class Exercicio05 {
    public static void Rodar(){ //programa chamado pelo MAIN(Pragram.cs)
        
        string arquivo = @"C:\Users\ludmi\Documents\Evolucao.txt"; // variável que contém o caminho do arquivo

        try
        {
            int numeroLinhas = 0;

            using (StreamReader sr = new StreamReader(arquivo)) // Abre o arquivo para leitura
            {
                string linha;

                // Lê o arquivo linha por linha
                while ((linha = sr.ReadLine()) != null)
                {
                    // Imprime cada linha na tela
                    Console.WriteLine(linha);

                    // Incrementa o contador de linhas
                    numeroLinhas++;
                }
            }

            // Imprime a quantidade de linhas no arquivo
            Console.WriteLine($"\nQuantidade de linhas no arquivo: {numeroLinhas}");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine($"O arquivo {arquivo} não foi encontrado.");
        }
        catch (Exception e)
        {
            Console.WriteLine($"Ocorreu um erro ao ler o arquivo: {e.Message}");
        }
    }
}