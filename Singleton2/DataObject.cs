namespace Singleton2
{
    class DataObject
    {

        private Provider _provider;
        public DataObject(Provider provider)

        {
            _provider = provider;
 
        }
    
        public string Data { get; set; }    
        public string Name { get; set; }
        public int Id { get; set; }

        public void SetData(string message)
        {
            Data = message;
          
            _provider.Notify(this);
        }
    }
}