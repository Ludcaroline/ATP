using System;
using System.IO;

class Exercicio08{
    public static void Rodar(){ //programa chamado pelo MAIN(Pragram.cs)
         // Solicita a quantidade de veículos e o valor do aluguel ao usuário
        Console.Write("Digite a quantidade de veículos: ");
        int quantidadeVeiculos = int.Parse(Console.ReadLine());

        Console.Write("Digite o valor cobrado por cada aluguel: ");
        double valorAluguel = double.Parse(Console.ReadLine());

        // Calcula o faturamento mensal
        double faturamentoMensal = (quantidadeVeiculos * valorAluguel) / 3;
        
        // Calcula o faturamento anual
        double faturamentoAnual = faturamentoMensal * 12;

        // Calcula o valor ganho com multas no mês
        double valorMultaMensal = (faturamentoMensal / 10) * 0.2;

        // Calcula o valor gasto com manutenção anual
        double valorManutencaoAnual = (quantidadeVeiculos * 0.02) * 600;

        // Exibe os resultados na tela
        Console.WriteLine($"Faturamento mensal: {faturamentoMensal:C}");
        Console.WriteLine($"Faturamento anual: {faturamentoAnual:C}");
        Console.WriteLine($"Valor ganho com multas no mês: {valorMultaMensal:C}");
        Console.WriteLine($"Valor gasto com manutenção anual: {valorManutencaoAnual:C}");

        // Grava os resultados no arquivo resultado.txt
        string arquivo = @"C:\Users\ludmi\Documents\Faculdade\ATP\Lista_06\Arquivos\resultado.txt";
        try
        {
            using (StreamWriter sw = new StreamWriter(arquivo))
            {
                sw.WriteLine($"Faturamento mensal: {faturamentoMensal:C}");
                sw.WriteLine($"Faturamento anual: {faturamentoAnual:C}");
                sw.WriteLine($"Valor ganho com multas no mês: {valorMultaMensal:C}");
                sw.WriteLine($"Valor gasto com manutenção anual: {valorManutencaoAnual:C}");
            }
            Console.WriteLine($"Os resultados foram salvos no arquivo: {arquivo}");
        }
        catch (Exception e)
        {
            Console.WriteLine($"Ocorreu um erro ao salvar os resultados no arquivo: {e.Message}");
        }
    }
}
