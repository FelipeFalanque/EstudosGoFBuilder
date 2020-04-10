using System;

namespace ExemploBuilder_03
{
    public class MainApp

    {

        public static void Main()
        {
            // Criando o diretor e os builders

            // Diretor recebe um build e manda construir.
            Director director = new Director();

            // cadas build controi o produto X de formar diferente
            Builder b1 = new ConcreteBuilder1();
            Builder b2 = new ConcreteBuilder2();
            Builder b3 = new ConcreteBuilder3();

            // Construindo 3 produtos

            director.Construct(b1);
            Product p1 = b1.GetResult();
            p1.Show();

            director.Construct(b2);
            Product p2 = b2.GetResult();
            p2.Show();

            director.Construct(b3);
            Product p3 = b3.GetResult();
            p3.Show();

            Console.ReadKey();
        }
    }
}
