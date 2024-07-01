using System;
using System.IO;

class Exercicio04 {
    public static void Rodar(){ //programa chamado pelo MAIN(Pragram.cs)
        // variável que contém o caminho do arquivo
       string arquivo = @"C:\Users\ludmi\Documents\Evolucao.txt";
        
        try {
            // Utiliza StreamReader para ler o arquivo
            using (StreamReader sr = new StreamReader(arquivo)) {
                string content = sr.ReadToEnd(); //ler o arquiv até o final

                // Conta a quantidade de caracteres 'a' (maiúsculo e minúsculo)
                int caracteres = 0;
                foreach (char c in content) {
                    if (c == 'a' || c == 'A') {
                        caracteres++;
                    }
                }

                // Imprime a quantidade de caracteres 'a'
                Console.WriteLine("Quantidade de caracteres 'a': " + caracteres);
            }
        } catch (Exception e) { //condição se der erro
            Console.WriteLine("Ocorreu um erro ao ler o arquivo: " + e.Message);
        }
    }
}