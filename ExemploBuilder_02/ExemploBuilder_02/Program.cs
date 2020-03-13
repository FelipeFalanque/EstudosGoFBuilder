using System;

namespace ExemploBuilder_02
{
    class Program
    {
        static void Main(string[] args)
        {
            var exercito = new Exercito();
            CriadorDeGuerreiro criadorDeGuerreiro;
            Guerreiro guerreiro;

            // criando um guerreiro medieval
            criadorDeGuerreiro = new CriadorDeGuerreiroMedieval();
            exercito.ConstruirGuerreiro(criadorDeGuerreiro);
            guerreiro = criadorDeGuerreiro.ObterGuerreiro();
            Console.WriteLine("Guerreiro com as características: {0}, {1}, {2}", guerreiro.Arco, guerreiro.Armadura, guerreiro.Espada);

            // criando um guerreiro futurista
            criadorDeGuerreiro = new CriadorDeGuerreiroFuturista();
            exercito.ConstruirGuerreiro(criadorDeGuerreiro);
            guerreiro = criadorDeGuerreiro.ObterGuerreiro();
            Console.WriteLine("Guerreiro com as características: {0}, {1}, {2}", guerreiro.Arco, guerreiro.Armadura, guerreiro.Espada);

            Console.ReadLine();
        }
    }

    // Builder abstrato - fornece uma interface para criação de um guerreiro
    public abstract class CriadorDeGuerreiro
    {
        protected Guerreiro _guerreiro;
        public Guerreiro ObterGuerreiro()
        {
            return _guerreiro;
        }

        public abstract CriadorDeGuerreiro ComEspada();
        public abstract CriadorDeGuerreiro ComArmadura();
        public abstract CriadorDeGuerreiro ComArco();
    }

    // Produto abstrato - resultado do builder
    public abstract class Guerreiro
    {
        public string Espada { get; protected set; }
        public string Armadura { get; protected set; }
        public string Arco { get; protected set; }

        public abstract void EscolherEspada(string espada);
        public abstract void ColocarArmadura(string armadura);
        public abstract void EscolherArco(string arco);
    }

    // Director - faz uso de um builder para construir o produto
    public class Exercito
    {
        public void ConstruirGuerreiro(CriadorDeGuerreiro criadorDeGuerreiro)
        {
            //criadorDeGuerreiro.ComArco();
            //criadorDeGuerreiro.ComArmadura();
            //criadorDeGuerreiro.ComEspada();

            // montagem do produto de forma fluente
            criadorDeGuerreiro.ComArco().ComArmadura().ComEspada();
        }
    }

    public class CriadorDeGuerreiroMedieval : CriadorDeGuerreiro
    {
        public CriadorDeGuerreiroMedieval()
        {
            _guerreiro = new GuerreiroMedieval();
        }

        public override CriadorDeGuerreiro ComEspada()
        {
            _guerreiro.EscolherEspada("espada medieval");
            return this;
        }

        public override CriadorDeGuerreiro ComArmadura()
        {
            _guerreiro.ColocarArmadura("armadura medieval");
            return this;
        }

        public override CriadorDeGuerreiro ComArco()
        {
            _guerreiro.EscolherArco("arco medieval");
            return this;
        }
    }

    public class GuerreiroMedieval : Guerreiro
    {
        public override void EscolherEspada(string espada)
        {
            Espada = espada;
        }

        public override void ColocarArmadura(string armadura)
        {
            Armadura = armadura;
        }

        public override void EscolherArco(string arco)
        {
            Arco = arco;
        }
    }

    public class CriadorDeGuerreiroFuturista : CriadorDeGuerreiro
    {
        public CriadorDeGuerreiroFuturista()
        {
            _guerreiro = new GuerreiroFuturista();
        }

        public override CriadorDeGuerreiro ComEspada()
        {
            _guerreiro.EscolherEspada("espada futurista");
            return this;
        }

        public override CriadorDeGuerreiro ComArmadura()
        {
            _guerreiro.ColocarArmadura("armadura futurista");
            return this;
        }

        public override CriadorDeGuerreiro ComArco()
        {
            _guerreiro.EscolherArco("arco futurista");
            return this;
        }
    }

    public class GuerreiroFuturista : Guerreiro
    {
        public override void EscolherEspada(string espada)
        {
            Espada = espada;
        }

        public override void ColocarArmadura(string armadura)
        {
            Armadura = armadura;
        }

        public override void EscolherArco(string arco)
        {
            Arco = arco;
        }
    }
}
