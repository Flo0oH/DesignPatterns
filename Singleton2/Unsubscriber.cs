namespace Singleton2
{
    class Unsubscriber : IDisposable
    {
        private List<IObserver<DataObject>> _observers;
        private IObserver<DataObject> _observer;    
        public Unsubscriber(List<IObserver<DataObject>> _observers, IObserver<DataObject> observer)
        {
            this._observers = _observers;
            this._observer = observer;
        }
        public void Dispose()
        {
            _observers.Remove(_observer);
        }
        public void Refresh()
        {
            _observers.Add(_observer);
        }
    }
}