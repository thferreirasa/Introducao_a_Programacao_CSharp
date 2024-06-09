using System;

namespace UoU
{
    public abstract class Heroi
    {
        // atributos
        protected string nome;
        protected double pontosDeVida;

        // construtor
        public Heroi(string nome, double pontosDeVida)
        {
            this.nome = nome;
            this.pontosDeVida = pontosDeVida;
        }

        // destrutor
        ~Heroi()
        {
            Console.WriteLine("Destrutor Inicializado.");
        }

        // métodos get e set
        public string getNome() { return this.nome; }
        public void setNome(string nome) { this.nome = nome; }
        public double getPontosDeVida() { return this.pontosDeVida; }
        public void setPontosDeVida(double pontosDeVida) { this.pontosDeVida = pontosDeVida; }

        // métodos da classe
        public abstract void LancarMagia();
        public abstract void AtacarComArma();
        public virtual void AumentarPontosVida()
        {
            this.pontosDeVida++;
            Console.WriteLine("Pontos de vida aumentados! {0} pontos de vida", this.pontosDeVida);
        }
        public virtual void ReduzirPontosVida()
        {
            this.pontosDeVida--;
            Console.WriteLine("Pontos de vida reduzidos! {0} pontos de vida", this.pontosDeVida);
        }

    }

    public class HeroiAlianca : Heroi
    {
        // construtor
        public HeroiAlianca(string nome, double pontosDeVida) :base(nome, pontosDeVida)
        {
            
        }

        // destrutor
        ~HeroiAlianca()
        {
            Console.WriteLine("Destrutor Inicializado.");
        }

        // métodos da classe
        public override void AumentarPontosVida()
        {
            base.AumentarPontosVida();
            this.pontosDeVida += 0.2;
            Console.WriteLine("Pontos de vida aumentados!! {0} pontos de vida", this.pontosDeVida);
        }

        public override void AtacarComArma()
        {
            Console.WriteLine("{0} atacou com sua arma Aliança!", this.nome);
        }

        public override void LancarMagia()
        {
            Console.WriteLine("{0} lançou a super magia Aliança!", this.nome);
        }


    }

    public class HeroiHorda : Heroi
    {
        // construtor
        public HeroiHorda(string nome, double pontosDeVida) :base(nome, pontosDeVida)
        {
           
        }

        // destrutor
        ~HeroiHorda()
        {
            Console.WriteLine("Destrutor Inicializado");
        }

        // métodos da classe
        public override void ReduzirPontosVida()
        {
            base.ReduzirPontosVida();
            this.pontosDeVida -= 0.2;
            Console.WriteLine("Pontos de vida reduzidos! {0} pontos de vida", this.pontosDeVida);
        }

        public override void AtacarComArma()
        {
            Console.WriteLine("{0} atacou com sua arma Horda!", this.nome);
        }

        public override void LancarMagia()
        {
            Console.WriteLine("{0} usou o poder da Horda!", this.nome);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Heroi Zymmax, com 100 pts de vida
            Heroi zymmax = new HeroiAlianca("Zymmax", 100);

            // exibir nome e pontos de Zymmax
            Console.WriteLine(zymmax.getNome());
            Console.WriteLine(zymmax.getPontosDeVida());

            // aumentar e reduzir vida de Zymmax
            zymmax.AumentarPontosVida();
            zymmax.ReduzirPontosVida();

            // Heroi Aliança Zadur, 100 pts de vida
            HeroiAlianca zadur = new HeroiAlianca("Zadur", 100);

            // exibir nome e pontos de vida de Zadur
            Console.WriteLine(zadur.getNome());
            Console.WriteLine(zadur.getPontosDeVida());

            // aumentar e reduzir vida de Zadur
            zadur.AumentarPontosVida();
            zadur.ReduzirPontosVida();

            // Heroi Horda Zodar, 100 pts de vida
            HeroiHorda zodar = new HeroiHorda("Zodar", 100);

            // exibir nome e pontos de vida de Zodar
            Console.WriteLine(zodar.getNome());
            Console.WriteLine(zodar.getPontosDeVida());

            // aumentar e reduzir vida de Zodar
            zodar.AumentarPontosVida();
            zodar.ReduzirPontosVida();

            // variaveis ali e hor
            Heroi ali = new HeroiAlianca("Kadum", 100);
            Heroi hor = new HeroiHorda("Zumzum", 100);

            // invocar metodos abstratos de Heroi usando variaveis ali e hor
            ali.LancarMagia();
            ali.AtacarComArma();
            hor.LancarMagia();
            hor.AtacarComArma();
            
        }


    }
}