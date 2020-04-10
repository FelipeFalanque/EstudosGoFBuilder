using System;

namespace ExemploBuilder_04
{
    public class MainApp

    {

        public static void Main()
        {
            // Criando o diretor e os builders

            // Diretor recebe um build e manda construir.
            Loja loja = new Loja();

            // cadas build controi o produto X de formar diferente
            VeiculoBuilder scooterBuilder = new ScooterBuilder();
            VeiculoBuilder carroBuilder = new CarroBuilder();
            VeiculoBuilder motoBuilder = new MotoBuilder();

            // Construindo 3 produtos

            loja.Construct(scooterBuilder);
            Veiculo scooter = scooterBuilder.GetResult();
            scooter.Show();

            loja.Construct(carroBuilder);
            Veiculo carro = carroBuilder.GetResult();
            carro.Show();

            loja.Construct(motoBuilder);
            Veiculo moto = motoBuilder.GetResult();
            moto.Show();

            Console.ReadKey();
        }
    }
}
