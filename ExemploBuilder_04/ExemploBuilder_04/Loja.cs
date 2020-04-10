namespace ExemploBuilder_04
{

    class Loja

    {

        public void Construct(VeiculoBuilder vehicleBuilder)
        {
            // constroi estrutura
            vehicleBuilder.BuildFrame();
            // constroi motor
            vehicleBuilder.BuildEngine();
            // constroi rodas
            vehicleBuilder.BuildWheels();
            // constroi portas
            vehicleBuilder.BuildDoors();
        }
    }
}
