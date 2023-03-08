using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeginPaterrn.Adapter
{

    public interface IAdaptee
    {
        void Operation();
    }

    /// <summary>
    /// This objects implemented << IAdaptee >>
    /// </summary>

    public class CircleObject : IAdaptee
    {
        public CircleObject()
        {
        }

        public void Operation()
        {
            Console.WriteLine($"My {nameof(CircleObject)} with interface {nameof(IAdaptee)} implemented and running.");
        }
    }
    public class SquareObject : IAdaptee
    {
        public SquareObject()
        {
        }

        public void Operation()
        {
            Console.WriteLine($"My {nameof(SquareObject)} with interface {nameof(IAdaptee)} implemented and running.");
        }
    }
    public class DiamondObject : IAdaptee
    {
        public DiamondObject()
        {
        }

        public void Operation()
        {
            Console.WriteLine($"My {nameof(DiamondObject)} with interface {nameof(IAdaptee)} implemented and running.");
        }
    }

    ///////////////////////////////////////////////////////////////////////

    /// <summary>
    /// implement object << Object3D >> width interface << IAdaptee >>
    /// </summary>

    public class AdapteeObject3D : IAdaptee
    {
        private readonly Object3D _object3D;

        public AdapteeObject3D
        (
          
        ) {
            _object3D = new Object3D();
        }

        public void Operation()
        {
            _object3D.RenderObject();
        }
    }

    ///////////////////////////////////////////////////////////////////////

    /// <summary>
    /// This object has exsample dll exterior
    /// </summary>

    public class Object3D
    {
        public Object3D()
        {
        }

        public void RenderObject()
        {
            Console.WriteLine($"DLL {nameof(Object3D)} with interface {nameof(IAdaptee)} and width desgin pattern Adaptee implemented and running.");

        }
    }
}
