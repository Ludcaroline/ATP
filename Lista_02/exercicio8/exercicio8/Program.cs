using System;
class Program
{
    public static void Main()
    {
        /*Construa um programa que lê uma opção conforme abaixo(usar estrutura SWITCH) e o
salário atual do funcionário, calcula e exibe o novo salário:
 A = aumento de 8 % no salário;
        B = aumento de 11 % no salário;
        C = aumento fixo no salário
       (de R$ 350, 00 se o salário atual for até R$ 1000 e de R$ 200, 00 se o salário atual for
       maior que R$ 1000).*/

        //declaração de variável e entrada de dado
        string opcao;
        double salario, novoSalario;

        Console.WriteLine("Digite uma opção:");
        Console.WriteLine("A) Aumento de 8% no salário:");
        Console.WriteLine("B) Aumento de 11% no salário:");
        Console.WriteLine("C) Aumento fixo no salário:");
        opcao = Console.ReadLine();
        
        //condição para saber o novo salário e impressão dos dados
        switch (opcao)
        {
            case "a":
                Console.Write("Digite o valor do seu salário atual: ");
                salario = double.Parse(Console.ReadLine());
                novoSalario = salario + (salario * 0.08);
                Console.WriteLine("O novo salário será de R${0:0.00}", novoSalario);
                break;
            case "b":
                Console.Write("Digite o valor do seu salário atual: ");
                salario = double.Parse(Console.ReadLine());
                novoSalario = salario + (salario * 0.11);
                Console.WriteLine("O novo salário será de R${0:0.00}", novoSalario);
                break;
            case "c":
                Console.Write("Digite o valor do seu salário atual: ");
                salario = double.Parse(Console.ReadLine());
                if (salario <= 1000)
                {
                    novoSalario = salario + 350;
                    Console.WriteLine("O novo salário será de R${0:0.00}", novoSalario);
                }
                else
                {
                    novoSalario = salario + 200;
                    Console.WriteLine("O novo salário será de R${0:0.00}", novoSalario);
                }
                break;
            default:
                Console.WriteLine("Opção inválida");
                break;
        }

    }
}