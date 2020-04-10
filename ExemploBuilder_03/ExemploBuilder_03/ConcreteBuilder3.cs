namespace ExemploBuilder_03
{
    class ConcreteBuilder3: Builder

    {
        private Product _product = new Product();

        public override void BuildPartA()
        {
            _product.Add("PartN");
        }

        public override void BuildPartB()
        {
            _product.Add("PartM");
        }

        public override Product GetResult()
        {
            return _product;
        }
    }
}