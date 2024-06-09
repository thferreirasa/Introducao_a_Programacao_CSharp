using System;

namespace UoU
{
    public abstract class Heroi
    {
        // atributos
        protected string nome;
        protected double pontosDeVida;
        protected int UTHeroi; // unidades de tempo - controla a quant de ações que pode realizar a cada ciclo de jogo
        protected Magia magica;
        protected Arma armaHeroi;
        
        // construtor
        public Heroi(string nome, double pontosDeVida, int UTHeroi = 7)
        {
            this.nome = nome;
            this.pontosDeVida = pontosDeVida;
            this.UTHeroi = UTHeroi;          
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
        public virtual void LancarMagia(Heroi alvo)
        {            
            if (this.UTHeroi >= this.magica.getCustoUT())
            {
                // reduzir as unidades de tempo do heroi, com base no custo de unidades de tempo da magia
                this.ReduzirUT(magica.getCustoUT());
                // chama o metodo lancar da classe magica - simula lançamento da magia
                this.magica.Lancar();
                // reduzir pontos de vida do alvo, com base no dano da magia
                alvo.ReduzirPontosVida((int)magica.getDano()); // conversao double para int
                // mensagem
                Console.WriteLine("{0} lancou a magia {1} em {2}, consumindo {3} unidades de tempo (UT). {2} possui {5} vidas.", this.getNome(), this.magica.getNome(), alvo.getNome(), this.magica.getCustoUT(), alvo.getPontosDeVida());
            } else
            {
                Console.WriteLine("{0} tentou lançar a magia {1} em {2}, mas não possui {3} unidades de tempo (UT) necessárias para isso. Nada aconteceu.", this.nome, this.magica.getNome(), alvo.getNome(), this.magica.getCustoUT());
            }

        }
        public virtual void AtacarComArma(Heroi alvo)
        {            
            if (this.UTHeroi >= this.armaHeroi.getCustoUT())
            {
                this.ReduzirUT(this.armaHeroi.getCustoUT()); // reduz unidades de tempo do atacante
                this.armaHeroi.Atacar(); // roda metodo atacar da arma
                alvo.ReduzirPontosVida((int)this.armaHeroi.getDano()); // reduz vida do alvo

                Console.WriteLine("{0} atacou {1} com a arma {2}. {0} agora possui {3} unidades de tempo e {1} possui {4} pontos de vida.", this.nome, alvo.getNome(), this.armaHeroi.getNome(), this.UTHeroi, alvo.getPontosDeVida());
            }
        }
        public virtual void AumentarPontosVida()
        {
            this.pontosDeVida++;
            Console.WriteLine("Pontos de vida aumentados! {0} pontos de vida", this.pontosDeVida);
        }
        public virtual void ReduzirPontosVida(int dano)
        {
            this.pontosDeVida = pontosDeVida - dano;
            Console.WriteLine("Pontos de vida reduzidos! {0} pontos de vida", this.pontosDeVida);
        }
        public virtual void AumentarUT(int valor)
        {
            this.UTHeroi = UTHeroi + valor;
        }
        public virtual void ReduzirUT(int valor)
        {
            this.UTHeroi = UTHeroi - valor;
        }

    }

    public class HeroiAlianca : Heroi
    {
        // construtor
        public HeroiAlianca(string nome, double pontosDeVida, int UTHeroi = 7) : base(nome, pontosDeVida, UTHeroi)
        {
            Magia magicaAlianca = new Magia("Força Rutilante!", 4, 20);
            Arma armaAlianca = new Arma("Espada", 2, 10);
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

        public override void AtacarComArma(Heroi alvo) { }

        public override void LancarMagia(Heroi alvo) { }
     
    }

    public class HeroiHorda : Heroi
    {
        // construtor
        public HeroiHorda(string nome, double pontosDeVida, int UTHeroi = 7) : base(nome, pontosDeVida, UTHeroi)
        {
            Magia magicaHorda = new Magia("Caminho de Chamas", 6, 30);
            Arma armaHorda = new Arma("Machado", 4, 20);
        }

        // destrutor
        ~HeroiHorda()
        {
            Console.WriteLine("Destrutor Inicializado");
        }

        // métodos da classe
        public override void ReduzirPontosVida(int dano)
        {
            base.ReduzirPontosVida(1);
            this.pontosDeVida -= 0.2;
            Console.WriteLine("Pontos de vida reduzidos! {0} pontos de vida", this.pontosDeVida);
        }

        public override void AtacarComArma(Heroi alvo) { }
       
        public override void LancarMagia(Heroi alvo) { }        
    }

