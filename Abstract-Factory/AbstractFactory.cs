using DeginPaterrn.AbstractFactory.Services.CatecoryService;
using DeginPaterrn.AbstractFactory.Services.UserService;

namespace DeginPaterrn.AbstractFactory
{

    public enum CatecoryServiceType
    {
        CompositeCatecoryService,
        LeftCatecoryService
    }

    public enum UserServiceType
    {
        RealUserService,
        LegalUserService
    }

    public class AbstractFactory
    {
        private readonly static AbstractFactory _instance = new AbstractFactory();
        private AbstractFactory()
        {
        }

        public static AbstractFactory GetInstance() => _instance;

        public static ICatecoryService CreateCatecoryService(CatecoryServiceType? catecoryServiceType = CatecoryServiceType.CompositeCatecoryService)
        {
            ICatecoryService catecoryService = new CompositeCatecoryService();

            if (catecoryServiceType != null)
            {
                switch (catecoryServiceType)
                {
                    case CatecoryServiceType.CompositeCatecoryService:
                        catecoryService = new CompositeCatecoryService();
                        break;
                    case CatecoryServiceType.LeftCatecoryService:
                        catecoryService = new LeftCatecoryService();
                        break;
                }
            }

            return catecoryService;
        }

        public static IUserService CreateUserService(UserServiceType? userServiceType = UserServiceType.RealUserService)
        {
            IUserService userService = new RealUserService();

            if (userServiceType != null)
            {
                switch (userServiceType)
                {
                    case UserServiceType.RealUserService:
                        userService = new RealUserService();
                        break;
                    case UserServiceType.LegalUserService:
                        userService = new LegalUserService();
                        break;
                }
            }

            return userService;
        }
    }
}