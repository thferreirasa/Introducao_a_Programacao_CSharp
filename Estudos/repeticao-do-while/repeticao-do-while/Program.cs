using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace dowhile
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            // Crie um algoritmo para somar e exibir os valores que o usuário digitar, porém, quando ele digitar o número
            // zero, o loop deve acabar e mostrar o resultado final da soma.

            int valorInicial = 0;
            int numero = 0;
        
            do
            {                
                Console.WriteLine("Insira um valor:");
                numero = int.Parse(Console.ReadLine());

                int soma = numero + valorInicial;
                Console.WriteLine("O resultado é " + soma);

                valorInicial = soma;
            } while (numero != 0);
            */

            /*
            // Crie um algoritmo que não permite que o usuário informe um valor menor que 100. Se ele informar um valor
            // menor, deve mostrar uma mensagem e solicitar novamente. Se ele informar maior, ele mostra mensagem de sucesso.

            int numero = 100;

            do
            {
                Console.WriteLine("Informe um valor maior que 100:");
                numero = int.Parse(Console.ReadLine());
            } while (numero < 100);

            Console.WriteLine("O número informado é maior que 100!");
            */

            /*
            // Construa um algoritmo para um pequeno game, no qual um jogador entra com um número e o outro jogador deve
            // adivinhar o número informado.
            // As regras são:
            // 1. O algoritmo deve pedir para o jogador desafiante informar um valor numérico;
            // 2. Na sequência o algoritmo deve pedir para o jogador desafiado informar um valor.
            // a) Se o valor informado for igual ao valor do desafiante, o algoritmo deve exibir a mensagem de sucesso
            // b) Se o valor informado for diferente, o sistema deve informar que está incorreto e deve pedir um novo valor

            Console.WriteLine("Jogador Desafiante, escolha um número entre 1 e 9:");
            int desafiante = int.Parse(Console.ReadLine());
            Console.Clear();

            int desafiado = desafiante;

            do
            {         
                Console.WriteLine("Jogador Desafiado, qual sua aposta?");
                desafiado = int.Parse(Console.ReadLine());

            } while (desafiante != desafiado);

            Console.WriteLine("Muito bem! O número era " + desafiante);
            */
        }
    }
}