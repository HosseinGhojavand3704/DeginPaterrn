namespace DeginPaterrn.AbstractFactory.Services.CatecoryService
{
    public class LeftCatecoryService : ICatecoryService
    {
        public LeftCatecoryService()
        {
        }

        public void Excute()
        {
            Console.WriteLine($"Run Method Excute In The Service {nameof(LeftCatecoryService)}");
        }
    }
}
