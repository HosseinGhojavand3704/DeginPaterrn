using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeginPaterrn.Strategy
{

    /// <summary>
    /// Algorithms Strategy
    /// </summary>
    public interface IStrategy
    {
        void ImplementationAlgorithm();
    }

    public class SortAlgorithmById : IStrategy
    {
        public SortAlgorithmById()
        {
        }

        public void ImplementationAlgorithm()
        {
            Console.WriteLine($"------ Implementation Algorithm By Id ------");
        }
    }

    public class SortAlgorithmByPrice : IStrategy
    {
        public SortAlgorithmByPrice()
        {
        }

        public void ImplementationAlgorithm()
        {
            Console.WriteLine($"------ Implementation Algorithm By Price ------");
        }
    }

    /// <summary>
    /// Use Strategy In The Client
    /// </summary>
    /// 
    public interface IContect
    {
        void SortData();
    }

    public class Contect: IContect
    {
        private readonly IStrategy _strategy;

        public Contect
        (
            IStrategy strategy
        ) {
            _strategy = strategy;
        }

        public void SortData()
        {
            _strategy.ImplementationAlgorithm();
        }
    }
}
