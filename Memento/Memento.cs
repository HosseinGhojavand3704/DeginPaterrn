using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeginPaterrn.Memento
{
    public class Memento
    {
        private readonly string _exsampleState;

        public Memento
        (
            string exsampleState
        ) {
            _exsampleState = exsampleState;
        }

        public string ExsampleState
        {
            get { return _exsampleState; }
        }
    }
}
