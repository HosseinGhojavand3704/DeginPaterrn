using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeginPaterrn.Prototype
{
    public interface IPrototype
    {
        IPrototype ShallowClone();
        IPrototype DeepClone();
    }

    public class SampleObjectClone : IPrototype
    {
        private Object2 _object2;
        private Object3 _object3;

        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public int Age { get; set; }


        public SampleObjectClone
        (
            
        ) {
            _object2 = new Object2();
            _object3 = new Object3();
        }

        public IPrototype DeepClone()
        {
            SampleObjectClone resultObject = (SampleObjectClone)this.ShallowClone();

            resultObject._object2 = (Object2)_object2.ShallowClone();
            resultObject._object3 = (Object3)_object3.ShallowClone();

            return (IPrototype)resultObject;
        }

        public IPrototype ShallowClone()
        {
            return (IPrototype)this.MemberwiseClone();
        }
    }

    public class Object2 : IPrototype
    {
        public Object2()
        {
        }

        public IPrototype DeepClone()
        {
            throw new NotImplementedException();
        }

        public IPrototype ShallowClone()
        {
            return (IPrototype)this.MemberwiseClone();
        }
    }

    public class Object3 : IPrototype
    {
        public Object3()
        {
        }

        public IPrototype DeepClone()
        {
            throw new NotImplementedException();
        }

        public IPrototype ShallowClone()
        {
            return (IPrototype)this.MemberwiseClone();
        }
    }}
