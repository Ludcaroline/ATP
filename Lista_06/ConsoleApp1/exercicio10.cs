using System;
using System.IO;

class Exercicio10
{
    public static void Rodar()
    {
        string arquivo = @"C:\Users\ludmi\Documents\Faculdade\ATP\Lista_06\Arquivos\numerosFlutuantes.txt";

        
                double max = double.MinValue;
                double min = double.MaxValue;
                double soma = 0;
                int contador = 0;

                if (File.Exists(arquivo))
                {
                    string[] linhas = File.ReadAllLines(arquivo);

                    foreach (string linha in linhas)
                    {
                        // Verifica se a linha pode ser convertida em número de ponto flutuante
                        if (double.TryParse(linha, out double numero))
                        { 
                            // Atualiza os valores máximo e mínimo
                            if (numero > max)
                            {
                                max = numero;
                            }
                            if (numero < min)
                            {
                            min = numero;
                            }
                                // Atualiza a soma dos números e o contador
                                soma += numero;
                                contador++;
                            } else {
                            Console.WriteLine($"Linha '{linha}' não é um número válido.");
                            }
                    }
                }
                  

                if (contador > 0)
                {
                    // Calcula a média
                    double media = soma / contador;

                // Imprime os resultados na tela
                Console.WriteLine($"Valor máximo: {max}");
                Console.WriteLine($"Valor mínimo: {min}");
                Console.WriteLine($"Média: {media}");
                } else {
                    Console.WriteLine("Nenhum número válido encontrado no arquivo.");
                }

            }
        
    }
