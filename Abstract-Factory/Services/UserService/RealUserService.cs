namespace DeginPaterrn.AbstractFactory.Services.UserService
{
    public class RealUserService : IUserService
    {
        public RealUserService()
        {
        }

        public void Excute()
        {
            Console.WriteLine($"Run Method Excute In The Service {nameof(RealUserService)}");
        }
    }
}
