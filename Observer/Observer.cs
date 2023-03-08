using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DeginPaterrn.Observer
{
    public interface IObserverbel
    {
        void Update();
    }

    public class ConcreteObserver : IObserverbel
    {
        public string _name { get; set; }
        private string _observerState { get; set; }

        private readonly ConcreteSubject _concreteSubject;

        public ConcreteObserver
        (
            string steteName,
            ConcreteSubject subject            
        ) {
            _name = steteName;
            _concreteSubject = subject;
        }

        public void Update()
        {
            _observerState = _concreteSubject.SubjectState;
            Console.WriteLine($"{_name} : observerState update = {_concreteSubject.SubjectState} ");
        }
    }

}
