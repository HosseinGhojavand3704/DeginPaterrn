namespace DeginPaterrn.Builder.Services.UserService
{
    public interface IUserService
    {
        string Firstname { get; set; }
        string Lastname { get; set; }
        int Age { get; set; }
        string City { get; set; }
        int Phone { get; set; }
        void DisplyInfo();
    }
}
