using System.Reflection;
using System.Runtime.Serialization;

namespace DeginPaterrn.Flyweight
{
    /// <summary>
    /// Add Classes Object Concrete Flyweight
    /// </summary>
    public class SoliderConcreteFlyweight : IFlyweight
    {

        private readonly string _internalState;

        public SoliderConcreteFlyweight
        (
            string internalState
        ) {
            _internalState = internalState;
        }

        public void Operation()
        {
            Console.WriteLine(_internalState);
        }
    }

    public class ArrowConcreteFlyweight : IFlyweight
    {
        private readonly string _internalState;

        public ArrowConcreteFlyweight
        (
            string internalState
        )
        {
            _internalState = internalState;
        }

        public void Operation()
        {
            Console.WriteLine(_internalState);
        }
    }


    /// <summary>
    /// Add Classes Flyweight
    /// </summary>
    public interface IFlyweight
    {
        public void Operation();
    }

    public class FlyweightFactory
    {
        private readonly IDictionary<string, IFlyweight> _cachedObjects;

        public FlyweightFactory
        (
            
        ) {
            _cachedObjects = new Dictionary<string, IFlyweight>();
        }


        public dynamic GetObject(string className , params object[] objectParams)
        {
            IFlyweight? flyweight;

            if (_cachedObjects.TryGetValue(className, out flyweight)) { }
            else
            {
                Type? typeClassName = Type.GetType(string.Format($"DeginPaterrn.Flyweight.{className}"));

                if (typeClassName != null)
                {
                    Type[] classNameInterfaces = typeClassName.GetInterfaces();

                    if (!classNameInterfaces.Contains(typeof(IFlyweight)))
                        throw new Exception("class type not suported");

                    var targetConstructor = typeClassName.GetConstructors().First();
                    IList<object?> parameters = targetConstructor.GetParameters().Select(info => GetDefault(info.ParameterType)).ToList();

                    for (var i = 0; i < objectParams.Length ; i++)
                        parameters[i] = objectParams[i];

                    object? createdTypeClass = Activator.CreateInstance(typeClassName , parameters.ToArray());

                    if (createdTypeClass != null)
                    {
                        object? classFlyweight = Convert.ChangeType(createdTypeClass, typeClassName);
                        if (classFlyweight != null)
                            _cachedObjects.Add(className, (IFlyweight)classFlyweight);
                        else
                            throw new Exception("class type not create instance");
                    }
                    else
                        throw new Exception("class type not create instance");
                }
                else
                    throw new Exception("class type not found");
            }

            return _cachedObjects[className];
        }

        public object? GetDefault(Type type)
        {
            if (type.IsValueType)
                return Activator.CreateInstance(type);
            return null;
        }
    }

    /// <summary>
    /// Add Paterrn Composite In The Flyweight
    /// </summary>

    public class UnsheardFlyweight
    {

        private readonly IEnumerable<IFlyweight> _soliderFlyweights;

        public UnsheardFlyweight
        (
            IEnumerable<IFlyweight> soliderFlyweights
        ) {
            _soliderFlyweights = soliderFlyweights;
        }

        public void Operation()
        {
            foreach (IFlyweight soliderFlyweight in _soliderFlyweights)
                soliderFlyweight.Operation();
        }
    }

}
