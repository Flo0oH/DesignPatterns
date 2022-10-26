using System;
using System.Reflection;
using System.Resources;
namespace Singleton2
{
    internal class Program
    {
        public static TxtStrategy saveStrategy { get; private set; }

        static void Main(string[] args)
        {
            //Einbindung Externer Ressourcen für z.B. Sprachumschaltung
            
            ResourceManager rm = new ResourceManager("Singleton2.Resources.Strings",
                    Assembly.GetExecutingAssembly());
            Console.WriteLine(Thread.CurrentThread.CurrentUICulture.Name);
            Console.WriteLine(rm.GetString("Welcome"));
            Thread.CurrentThread.CurrentUICulture = System.Globalization.CultureInfo.CreateSpecificCulture("de-AT");
            Console.WriteLine(Thread.CurrentThread.CurrentUICulture.Name);
            Console.WriteLine(rm.GetString("Welcome"));
            Thread.CurrentThread.CurrentUICulture = System.Globalization.CultureInfo.CreateSpecificCulture("jp");
            Console.WriteLine(Thread.CurrentThread.CurrentUICulture.Name);
            Console.WriteLine(rm.GetString("Welcome"));
            Thread.CurrentThread.CurrentUICulture = System.Globalization.CultureInfo.CreateSpecificCulture("de-DE");
            Console.WriteLine(Thread.CurrentThread.CurrentUICulture.Name);
            Console.WriteLine(rm.GetString("Welcome"));
            Console.ReadLine();



                
            
            
            Console.WriteLine("Hier ein Beispiel für ein Singelton Pattern");
            //tryout a singleton pattern
            Singelton mysingelton = new Singelton();
            /*
             *  
                public static UserContext instance = new UserContext();
                Beispiel für frühe Initialisierung
                Beispiel für späte Initialisierung
             * 
             * */
            mysingelton.startasingletonexample();
            
            
            
            
            
            
            
            
            
            
            
            
            
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
            
                    dynamisch, zur Laufzeit
                        Entkopplung von der Schnittstelle und der Implementierung
                            der Klient kann zur Laufzeit die Schnittstelle austauschen
                            die Schnittstelle kann zur Laufzeit ihre Implementierung austauschen
                            die Implementierung kann von mehreren Schnittstellen genützt werden
                            MOVED TO... maximale Flexibilität zur Laufzeit, da sowohl die Abstraktion über der Schnittstellle als auch Abstraktion über der Implementierung ausgetauscht werden können
                    statisch
                        Verbesserte Erweiterbarkeit durch die Interface- und Implemtierungsabstraktion
                    Verstecken von Implementierunsdetails vor dem Clienten, so daß zusätzliche Logik ( Referenzzähler ) in die Implementierung gesteckt werden kann ( vgl. Proxy ; dort wird das Interface um zusätzliche Funktionalität erweitert )

             * 
             */
            ConcreteImplementor_A myconcreteimplementor = new ConcreteImplementor_A();

            //Inteface Aufrufen
            IImplementor implementor_A = new ConcreteImplementor_A();
            IImplementor implementor_B = new ConcreteImplementor_B();
            //ÜBergeben den Implementor and den Abstractor übergeben. Das geht zur Laufzeit!!!

            Abstractor abstactor_A = new ConcreteAbstractor(implementor_A);
            Abstractor abstactor_B = new ConcreteAbstractor(implementor_B);




            Console.WriteLine("Hier ein Beispiel für ein typisches Bridge Pattern");

            //Aufrufen der verschieden möglichkeiten die sich durch das Bridge Pattern jetzt ergeben. 
            abstactor_A.Methode_A();
            abstactor_A.Methode_B();

            abstactor_B.Methode_A();
            abstactor_B.Methode_B();
            Console.ReadLine();

            //Absurber Pattern
            Absurber myabsurber = new Absurber();
            Absurber.Start();
            Absurber.MyStartParamLoad();




            
            
            
            Console.WriteLine("Hier ein Beispiel für ein besonders Elegantes Observer Pattern!!!!");
            //Test Design Patter Observer
            Provider myprov = new Provider();
            DataObject dataObject = new DataObject(myprov);
            Observer observer1 = new Observer("Observer 1");
            Observer observer2 = new Observer("Observer 2");
            dataObject.SetData("Hallo das ist mein Observer Message");
            //hier passiert noch nichts wir brauchen
            observer1._unsubscriber = myprov.Subscribe(observer1);
            observer2._unsubscriber = myprov.Subscribe(observer2);
            dataObject.SetData("Datenbankverbindung Connectionstring");
            observer1._unsubscriber.Dispose();
            dataObject.SetData("New Connectionsstring for new DB");
            observer2._unsubscriber = myprov.Subscribe(observer2);
            observer1._unsubscriber = myprov.Subscribe(observer1);
            Console.ReadLine();






            //Facade
            Facade.CreateFile();
            var myfile = "myfile.sql";
            var myExtension = Path.GetExtension(myfile);

            //Strategy Pattern
            switch (myExtension.ToLower())
            {
                case ".txt":
                    saveStrategy = new TxtStrategy();
                    break;
                case ".sql":
                    saveStrategy = new SqlStrategy();
                    break;
                default:
                    throw new Exception(myExtension);   
            }


            //Strategy Pattern start
            Console.WriteLine("Start with Strategy Pattern start");
            Context context = new Context();
            //Client ist das Programm.cs klasse Hier -
            context.MoveUp();
            context.MoveDown();
            context.MoveLeft();
            context.MoveRight();
            Console.WriteLine("Changing State");
            context.ChangeState(PossibleStates.StateRightLeft);
            context.MoveUp();
            context.MoveDown();
            context.MoveLeft();
            context.MoveRight();
            Console.WriteLine("End with Strategy Pattern start");
            Console.ReadLine();




            Thread.CurrentThread.CurrentUICulture = System.Globalization.CultureInfo.CreateSpecificCulture("de-AT");
            Console.WriteLine(Thread.CurrentThread.CurrentUICulture.Name);
            Console.WriteLine(rm.GetString("Goodbye"));

            Thread.CurrentThread.CurrentUICulture = System.Globalization.CultureInfo.CreateSpecificCulture("de-DE");
            Console.WriteLine(Thread.CurrentThread.CurrentUICulture.Name);
            Console.WriteLine(rm.GetString("Goodbye"));

            Thread.CurrentThread.CurrentUICulture = System.Globalization.CultureInfo.CreateSpecificCulture("jp");
            Console.WriteLine(Thread.CurrentThread.CurrentUICulture.Name);
            Console.WriteLine(rm.GetString("Goodbye"));


        }
    }

       
}