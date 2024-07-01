using System;

class Exercicio03{
    public static void Rodar(){ //programa chamado pelo MAIN(Pragram.cs)

        Console.WriteLine("Digite uma frase para codificarmos:");
        
        string frase = Console.ReadLine();

        string fraseCesar = CodigoCesar(frase, 3); //nova string que receberá o valor da função 
                                                    //que está sendo chamada com os parâmetros solicitados
        Console.WriteLine("E a frase codificada é: " + fraseCesar);//saída de dados
    }

    static string CodigoCesar(string frase, int posicao) //função que faz a criptografia do Código de César
    {
        char[] letras = frase.ToUpper().ToCharArray();

        for (int i = 0; i < letras.Length; i++) //repetição para ver todos os caracteres
        {
            char caracter = letras[i];

            // Verifica se é uma letra do alfabeto
            if (char.IsLetter(caracter))
            {
                caracter = (char)(caracter + posicao);

                // Se passar de 'Z', volta para 'A'
                if (caracter > 'Z')
                {
                    caracter = (char)(caracter - 26);
                }

                letras[i] = caracter;
            }
        }

        return new string(letras);
    }
}


