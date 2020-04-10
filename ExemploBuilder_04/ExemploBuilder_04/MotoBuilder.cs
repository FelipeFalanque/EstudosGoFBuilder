namespace ExemploBuilder_04
{

    class MotoBuilder : VeiculoBuilder

    {

        private Veiculo _veiculo = new Veiculo("Moto");


        public override void BuildFrame()
        {
            _veiculo["frame"] = "Estrutura de Moto";
        }

        public override void BuildEngine()
        {
            _veiculo["engine"] = "500 cc";
        }

        public override void BuildWheels()
        {
            _veiculo["wheels"] = "2";
        }

        public override void BuildDoors()
        {
            _veiculo["doors"] = "0";
        }

        public override Veiculo GetResult()
        {
            return _veiculo;
        }
    }
}
