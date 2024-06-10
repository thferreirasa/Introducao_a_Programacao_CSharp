using System;

namespace vetoresMatrizes
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            // QUESTAO 1 - algoritmo para ler um vetor com 8 elementos e imprimir a multiplicacao deles
            int[] questaoUm = { 1, 5, 9, 25, 50, 6, 22, 68 };
            int multiplicacao = 1;

            for (int i = 0; i < questaoUm.Length; i++)
            {
                int valorAnterior = multiplicacao;
                multiplicacao = questaoUm[i] * multiplicacao;
                Console.WriteLine("{0} x {1} = {2}", questaoUm[i], valorAnterior, multiplicacao);
            }
            */

            /*
            // QUESTÃO 2 - algoritmo que leia 2 vetores de 8 elementos cada, e calcula um terceiro vetor com a soma
            int[] vetor2A = { 1, 2, 3, 4, 5, 6, 7, 8, };
            int[] vetor2B = { 8, 7, 2, 6, 10, 11, 4, 9 };

            int[] vetor2C = new int[8];

            for (int i = 0; i < vetor2A.Length; i++)
            {
                vetor2C[i] = vetor2A[i] + vetor2B[i];               
            }

            for (int i = 0; i < vetor2C.Length; i++)
            {
                Console.WriteLine("vetor2C[{0}] = {1}", i, vetor2C[i]);
            }
            */

            /*
            // QUESTAO 3 - ler lista com salarios de funcionarios e imprimir quantos
            // funcionarios ganham acima da media. A empresa possui 50 funcionarios
            int[] questaoTres = new int[50];
                        
            // criar instancia da classe Random
            Random aleatorio = new Random();

            // gerar valores dos salarios
            for (int i = 0; i < questaoTres.Length; i++)
            {
                questaoTres[i] = aleatorio.Next(1000, 6000); // entre 1000 e 5999
            }

            // calcular media
            int soma = 0;

            for (int i = 0; i < questaoTres.Length; i++)
            {
                soma = questaoTres[i] + soma;
            }

            double media = (double)soma / questaoTres.Length;

            Console.WriteLine("A média salarial é de {0}", media);

            // quantos funcionarios ganham acima da media
            int contador = 0;

            for (int i = 0; i < questaoTres.Length; i++)
            {
                if (questaoTres[i] > media)
                {
                    contador++;
                }
            }

            Console.WriteLine("{0} funcionários têm salários acima da média.", contador);
            */

            /* CORRIGIR
            // QUESTAO 4 - leia 2 vetores com 10 elementos, so devem ser aceitos valores em
            // ordem crescente. gere e imprima um terceiro vetor, resultado da intercalacao
            int[] vetor4A = new int[10];
            int[] vetor4B = new int[10];
            int[] vetor4C = new int[10];

            // preencher vetores
            Random aleatorio = new Random();

            for (int i = 0; i < vetor4A.Length; i++)
            {
                vetor4A[i] = aleatorio.Next(1, 50);
                vetor4B[i] = aleatorio.Next(1, 50);
            }

            // selecionar valores
            int condicional = 1;
            int[] crescente4A = new int[10]; // ordem crescente vetor 4A
            int[] crescente4B = new int[10]; // ordem crescente vetor 4B

            for (int i = 0; i < vetor4C.Length; i++)
            {
                if (vetor4A[i] >= condicional)
                {
                    crescente4A[i] = vetor4A[i];
                    condicional = vetor4A[i];
                } else
                {
                    continue;
                }

                if (vetor4B[i] >= condicional)
                {
                    crescente4B[i] = vetor4B[i];
                    condicional = vetor4A[i];
                } else
                {
                    continue;
                }                
            }

            // adicionar valores no vetor 4C e imprimir
            for (int i = 0; i < vetor4C.Length; i += 2)
            {
                vetor4C[i] = vetor4A[i];
                vetor4C[i+1] = vetor4B[i];

                Console.WriteLine("{0}", vetor4C[i]);
                Console.WriteLine("{0}", vetor4C[i+1]);
            }
            */

            // QUESTAO 7 - ler elementos (int) de uma matriz[3,5]. ler um numero inteiro
            // e procurar na matriz, se achar imprimir a linha e a coluna em que está.
            // se nao, imprimir "elemento nao encontrado"
            int[,] matrizSete = new int[3,5];

            // preencher matriz
            Random aleatorio = new Random();

            for (int i = 0; i < matrizSete.GetLength(0); i++ ) // 0 - verifica linhas 
            {
                for (int j = 0; j < matrizSete.GetLength(1); j++) // 1 - verifica colunas
                {
                    matrizSete[i,j] = aleatorio.Next(1, 20);
                }                
            }

            // imprimir a matriz
            for (int i = 0; i < matrizSete.GetLength(0); i++)
            {
                for (int j = 0; j < matrizSete.GetLength(1); j++)
                {
                    Console.Write(matrizSete[i, j] + "\t"); // tabulação após cada elemento
                }
                Console.WriteLine(); // proxima linha
            }

            // valor procurado
            Console.WriteLine("Informe o valor que você quer encontrar:");
            int valorBusca = int.Parse(Console.ReadLine());

            // buscar valor na matriz
            for (int i = 0; i < matrizSete.GetLength(0); i++)
            {
                for (int j = 0; j < matrizSete.GetLength(1); j++)
                {
                    if (matrizSete[i, j] == valorBusca)
                    {
                        Console.WriteLine("O valor informado está na linha {0} e na coluna {1}", i, j);
                        return;
                    } else
                    {
                        Console.WriteLine("Valor não encontrado.");
                    }
                }
            }

            
            


        }
    }
    
}
