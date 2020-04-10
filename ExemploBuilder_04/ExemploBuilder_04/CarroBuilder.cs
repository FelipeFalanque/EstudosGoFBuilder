namespace ExemploBuilder_04
{

    class CarroBuilder : VeiculoBuilder

    {

        private Veiculo _veiculo = new Veiculo("Carro");

        public override void BuildFrame()
        {
            _veiculo["frame"] = "Estrutura de Carro";
        }

        public override void BuildEngine()
        {
            _veiculo["engine"] = "2500 cc";
        }

        public override void BuildWheels()
        {
            _veiculo["wheels"] = "4";
        }

        public override void BuildDoors()
        {
            _veiculo["doors"] = "4";
        }

        public override Veiculo GetResult()
        {
            return _veiculo;
        }
    }
}
