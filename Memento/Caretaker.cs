namespace DeginPaterrn.Memento
{
    public class Caretaker
    {
        private Memento _memento;

        public Caretaker()
        {
            _memento = new Memento(string.Empty);
        }

        public Memento Memento
        {
            get { return _memento; }
            set { _memento = value; }
        }
    }
}
