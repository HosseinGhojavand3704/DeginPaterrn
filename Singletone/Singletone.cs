using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeginPaterrn.Singletone
{
    public class SampleObjectSingletone
    {
        private readonly static SampleObjectSingletone _instance = new SampleObjectSingletone();

        private SampleObjectSingletone()
        {
        }

        public static SampleObjectSingletone GetInstance() => _instance;
    }
}
