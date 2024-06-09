using System;

namespace exercicioZoologico
{
    public class Animal
    {
        // propriedade/atributo
        public string nome;

        // construtor
        public Animal(string nome)
        {
            this.nome = nome;
        }

        // destrutor
        ~Animal()
        {
            Console.WriteLine("Destrutor Inicializado.");
        }

        // metodos get e set
        public string getNome() { return this.nome; }
        public void setNome(string nome) { this.nome = nome; }

        // métodos da classe
        public void Acordar()
        {
            Console.WriteLine("{0} acordou.", this.nome);
        }

        public void Comer()
        {
            Console.WriteLine("{0} comeu.", this.nome);
        }

        public void Dormir()
        {            
            Console.WriteLine("{0} dormiu.", this.nome);
        }
    }

    class Mamifero:Animal
    {
        // herda atributos de Animal

        // construtor
        public Mamifero(string nome):base(nome)
        {
            this.nome = nome;
        }

        // destrutor
        ~Mamifero()
        {
            Console.WriteLine("Destrutor Inicializado.");
        }

        // métodos da classe
        public void Mamar()
        {            
            Console.WriteLine("{0} está mamando.", this.nome);
        }
    }

    class Morcego:Mamifero
    {
        // atributos foram herdados

        // construtor
        public Morcego(string nome):base(nome)
        {
            this.nome = nome;
        }

        // destrutor
        ~Morcego()
        {
            Console.WriteLine("Destrutor Inicializado.");
        }

        // métodos da classe
        public void Voar()
        {            
            Console.WriteLine("{0} está voando.", this.nome);
        }
    }

    class Baleia:Mamifero {
        // atributos foram herdados

        // construtor
        public Baleia(string nome):base(nome)
        {
            this.nome = nome;
        }

        // destrutor
        ~Baleia()
        {
            Console.WriteLine("Destrutor Inicializado.");            
        }

        // método da classe
        public void Nadar()
        {
            Console.WriteLine("{0} está nadando.", this.nome);
        }
    }

    class Program
    {
        static void Main(string[]args)
        {
            // criar objeto morcego
            Morcego morcegoAlfredinho = new Morcego("Alfredinho");

            // criar objeto baleia
            Baleia baleiaGeorgina = new Baleia("Georgina");

            // uso métodos morcego
            morcegoAlfredinho.Acordar();
            morcegoAlfredinho.Comer();
            morcegoAlfredinho.Dormir();
            morcegoAlfredinho.Mamar();
            morcegoAlfredinho.Voar();

            // uso métodos baleia
            baleiaGeorgina.Acordar();
            baleiaGeorgina.Comer();
            baleiaGeorgina.Dormir();
            baleiaGeorgina.Mamar();
            baleiaGeorgina.Nadar();
        }
    }
}
