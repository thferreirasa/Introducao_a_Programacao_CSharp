using System;
using System.Collections.Generic;

struct Funcionario
{
    public int numeroInscricao;
    public string nome;
    public int classe;
    public float salarioHorasNormais;
    public float salarioHorasExtras;
    public float salarioBruto;
    public float deducaoINSS;
    public float salarioLiquido;
}

namespace moduloFolhaPagamento
{
    public class Program
    {
        
        // rodar o programa
        static void Main(string[] args)
            {
                int salarioMinimo = 1412;
                folhaPagamento(salarioMinimo);
            }

        // módulo com o método criado
        static void folhaPagamento(int salarioMinimo)
        {
            // Inserir o número de funcionários
            Console.WriteLine("Qual a quantidade de funcionários?");
            int numeroFuncionarios = int.Parse(Console.ReadLine());

            Funcionario[] vetorFuncionarios = new Funcionario[numeroFuncionarios];

            // Loop - pegar dados principais do funcionario (nome, numero de inscricao, classe) | if calculo do salario
            for (int i = 0; i < numeroFuncionarios; i++)
            {
                // cria novo funcionario no struct Funcionario
                Funcionario novoFuncionario = new Funcionario();

                // numero de inscricao
                Console.WriteLine("Digite o número de inscrição do funcionário:");
                novoFuncionario.numeroInscricao = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o nome do funcionário {0}", i + 1);
                novoFuncionario.nome = Console.ReadLine();
                Console.WriteLine("Digite a quantidade de horas extras:");
                int horasExtras = int.Parse(Console.ReadLine());
                Console.WriteLine("Qual a classe do funcionário? Digite 1 ou 2");
                novoFuncionario.classe = int.Parse(Console.ReadLine());

                if (novoFuncionario.classe == 1)
                {
                    // classe 1 - hora extra - salario bruto - salario salarioLiquido
                    novoFuncionario.salarioHorasNormais = salarioMinimo * 1.3f;
                    float valorHoraNormal = novoFuncionario.salarioHorasNormais / 200;
                    novoFuncionario.salarioHorasExtras = (valorHoraNormal * 1.3f) * horasExtras;
                    novoFuncionario.salarioBruto = novoFuncionario.salarioHorasNormais + novoFuncionario.salarioHorasExtras;
                    novoFuncionario.deducaoINSS = novoFuncionario.salarioBruto * 0.11f;
                    novoFuncionario.salarioLiquido = novoFuncionario.salarioBruto - novoFuncionario.deducaoINSS;                    
                }
                else if (novoFuncionario.classe == 2)
                {
                    novoFuncionario.salarioHorasNormais = salarioMinimo * 1.9f;
                    float valorHoraNormal = novoFuncionario.salarioHorasNormais / 200;
                    novoFuncionario.salarioHorasExtras = (valorHoraNormal * 1.3f) * horasExtras;
                    novoFuncionario.salarioBruto = novoFuncionario.salarioHorasNormais + novoFuncionario.salarioHorasExtras;
                    novoFuncionario.deducaoINSS = novoFuncionario.salarioBruto * 0.11f;
                    novoFuncionario.salarioLiquido = novoFuncionario.salarioBruto - novoFuncionario.deducaoINSS;

                    

                }
                // adiciona dados ao vetor
                vetorFuncionarios[i] = novoFuncionario;
            }

            // imprimir resultado
            foreach (var pessoa in vetorFuncionarios)
            {
                Console.WriteLine("Número de Inscrição = {0}", pessoa.numeroInscricao);
                Console.WriteLine("Nome = {0}", pessoa.nome);
                Console.WriteLine("Salário Horas Normais = R${0}", pessoa.salarioHorasNormais);
                Console.WriteLine("Salário Horas Extras = R${0}", pessoa.salarioHorasExtras);
                Console.WriteLine("Dedução INSS = R${0}", pessoa.deducaoINSS);
                Console.WriteLine("Salário Líquido = R${0}", pessoa.salarioLiquido);
            }
        }
    }
}





