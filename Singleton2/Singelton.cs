namespace Singleton2
{
    class Singelton
    {
        public void startasingletonexample()
        {
            UserContext myContext = UserContext.instance;
            Console.WriteLine(myContext == UserContext.instance);
            Console.WriteLine(UserContext.instancelate);
            var myname = UserContext.instance.UserName;
            var myid = UserContext.instance.UserId;
            myContext.Load();
            myname = UserContext.instance.UserName;
            myid = UserContext.instance.UserId;
            Console.WriteLine(myname + myid);
            Console.ReadLine();
        }
    }
}