namespace DeginPaterrn.AbstractFactory.Services.UserService
{
    public class LegalUserService : IUserService
    {
        public LegalUserService()
        {
        }

        public void Excute()
        {
            Console.WriteLine($"Run Method Excute In The Service {nameof(LegalUserService)}");
        }
    }
}
