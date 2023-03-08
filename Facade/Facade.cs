using DeginPaterrn.Facade.SubSystems;

namespace DeginPaterrn.Facade
{
    public static class Facade
    {

        private static readonly SubSystemOne _subSystemOne;
        private static readonly SubSystemTwo _subSystemTwo;
        private static readonly SubSystemThree _subSystemThree;

        static Facade
        (
        ) {
            _subSystemOne = new SubSystemOne();
            _subSystemTwo = new SubSystemTwo();
            _subSystemThree = new SubSystemThree();
        }

        public static void RigesterUser()
        {
            Console.WriteLine("Logger .................. Starting Facade RigesterUser.");
            _subSystemOne.ValidateRigesterUser();
            _subSystemTwo.WebServiceBankMeli();
            _subSystemThree.RigesterUserSaveChange();
            Console.WriteLine("Logger .................. End Of Facade RigesterUser.");
        }
    }
}
