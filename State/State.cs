namespace DeginPaterrn.State
{
    public interface IState
    {
        void Request(Context context);
    }

    public class Context
    {
        public IState _state;

        public Context()
        {
            _state = new ConcreateStateOne();
        }

        public void Request()
        {
            _state.Request(this);
        }
    }

    public class ConcreateStateOne : IState
    {
        public ConcreateStateOne()
        {
        }

        public void Request(Context context)
        {
            Console.WriteLine("This Is State One");
            context._state = new ConcreateStateTwo();
        }
    }

    public class ConcreateStateTwo : IState
    {
        public ConcreateStateTwo()
        {
        }

        public void Request(Context context)
        {
            Console.WriteLine("This Is State Two");
            context._state = new ConcreateStateThree();
        }
    }

    public class ConcreateStateThree : IState
    {
        public ConcreateStateThree()
        {
        }

        public void Request(Context context)
        {
            Console.WriteLine("This Is State Three");
            context._state = new ConcreateStateOne();
        }
    }

}
