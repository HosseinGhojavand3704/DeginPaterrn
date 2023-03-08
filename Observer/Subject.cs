using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeginPaterrn.Observer
{

    public interface ISubject
    {
        void AttechObserver(IObserverbel observerbel);
        void DettechObserver(IObserverbel observerbel);
        void Notify();
    }

    public abstract class Subject: ISubject
    {
        private IList<IObserverbel> _observerbels;

        protected Subject()
        {
            _observerbels = new List<IObserverbel>();
        }

        public void Notify()
        {
            foreach (IObserverbel observerbel in _observerbels)
                observerbel.Update();
        }

        public void AttechObserver(IObserverbel observerbel) =>
            _observerbels.Add(observerbel);

        public void DettechObserver(IObserverbel observerbel) =>
            _observerbels.Remove(observerbel);

    }

    public class ConcreteSubject : Subject
    {
        public string SubjectState { get; set; } = string.Empty;
    }
}
