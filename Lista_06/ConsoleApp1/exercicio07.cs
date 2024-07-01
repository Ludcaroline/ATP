using System;
using System.IO;

class Exercicio07{
    public static void Rodar(){ //programa chamado pelo MAIN(Pragram.cs)

        Console.Write("Digite a quantidade de letras que deseja inserir: ");
        int N = int.Parse(Console.ReadLine());

        // Caminho do arquivo onde as letras serão salvas
        string arquivo = @"C:\Users\ludmi\Documents\Faculdade\ATP\Lista_06\Arquivos\.txt";

        try
        {
            // Abre o arquivo e salva a escrita 
            using (StreamWriter sw = new StreamWriter(arquivo))
            {
                for (int i = 0; i < N; i++)  
                {
                    Console.Write($"Digite a letra {i + 1}: "); //repetição para o usuário digitar a quabtidade de letras que solicitou no inicio
                    char letra = char.Parse(Console.ReadLine()); 
                    sw.Write(letra); //salva as letras no arquivo
                }
            }

            Console.WriteLine("Letras salvas com sucesso no arquivo.");
        }
        catch (Exception e)
        {
            Console.WriteLine($"Ocorreu um erro ao salvar as letras no arquivo: {e.Message}");
            return;
        }

        try
        {
            // Abre o arquivo para leitura
            using (StreamReader sr = new StreamReader(arquivo))
            {
                string texto = sr.ReadToEnd(); //lê todo o arquivo

                int vogais = 0;

                // Conta as vogais no conteúdo do arquivo
                foreach (char c in texto)
                {
                    if ("aeiouAEIOU".IndexOf(c) >= 0)
                    {
                        vogais++; //variável para contar quantas vogais tem no texto 
                    }
                }

                // Exibe o conteúdo do arquivo e a quantidade de vogais
                Console.WriteLine($"Conteúdo do arquivo: {texto}");
                Console.WriteLine($"Quantidade de vogais: {vogais}");
            }
        }
        catch (Exception e)
        {
            Console.WriteLine($"Ocorreu um erro ao ler o arquivo: {e.Message}");
        }    
    }
}