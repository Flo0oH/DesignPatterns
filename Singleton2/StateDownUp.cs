namespace Singleton2
{
    internal class StateDownUp : IState
    {
        private Context _context;

        //Construktor Möglichkeit den Status zu ändern!!!
        public StateDownUp(Context context)
        {
            _context = context;
        }

        public void MoveDown()
        {
            //nothing toDo
        }

        public void MoveLeft()
        {
            Console.WriteLine("Moving Left. ..");
        }

        public void MoveRight()
        {
            Console.WriteLine("Moving Right. ..");
        }

        public void MoveUp()
        {
            //nothing toDo
        }
    }
}