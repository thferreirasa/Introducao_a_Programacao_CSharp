using System;

namespace IMC
{
    class Pessoa
    {
        // atributos
        private string nome;
        private int peso;
        private double altura;

        // construtor
        public Pessoa(string nome, int peso, double altura)
        {
            this.nome = nome;
            this.peso = peso;
            this.altura = altura;
        }

        // destrutor
        ~Pessoa()
        {
            Console.WriteLine("Destrutor Inicializado.");
        }

        // métodos get e set
        public int getPeso() { return this.peso; }
        public void setPeso(int peso) { this.peso = peso; }

        public double getAltura() { return this.altura; }
        public void setAltura(double altura) { this.altura = altura; }

        public string getNome() { return this.nome; }
        public void setNome() { this.nome = nome; }

        // método da classe
        public void CalculoIMC()
        {
            // calculo IMC
            double imc = (this.peso / (Math.Pow(this.altura, 2)) * 10000);
            Console.WriteLine("O IMC é de {0}.", imc);

            // avaliacao IMC
            if (imc < 18.5)
            {
                Console.WriteLine("Você está abaixo do peso ideal.");
            }
            else if (imc >= 18.5 && imc < 25)
            {
                Console.WriteLine("Você está no peso ideal.");
            }
            else
            {
                Console.WriteLine("Você está acima do peso ideal.");
            }
        }
       
    }

    class Program
    {
        static void Main(string[]args)
        {
            // dados de entrada
            Console.WriteLine("Qual o seu nome?");
            string nome = Console.ReadLine();
            Console.WriteLine("Qual o seu peso?");
            int peso = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual a sua altura?");
            double altura = double.Parse(Console.ReadLine());       

            // criar objeto Pessoa
            Pessoa pessoaA = new Pessoa(nome, peso, altura);

            // mensagens peso e altura
            Console.WriteLine("O nome da pessoa é {0}", pessoaA.getNome());
            Console.WriteLine("O peso de {0} é de {1}kg.", pessoaA.getNome(), pessoaA.getPeso());
            Console.WriteLine("A altura de {0} é de {1}m.", pessoaA.getNome(), pessoaA.getAltura());

            // calculo do IMC            
            pessoaA.CalculoIMC();            

        }
    }
}
