using System;
using System.Runtime.Serialization;

namespace repeticaowhile
{
    class Program
    {
        static void Main(string[]args)
        {
            /*
            // Crie um algoritmo para somar e exibir os valores que o usuário digitar, porém, quando ele digitar o número
            // zero, o loop deve acabar e mostrar o resultado final da soma.

            int soma = 0;

            Console.WriteLine("Digite um valor:");
            int numero = int.Parse(Console.ReadLine());

            while (numero != 0)
            {
                soma = soma + numero;
                Console.WriteLine("O total é " + soma);

                Console.WriteLine("Digite outro valor:");
                numero = int.Parse(Console.ReadLine());
            }
            */

            /*
            // Crie um algoritmo que não permita que o usuário informe um valor menor que 100. Se ele informar um valor
            // menor, deve mostrar uma mensagem e solicitar novamente. Se ele informar maior, ele mostra a mensagem de sucesso.

            int valor = 99;

            while (valor < 100)
            {
                Console.WriteLine("Informe um valor igual ou maior que 100!");

                valor = int.Parse(Console.ReadLine());
            }
                       
            Console.WriteLine("Muito bem! O valor " + valor + " é maior ou igual a 100!");
            */
            
            /*
            // Construa um algoritmo para um pequeno game, no qual um jogador entra com um número e o outro jogador deve
            // adivinhar o número informado.
            // As regras são:
            // 1. O algoritmo deve pedir para o jogador desafiante informar um valor numérico;
            // 2. Na sequência o algoritmo deve pedir para o jogador desafiado informar um valor.
            // a) Se o valor informado for igual ao valor do desafiante, o algoritmo deve exibir a mensagem de sucesso
            // b) Se o valor informado for diferente, o sistema deve informar que está incorreto e deve pedir um novo valor

            Console.WriteLine("Jogador 1, informe seu valor:");
            int jogadorUm = int.Parse(Console.ReadLine());

            Console.Clear(); // limpa a resposta acima do console

            Console.WriteLine("Jogador 2, informe seu valor:");
            int jogadorDois = int.Parse(Console.ReadLine());

            while (jogadorUm != jogadorDois)
            {
                Console.WriteLine("O valor está incorreto!");
                            
                Console.WriteLine("Jogador 2, tente novamente:");
                jogadorDois = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Muito bem! A resposta era " + jogadorUm);
            */
        }
    }
}
