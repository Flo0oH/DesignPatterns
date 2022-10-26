namespace Singleton2
{
    public class Context
    {
        private IState _currentState;
        private IState _stateDownUp;
        private IState _stateRightleft;
        private IState _stateLeftright;
        private IState _stateUpDown;

        public Context()
        {
            _stateDownUp = new StateDownUp(this);
            _stateRightleft = new StateRigthLeft(this);
            //_stateLeftright = new StateLeftright(this);
            //_stateUpdown = new StateUpDown(this);
            _currentState = _stateDownUp;   
        }

        //Hier wird über einem Enum der Status geeändert. Das Enum hat zwei Zustände StateDownUp und StateLeft Up - hier wird der Status in einer Switch Case anweisung gesetzt
        //Wenn jemand den ChangeState Aufruft - von _Context oder vom Client - Status ändern -
        //Vorteil von Switch Case ist beliebig viele Zustände erweitern!
        public void ChangeState(PossibleStates possibleStates)
        {
            switch (possibleStates)
            {
                case PossibleStates.StateDownUp:
                    _currentState = _stateDownUp;   
                    break;

                case PossibleStates.StateRightLeft:
                    _currentState = _stateRightleft;
                    break;
                
            



            }
        }
        //Alle Client methoden die zu verfügung stehen solln
        public void MoveDown()
        {
            _currentState.MoveDown();
        }

        public void MoveLeft()
        {
            _currentState.MoveLeft();
        }

        public void MoveRight()
        {
            _currentState.MoveRight();
        }

        public void MoveUp()
        {
            _currentState.MoveUp();
        }



    }
    public enum PossibleStates
    {
        StateDownUp,
        StateRightLeft,
        StateLeftright,
        StateUpDown
    }
}