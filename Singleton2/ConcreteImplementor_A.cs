namespace Singleton2
{
    internal class ConcreteImplementor_A : IImplementor
    {
       
        
        public void Methode_A()
        {
            Console.WriteLine("\tThis is Method_A from Implementor_A");
        }

        public void Methode_B()
        {
            Console.WriteLine("\tThis is Method_B from Implementor_A");
        }
    }
}