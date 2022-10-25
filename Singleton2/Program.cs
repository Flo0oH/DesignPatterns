namespace Singleton2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("MySingelton!");
            //tryout a singleton pattern
            Singelton mysingelton = new Singelton();
            mysingelton.start();
            //tryout a bridge pattern - first create an abstract Class and made kids
            ChildofAbstractClass mychild = new ChildofAbstractClass();
            var i = 1;
            mychild.DoWork(i);
            Console.WriteLine(mychild.test.ToString());



            /*
             * Bridge Pattern
                Zweck
                Das Bridge Pattern dient dazu, das Interface von der Implementierung zu trennen.
                Dies bietet in folgenden Situationen Vorteile:

                - wenn die Implementierung zur Laufzeit ausgetauscht werden soll
                - sowohl das Interface als auch die Implementierung durch Unterklassenbildung erweiterbar bleiben soll
                - der Austausch der Implementierung kein neues Übersetzen des Codes zur Folge haben soll

             * 
             */
            ConcreteImplementor_A myconcreteimplementor = new ConcreteImplementor_A();

            //Inteface Aufrufen
            IImplementor implementor_A = new ConcreteImplementor_A();
            IImplementor implementor_B = new ConcreteImplementor_B();
            //ÜBergeben den Implementor and den Abstractor übergeben. Das geht zur Laufzeit!!!

            Abstractor abstactor_A = new ConcreteAbstractor(implementor_A);
            Abstractor abstactor_B = new ConcreteAbstractor(implementor_B);

            //Aufrufen der verschieden möglichkeiten die sich durch das Bridge Pattern jetzt ergeben. 
            abstactor_A.Methode_A();
            abstactor_A.Methode_B();
            abstactor_B.Methode_A();
            abstactor_B.Methode_B();
            Console.ReadLine();




        }
    }

       
}