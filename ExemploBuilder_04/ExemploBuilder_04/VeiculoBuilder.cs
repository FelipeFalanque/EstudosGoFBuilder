namespace ExemploBuilder_04
{
    abstract class VeiculoBuilder

    {
        public abstract void BuildFrame();
        public abstract void BuildEngine();
        public abstract void BuildWheels();
        public abstract void BuildDoors();
        public abstract Veiculo GetResult();
    }
}
