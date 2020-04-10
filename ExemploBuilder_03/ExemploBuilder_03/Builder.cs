namespace ExemploBuilder_03
{
    /// O 'Builder' abstract class

    abstract class Builder

    {
        public abstract void BuildPartA();
        public abstract void BuildPartB();
        public abstract Product GetResult();
    }
}