    public class Magia
    {
        // atributos
        protected string nome;
        protected int custoUT; // custo de unidades de tempo
        protected double dano;

        // construtor
        public Magia(string nome, int custoUT, double dano)
        {
            this.nome = nome;
            this.custoUT = custoUT;
            this.dano = dano;
        }

        // destrutor
        ~Magia() { Console.WriteLine("Destrutor Inicializado."); }

        // métodos get e set
        public string getNome() { return this.nome; }
        public void setNome(string nome) { this.nome = nome; }
        public int getCustoUT() { return this.custoUT; }
        public void setCustoUT(int custoUT) { this.custoUT = custoUT; }
        public double getDano() { return this.dano; }
        public void setDano(double dano) { this.dano = dano; }

        // métodos da classe
        public void Lancar()
        {
            Console.WriteLine("O dano causado foi de {0}", this.dano);
        }
    }

    public class Arma
    {
        // atributos
        protected string nome;
        protected int custoUT; // custo de unidades de tempo
        protected double dano;

        // construtor
        public Arma(string nome, int custoUT, double dano)
        {
            this.nome = nome;
            this.custoUT = custoUT;
            this.dano = dano;
        }

        // destrutor
        ~Arma() { Console.WriteLine("Destrutor Inicializado."); }

        // métodos get e set
        public string getNome() { return this.nome; }
        public void setNome(string nome) { this.nome = nome; }
        public int getCustoUT() { return custoUT; }
        public void setCustoUT(int custoUT) { this.custoUT = custoUT; }
        public double getDano() { return this.dano; }
        public void setDano(double dano) { this.dano = dano; }

        // métodos da classe
        public void Atacar()
        {
            Console.WriteLine("O ataque com arma causou um dano de {0}", this.dano);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // criação dos herois
            Heroi ali = new HeroiAlianca("Didinho", 80);
            Heroi hor = new HeroiHorda("Sulinhe", 80);

            // Gameloop!
            while (ali.getPontosDeVida() > 0 && hor.getPontosDeVida() > 0)
            {
                // Rodada Aliança
                // Aumentar UTs do atacante
                ali.AumentarUT(3);
                               
                // Pegar dados do jogador
                Console.WriteLine("Escolha o Ataque do Herói Aliança!");
                Console.WriteLine("Digite 'M' para usar Magia e 'A' para usar uma Arma.");
                string escolha = Console.ReadLine();

                // Ataque
                if (escolha == "M" || escolha == "m")
                {
                    ali.LancarMagia(hor);
                    Console.WriteLine("{0} agora possui {1} pontos de vida.", hor.getNome(), hor.getPontosDeVida());
                } else if (escolha == "A" || escolha == "a")
                {
                    ali.AtacarComArma(hor);
                    Console.WriteLine("{0} agora possui {1} pontos de vida.", hor.getNome(), hor.getPontosDeVida());
                } else
                {
                    Console.WriteLine("A escolha informada é inválida.");
                    continue;
                }

                // verificar se Heroi Horda ainda tem pontos de vida
                if (hor.getPontosDeVida() <= 0)
                {
                    Console.WriteLine("GAME OVER");
                    Console.WriteLine("O Herói Aliança {0} venceu! A sua quantidade restante de vida é de {1}.", ali.getNome(), ali.getPontosDeVida());
                    break;
                }

                // Rodada Herói Horda
                // Aumentar UTs do atacante
                hor.AumentarUT(3);

                // Pegar dados do jogador
                Console.WriteLine("Escolha o Ataque do Herói Horda!");
                Console.WriteLine("Digite 'M' para usar Magia e 'A' para usar uma Arma.");
                escolha = Console.ReadLine();

                // Ataque
                if (escolha == "M" || escolha == "m")
                {
                    hor.LancarMagia(ali);
                    Console.WriteLine("{0} agora possui {1} pontos de vida.", ali.getNome(), ali.getPontosDeVida());
                } else if (escolha == "A" || escolha == "a")
                {
                    hor.AtacarComArma(ali);
                    Console.WriteLine("{0} agora possui {1} pontos de vida.", ali.getNome(), ali.getPontosDeVida());
                } else
                {
                    Console.WriteLine("A escolha informada é inválida.");
                    continue;
                }

                // Verificar pontos de vida do Heroi Aliança
                if (ali.getPontosDeVida() <= 0)
                {
                    Console.WriteLine("GAME OVER");
                    Console.WriteLine("O Herói Horda {0} venceu! A sua quantidade restante de vida é de {1}.", hor.getNome(), hor.getPontosDeVida());
                    break;
                }
            }       
        }
    }
}
 