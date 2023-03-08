namespace DeginPaterrn.Visitor
{
    public interface ISnapp
    {
        void Accept(IVisitor visitor);
    }


    /// <summary>
    /// SnappFoodElement
    /// </summary>
    public interface ISnappFoodElement
    {
        void GetFoodInformation();
        string GetFoodName();
        string GetFoodPrice();
    }

    public class SnappFoodElement : ISnapp, ISnappFoodElement
    {
        private readonly string _foodName;
        private readonly string _foodPrice;

        public SnappFoodElement
        (
            string foodName,
            string foodPrice
        ) {
            _foodName = foodName;
            _foodPrice = foodPrice;
        }

        public string GetFoodName() => _foodName;
        public string GetFoodPrice() => _foodPrice;

        public void GetFoodInformation()
        {
            Console.WriteLine($"This Is Class {nameof(SnappFoodElement)}");
        }

        public void Accept(IVisitor visitor)
        {
            visitor.VisitSnappFoodElement(this);
        }
    }

    /// <summary>
    /// SnappBoxElement
    /// </summary>
    public interface ISnappBoxElement
    {
        void GetBoxInformation();
        string GetBoxName();
        string GetBoxPrice();
    }

    public class SnappBoxElement : ISnapp, ISnappBoxElement
    {
        private readonly string _foodName;
        private readonly string _foodPrice;

        public SnappBoxElement
        (
            string foodName,
            string foodPrice
        )
        {
            _foodName = foodName;
            _foodPrice = foodPrice;
        }

        public string GetBoxName() => _foodName;
        public string GetBoxPrice() => _foodPrice;

        public void GetBoxInformation()
        {
            Console.WriteLine($"This Is Class {nameof(SnappBoxElement)}");
        }

        public void Accept(IVisitor visitor)
        {
            visitor.VisitSnappBoxElement(this);
        }
    }


    /// <summary>
    /// SnappMarketElement
    /// </summary>
    public interface ISnappMarketElement
    {
        void GetMarketInformation();
        string GetMarketName();
        string GetMarketPrice();
    }

    public class SnappMarketElement : ISnapp, ISnappMarketElement
    {
        private readonly string _foodName;
        private readonly string _foodPrice;

        public SnappMarketElement
        (
            string foodName,
            string foodPrice
        )
        {
            _foodName = foodName;
            _foodPrice = foodPrice;
        }

        public string GetMarketName() => _foodName;
        public string GetMarketPrice() => _foodPrice;

        public void GetMarketInformation()
        {
            Console.WriteLine($"This Is Class {nameof(SnappMarketElement)}");
        }

        public void Accept(IVisitor visitor)
        {
            visitor.VisitSnappMarketElement(this);
        }
    }
}
