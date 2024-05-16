using System;

class Program
{
    public static void Main()
    {
        /*Faça um algoritmo que leia o ano de nascimento de uma pessoa e calcule sua idade, 
considerando o ano atual. Para verificar se já fez aniversário no ano atual pergunte se a 
pessoa já fez aniversário, sendo que ela pode entrar com a informação "S"(sim) ou "N" 
(não). Com isso, é possível ter maior precisão sobre a idade. Verifique também se a pessoa 
já tem idade para conseguir Carteira de Habilitação (18 anos ou mais) e imprima a 
mensagem referente a esta checagem. Imprima a idade da pessoa na tela*/

        //declaração das variáveis
        int ano_nasc, ano_atual, idade;
        string opcao;

        //entrada de dados e operação da idade
        Console.Write("Digite o ano atual em que estamos: ");
        ano_atual = int.Parse(Console.ReadLine());
        Console.Write("Digite qual o seu ano de nascimento: ");
        ano_nasc = int.Parse(Console.ReadLine());
        idade = ano_atual - ano_nasc;
        Console.WriteLine("Você já fez aniversário esse ano? digite 'S' para sim ou 'N' para não."); 
        opcao = Console.ReadLine();

        //condição para verificar a idade do usuário e saber se pode ter a CNH
        if (opcao == "s")
        {
            Console.WriteLine("Sua idade é: " + idade);
        }
        else if (opcao == "n")
        {
            idade--; 
            Console.WriteLine("Sua idade é: " + idade);
        }
        else
        {
            Console.WriteLine("Opção inválida");
        }
        if (idade >= 18)
        {
            Console.WriteLine("Você tem idade para conseguir a Carteira de Habilitação");
        }
        else
        {
            Console.WriteLine("Você ainda não tem idade para conseguir a Carteira de Habilitação");
        }
         
    }
}