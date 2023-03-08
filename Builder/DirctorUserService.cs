using DeginPaterrn.Builder.Services.UserService;

namespace DeginPaterrn.Builder
{
    public interface IDirctorUserService
    {
        IUserService GetLegalUser();
        IUserService GetRealUser();
        void SetFullLegalUserInformation(string firstname, string lastname, int age, string city, int phone);
        void SetFullRealUserInformation(string firstname, string lastname, int age, string city, int phone);
        void SetOutherLegalUserInformation(string city, int phone);
        void SetOutherRealUserInformation(string city, int phone);
        void SetSignificantLegalUserInformation(string firstname, string lastname, int age);
        void SetSignificantRealUserInformation(string firstname, string lastname, int age);
    }

    public class DirctorUserService: IDirctorUserService
    {
        private readonly BuilderRealUserService _builderRealUserService;
        private readonly BuilderLegalUserService _builderLegalUserService;

        public DirctorUserService()
        {
            _builderRealUserService = new BuilderRealUserService();
            _builderLegalUserService = new BuilderLegalUserService();
        }

        /// <summary>
        /// Dirctor RealUser
        /// </summary>

        public void SetSignificantRealUserInformation(string firstname, string lastname , int age)
        {
            _builderRealUserService.SetGeneralInformation(firstname , lastname);
            _builderRealUserService.SetFurtherInformation(age);
        }

        public void SetOutherRealUserInformation(string city , int phone)
        {
            _builderRealUserService.SetConactInformation(phone);
            _builderRealUserService.SetLocationInformation(city);
        }

        public void SetFullRealUserInformation(string firstname, string lastname, int age , string city, int phone)
        {
            SetSignificantRealUserInformation(firstname, lastname , age);
            SetOutherRealUserInformation(city , phone);
        }

        public IUserService GetRealUser() => _builderRealUserService.GetUserService();

        /// <summary>
        /// Dirctor LegalUser
        /// </summary>

        public void SetSignificantLegalUserInformation(string firstname, string lastname, int age)
        {
            _builderLegalUserService.SetGeneralInformation(firstname, lastname);
            _builderLegalUserService.SetFurtherInformation(age);
        }

        public void SetOutherLegalUserInformation(string city, int phone)
        {
            _builderLegalUserService.SetConactInformation(phone);
            _builderLegalUserService.SetLocationInformation(city);
        }

        public void SetFullLegalUserInformation(string firstname, string lastname, int age, string city, int phone)
        {
            SetSignificantLegalUserInformation(firstname, lastname, age);
            SetOutherLegalUserInformation(city, phone);
        }

        public IUserService GetLegalUser() => _builderLegalUserService.GetUserService();
    }
}
