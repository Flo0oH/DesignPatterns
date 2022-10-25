namespace Singleton2
{
    internal class ChildofAbstractClass : AbstractClass
    {
        
        
        public override void DoWork(int i)
        {
            
            Console.WriteLine("Im the cild of an Abstract Class");
        }
    }
}