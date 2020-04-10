namespace ExemploBuilder_04
{

    class ScooterBuilder : VeiculoBuilder

    {
        private Veiculo _veiculo = new Veiculo("Scooter");

        public override void BuildFrame()
        {
            _veiculo["frame"] = "Scooter Frame";
        }

        public override void BuildEngine()
        {
            _veiculo["engine"] = "Eletrico";
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
