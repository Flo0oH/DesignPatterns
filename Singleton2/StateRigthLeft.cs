namespace Singleton2
{
    public class StateRigthLeft : IState
    {
        private Context _context;

        //Construktor Möglichkeit den Status zu ändern!!!
        public StateRigthLeft(Context context)
        {
            _context = context;
        }

        public void MoveDown()
        {
            Console.WriteLine("Moving Down. ..");
            _context.ChangeState(PossibleStates.StateRightLeft);
        }

        public void MoveLeft()
        {
            //nothing toDo
        }

        public void MoveRight()
        {
            //nothing toDo
        }

        public void MoveUp()
        {
            Console.WriteLine("Moving Up. ..");
        }
    }
}