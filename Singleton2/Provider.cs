namespace Singleton2
{
    class Provider:IObservable<DataObject>
    {
        private List<IObserver<DataObject>> _observers = new List<IObserver<DataObject>>();
        
      

        public IDisposable Subscribe(IObserver<DataObject> observer)
        {
            //einfügen abmelden undprüfen
            if(!_observers.Contains(observer))
                _observers.Add(observer);
            return new Unsubscriber(_observers, observer);
        }

        public void Notify(DataObject data)
        {
            //weiterleiten an alle Observern an die das Datenobjekt weitergeleitet werden muss
            foreach (var observer in _observers)
            {
                //weiterleiten der Daten an die jeweiligen Observer wenn sich etwas ändernt
                observer.OnNext(data);
            }
        }



    }

}
