namespace DeginPaterrn.Memento
{
    public class Originator
    {
        private string _exsampleState;

        public string ExsampleState
        {
            get { return _exsampleState; }
            set
            {
                _exsampleState = value;
                Console.WriteLine($"Originator State= {_exsampleState}");
            }
        }

        public Originator()
        {
        }

        public Memento CreateMemento()
        {
            Console.WriteLine("Saving state......");
            return (new Memento(ExsampleState));
        }

        public void SetMemento(Memento memento)
        {
            ExsampleState = memento.ExsampleState;
            Console.WriteLine("Restoring state...");
        }

    }
}
