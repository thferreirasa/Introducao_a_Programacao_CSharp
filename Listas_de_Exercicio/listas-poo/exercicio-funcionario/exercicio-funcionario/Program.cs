using System;

namespace funcionario
{
    public class Funcionario
    {
        // atributos
        public string nome;
        public string cpf;
        public string telefone;
        public string endereco;
        public double salario;

        // construtor
        public Funcionario(string nome, string cpf, string telefone, string endereco, double salario)
        {
            this.nome = nome;
            this.cpf = cpf;
            this.telefone = telefone;
            this.endereco = endereco;
            this.salario = salario;
        }

        // destrutor
        ~Funcionario()
        {
            Console.WriteLine("Destrutor Inicializado.");
        }

        // metodos get e set
        public void getNome(string nome) { this.nome = nome; }
        public string setNome() { return this.nome; }
        
        public void getCPF(string cpf) { this.cpf = cpf; }
        public string setCPF() { return this.cpf; }

        public void getTelefone(string telefone) { this.telefone = telefone; }
        public string setTelefone() { return this.telefone; }

        public void getEndereco(string endereco) { this.endereco = endereco; }
        public string setEndereco() { return this.endereco; }

        public void getSalario(double salario) { this.salario = salario; }
        public double setSalario() { return this.salario; }

        // metodo da classe - retornar dados
        public void DadosFuncionario(string nome, string cpf, string telefone, string endereco, double salario)
        {
            this.nome = nome;
            this.cpf = cpf;
            this.telefone = telefone;
            this.endereco = endereco;
            this.salario = salario;

            Console.WriteLine("Nome: {0}", nome);
            Console.WriteLine("CPF: {0}", cpf);            
            Console.WriteLine("Telefone: {0}", telefone);            
            Console.WriteLine("Endereço: {0}", endereco);            
            Console.WriteLine("Salário: {0}", salario);
           
        }

        class Program
        {
            static void Main(string[]args)
            {
                // dados
                Console.WriteLine("Insira o nome do(a) funcionário(a):");
                string nome = Console.ReadLine();
                Console.WriteLine("Insira o CPF: ");
                string cpf = Console.ReadLine();
                Console.WriteLine("Insira o telefone:");
                string telefone = Console.ReadLine();
                Console.WriteLine("Insira o endereço:");
                string endereco = Console.ReadLine();
                Console.WriteLine("Insira o salário:");
                double salario = double.Parse(Console.ReadLine());

                // criar objeto
                Funcionario funcionarioA = new Funcionario(nome, cpf, telefone, endereco, salario);

                // rodar método
                funcionarioA.DadosFuncionario(nome, cpf, telefone, endereco, salario);
            }
        }

    }
}