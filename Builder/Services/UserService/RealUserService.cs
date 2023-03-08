namespace DeginPaterrn.Builder.Services.UserService
{
    public class RealUserService : IUserService
    {
        public RealUserService()
        {
        }

        public string Firstname { get; set; } = "Not Value Property";
        public string Lastname { get; set; } = "Not Value Property";
        public int Age { get; set; }
        public string City { get; set; } = "Not Value Property";
        public int Phone { get; set; }

        public void DisplyInfo()
        {
            Console.WriteLine($"{nameof(RealUserService)} => {nameof(IUserService.Firstname)}:{Firstname}");
            Console.WriteLine($"{nameof(RealUserService)} => {nameof(IUserService.Lastname)}:{Lastname}");
            Console.WriteLine($"{nameof(RealUserService)} => {nameof(IUserService.Age)}:{Age}");
            Console.WriteLine($"{nameof(RealUserService)} => {nameof(IUserService.City)}:{City}");
            Console.WriteLine($"{nameof(RealUserService)} => {nameof(IUserService.Phone)}:{Phone}");
        }
    }
}
