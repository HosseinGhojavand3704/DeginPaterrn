using DeginPaterrn.Builder.Services.UserService;
using System.Numerics;

namespace DeginPaterrn.Builder
{
    public abstract class BuilderUserService<T> where T: IUserService
    {
        public readonly IUserService _userService;
        public BuilderUserService()
        {
            _userService = (T) Activator.CreateInstance(typeof(T));
        }

        public abstract void SetGeneralInformation(string firstname, string lastname);
        public abstract void SetFurtherInformation(int age);
        public abstract void SetLocationInformation(string city);
        public abstract void SetConactInformation(int phone);
        public virtual IUserService GetUserService() => _userService;
    }

    public class BuilderRealUserService : BuilderUserService<RealUserService>
    {
        public BuilderRealUserService()
        {
        }

        public override void SetGeneralInformation(string firstname , string lastname)
        {
            _userService.Firstname = firstname;
            _userService.Lastname = lastname;
        }

        public override void SetFurtherInformation(int age)
        {
            _userService.Age = age;
        }

        public override void SetConactInformation(int phone)
        {
            _userService.Phone = phone;
        }

        public override void SetLocationInformation(string city)
        {
            _userService.City = city;
        }

        public override IUserService GetUserService()
        {
            return base.GetUserService();
        }
    }

    public class BuilderLegalUserService : BuilderUserService<LegalUserService>
    {
        public BuilderLegalUserService()
        {
        }

        public override void SetGeneralInformation(string firstname, string lastname)
        {
            _userService.Firstname = firstname;
            _userService.Lastname = lastname;
        }

        public override void SetFurtherInformation(int age)
        {
            _userService.Age = age;
        }

        public override void SetConactInformation(int phone)
        {
            _userService.Phone = phone;
        }

        public override void SetLocationInformation(string city)
        {
            _userService.City = city;
        }

        public override IUserService GetUserService()
        {
            return base.GetUserService();
        }
    }

}
