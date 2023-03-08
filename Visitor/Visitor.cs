namespace DeginPaterrn.Visitor
{
    public interface IVisitor
    {
        void VisitSnappFoodElement(ISnappFoodElement snappFoodElement);
        void VisitSnappBoxElement(ISnappBoxElement snappFoodElement);
        void VisitSnappMarketElement(ISnappMarketElement snappFoodElement);
    }

    public class VisitorReport : IVisitor
    {
        public VisitorReport()
        {
        }

        public void VisitSnappBoxElement(ISnappBoxElement snappFoodElement)
        {
            Console.WriteLine($"Visitor => {nameof(VisitorReport)} , Implemantion => {nameof(snappFoodElement)}  --- Name: {snappFoodElement.GetBoxName()} , Price: ${snappFoodElement.GetBoxPrice()}");
        }

        public void VisitSnappFoodElement(ISnappFoodElement snappFoodElement)
        {
            Console.WriteLine($"Visitor => {nameof(VisitorReport)} , Implemantion => {nameof(snappFoodElement)}  --- Name: {snappFoodElement.GetFoodName()} , Price: ${snappFoodElement.GetFoodPrice()}");
        }

        public void VisitSnappMarketElement(ISnappMarketElement snappMarketElement)
        {
            Console.WriteLine($"Visitor => {nameof(VisitorReport)} , Implemantion => {nameof(snappMarketElement)}  --- Name: {snappMarketElement.GetMarketName()} , Price: ${snappMarketElement.GetMarketPrice()}");
        }
    }

    public class VisitorInformation : IVisitor
    {
        public VisitorInformation()
        {
        }

        public void VisitSnappBoxElement(ISnappBoxElement snappFoodElement) =>
            snappFoodElement.GetBoxInformation();

        public void VisitSnappFoodElement(ISnappFoodElement snappFoodElement) =>
            snappFoodElement.GetFoodInformation();

        public void VisitSnappMarketElement(ISnappMarketElement snappMarketElement) =>
            snappMarketElement.GetMarketInformation();
    }
}
