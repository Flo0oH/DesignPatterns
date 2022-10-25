namespace Singleton2
{
    public class ConcreteAbstractor : Abstractor
    {
        public ConcreteAbstractor(IImplementor implementor) : base(implementor) { }

        public override void Methode_A()
        {
            
            base.implementor.Methode_A();

        }

        public override void Methode_B()
        {
            base.implementor.Methode_B();
        }
    }
}