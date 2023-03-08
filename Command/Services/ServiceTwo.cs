using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeginPaterrn.Command.Services
{
    public interface IServiceTwo
    {
        void ActionOne2();
        void ActionTwo2();
    }

    public class ServiceTwo : IServiceTwo
    {
        public ServiceTwo()
        {
        }

        public void ActionOne2()
        {
            Console.WriteLine($"This Run The Method => ActionOne In The Service: {nameof(ServiceTwo)}");
        }

        public void ActionTwo2()
        {
            Console.WriteLine($"This Run The Method => ActionTwo In The Service: {nameof(ServiceTwo)}");
        }
    }
}
