namespace Singleton2
{
    public abstract class Abstractor
    {
        //protected damit auf diesen in meinen Subclassen zugreifen kann
        protected IImplementor implementor;
        //Implementor Setzen!!! benutzung im Abstractor einen Konstructor der die Instanz des IImplementors
        protected Abstractor(IImplementor implementor)
        {
            //dem Constructor setze ich dem Implementor den ich als Argument übergeben bekommen habe
            this.implementor = implementor;
        }

        public abstract void Methode_A();
        public abstract void Methode_B();

    }
}