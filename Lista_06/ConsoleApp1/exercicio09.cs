using System;
using System.IO;

class Exercicio09
{
    public static void Rodar()
    {
        bool sair = false;

        while (!sair)
        {
            Console.WriteLine("Escolha uma opção:");
            Console.WriteLine("1. Inserir dados de alunos");
            Console.WriteLine("2. Ler dados de alunos");
            Console.WriteLine("3. Sair");
            Console.Write("Opção: ");
            int opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    InserirDadosAlunos();
                    break;
                case 2:
                    LerDadosAlunos();
                    break;
                case 3:
                    sair = true;
                    break;
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }
        }
    }

    public static void InserirDadosAlunos()
    {
        string arquivo = @"C:\Users\ludmi\Documents\Faculdade\ATP\Lista_06\Arquivos\dados_alunos.txt";

        using (StreamWriter sw = new StreamWriter(arquivo, true))
        {
            bool inserirMais = true;

            while (inserirMais)
            {
                Console.Write("Digite a matrícula do aluno: ");
                string matricula = Console.ReadLine();

                Console.Write("Digite o telefone do aluno: ");
                string telefone = Console.ReadLine();

                sw.WriteLine($"{matricula},{telefone}");

                Console.Write("Deseja inserir mais um aluno? (s/n): ");
                string resposta = Console.ReadLine().ToLower();
                if (resposta != "s")
                {
                    inserirMais = false;
                }
            }
        }

        Console.WriteLine("Dados dos alunos inseridos com sucesso.");
    }

    public static void LerDadosAlunos()
    {
        string arquivo = @"C:\Users\ludmi\Documents\Faculdade\ATP\Lista_06\Arquivos\dados_alunos.txt";

        if (File.Exists(arquivo))
        {
            using (StreamReader sr = new StreamReader(arquivo))
            {
                string linha;
                Console.WriteLine("Dados dos alunos:");

                while ((linha = sr.ReadLine()) != null)
                {
                    string[] dados = linha.Split(',');
                    if (dados.Length == 2)
                    {
                        Console.WriteLine($"Matrícula: {dados[0]}, Telefone: {dados[1]}");
                    }
                    else
                    {
                        Console.WriteLine("Formato inválido na linha: " + linha);
                    }
                }
            }
        }
        else
        {
            Console.WriteLine("O arquivo de dados dos alunos não foi encontrado.");
        }
    }
}

