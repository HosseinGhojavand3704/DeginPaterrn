using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeginPaterrn.Visitor
{
    public class ElementSnappStructure
    {
        private readonly IList<ISnapp> _elementSnapps;

        public ElementSnappStructure()
        {
            _elementSnapps = new List<ISnapp>();
        }

        public void Add(ISnapp snapp) => _elementSnapps.Add(snapp);

        public void Remove(ISnapp snapp) => _elementSnapps.Remove(snapp);

        public void Accept(IVisitor visitor)
        {
            foreach (ISnapp elementSnapp in _elementSnapps)
                elementSnapp.Accept(visitor);
        }
    }
}
