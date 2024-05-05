using System;

namespace repeticaofor
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            // Crie um algoritmo para exibir os números de 1 a 10 em ordem crescente.

            for(int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
            */

            /*
            // Crie um algoritmo para exibir os números de 1 a 10 em ordem decrescente.
            for (int i = 10; i >= 1; i--)
            {
                Console.WriteLine(i);
            }
            */

            /*
            // Crie um algoritmo para exibir a tabuada do 7
            for (int i = 1; i <= 9; i++)
            {
                int multiplicacao = 7 * i;

                Console.WriteLine("7 x {0} = {1}", i, multiplicacao);
            }
            */


            /*
            // Crie um algoritmo onde o usuário vai informar um número inteiro e o
            // sistema vai imprimir a tabuada desse numero

            Console.WriteLine("Informe o número da tabuada que você quer ver:");
            int numero = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 9; i++)
            {
                int multiplicacao = numero * i;
                Console.WriteLine("{0} x {1} = {2}", numero, i, multiplicacao);
            }
            */

            /*
            // Construa um algoritmo onde o usuário vai informar um número entre
            // 1 e 100, e o sistema deve mostrar todos os números sequenciais de
            // 0 até o número informado.
            Console.WriteLine("Informe um número entre 0 e 100:");
            int numero = int.Parse(Console.ReadLine());

            for (int i = 0; i <= numero; i++)
            {
                Console.WriteLine(i);
            }
            */

            /*
            // Construa um algoritmo onde o usuário vai informar o número final e 
            // o multiplicador e o sistema deve mostrar de 0 até o número final e
            // somando o multiplicador
            Console.WriteLine("Informe o multiplicador:");
            int multiplicador = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o número final");
            int numeroFinal = int.Parse(Console.ReadLine());

            for (int i = 0; i <= numeroFinal; i = i + multiplicador)
            {
                Console.WriteLine(i);
            }
            */

        }
    }
}