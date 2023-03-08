namespace DeginPaterrn.Bridge
{
    /// <summary>
    /// Add Classes Abstractions
    /// </summary>
    /// 
    public abstract class Abstraction
    {
        private readonly Implementer _mplementer;

        protected Abstraction
        (
        ) {
            _mplementer = new ConcreateImplementer();
        }

        public virtual void Function()
        {
            _mplementer.Implemention();
        }
    }


    public class RefinedAbstraction : Abstraction
    {
        public RefinedAbstraction()
        {
        }
    }

    /// <summary>
    /// Add Classes Implemention
    /// </summary>

    public abstract class Implementer
    {
        public abstract void Implemention();
    }

    public class ConcreateImplementer : Implementer
    {
        public ConcreateImplementer()
        {
        }

        public override void Implemention()
        {
            Console.WriteLine("This Run Method Implemention");
        }
    }
}
