namespace DeginPaterrn.AbstractFactory.Services.CatecoryService
{
    public class CompositeCatecoryService : ICatecoryService
    {
        public CompositeCatecoryService()
        {
        }

        public void Excute()
        {
            Console.WriteLine($"Run Method Excute In The Service {nameof(CompositeCatecoryService)}");
        }
    }
}
