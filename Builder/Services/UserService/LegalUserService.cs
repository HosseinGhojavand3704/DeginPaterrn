namespace DeginPaterrn.Builder.Services.UserService
{
    public class LegalUserService : IUserService
    {
        public LegalUserService()
        {
        }

        public string Firstname { get; set; } = "Not Value Property";
        public string Lastname { get; set; } = "Not Value Property";
        public int Age { get; set; }
        public string City { get; set; } = "Not Value Property";
        public int Phone { get; set; }

        public void DisplyInfo()
        {
            Console.WriteLine($"{nameof(LegalUserService)} => {nameof(IUserService.Firstname)}:{Firstname}");
            Console.WriteLine($"{nameof(LegalUserService)} => {nameof(IUserService.Lastname)}:{Lastname}");
            Console.WriteLine($"{nameof(LegalUserService)} => {nameof(IUserService.Age)}:{Age}");
            Console.WriteLine($"{nameof(LegalUserService)} => {nameof(IUserService.City)}:{City}");
            Console.WriteLine($"{nameof(LegalUserService)} => {nameof(IUserService.Phone)}:{Phone}");
        }
    }
}
