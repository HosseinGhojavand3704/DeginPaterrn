using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeginPaterrn.ChainResponsibility
{
    public abstract class ChainResponsibility
    {
        protected ChainResponsibility? _successor;
        public void SetSuccessor(ChainResponsibility successor)
        {
            _successor = successor;
        }

        public abstract void RequestHandeler(int request);
    }

    public class ChainResponsibilityConcreate : ChainResponsibility
    {
        public ChainResponsibilityConcreate()
        {
        }

        public override void RequestHandeler(int request)
        {
            if (request >= 50)
            {
                Console.WriteLine($"ChainResponsibilityConcreate => request: {request}");
            }

            if (_successor is not null)
                _successor.RequestHandeler(request);
        }
    }

    public class ChainResponsibilityConcreate2 : ChainResponsibility
    {
        public ChainResponsibilityConcreate2()
        {
        }

        public override void RequestHandeler(int request)
        {
            if (request >= 60)
            {
                Console.WriteLine($"ChainResponsibilityConcreate2 => request: {request}");
            }

            if (_successor is not null)
                _successor.RequestHandeler(request);
        }
    }

    public class ChainResponsibilityConcreate3 : ChainResponsibility
    {
        public ChainResponsibilityConcreate3()
        {
        }

        public override void RequestHandeler(int request)
        {
            if (request >= 90)
            {
                Console.WriteLine($"ChainResponsibilityConcreate3 => request: {request}");
            }

            if (_successor is not null)
                _successor.RequestHandeler(request);
        }
    }
}
