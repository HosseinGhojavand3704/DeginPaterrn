using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeginPaterrn.Command.Services
{
    public interface IServiceOne
    {
        void ActionOne1();
        void ActionTwo1();
    }

    public class ServiceOne : IServiceOne
    {
        public ServiceOne()
        {
        }

        public void ActionOne1()
        {
            Console.WriteLine($"This Run The Method => ActionTwo In The Service: {nameof(ServiceOne)}");
        }

        public void ActionTwo1()
        {
            Console.WriteLine($"This Run The Method => ActionOne In The Service: {nameof(ServiceOne)}");
        }
    }
}
