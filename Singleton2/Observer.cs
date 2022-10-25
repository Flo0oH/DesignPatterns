namespace Singleton2
{
    class Observer : IObserver<DataObject>
    {
        private string _name = "";
        public IDisposable _unsubscriber;
        public Observer(string name)
        {
            this._name = name;
        }
        
        public void OnCompleted()
        {
            Console.WriteLine($"Server '{_name}' is waiting mode.'");
            Console.ReadLine();
        }

        public void OnError(Exception error)
        {
            Console.WriteLine($"Error '{_name}' gets new Message: '{error}'");
            Console.ReadLine();
        }

        public void OnNext(DataObject value)
        {
            Console.WriteLine($"Observer '{_name}' gets new Message: '{value.Data}'");
            Console.ReadLine();
        }
    }
}