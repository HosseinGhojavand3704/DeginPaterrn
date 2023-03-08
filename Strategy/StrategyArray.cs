using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DeginPaterrn.Strategy
{
    public class User
    {
        public int Id { get; set; }
        public string Firstname { get; set; } = string.Empty;
        public string Lastname { get; set; } = string.Empty;
        public int Age { get; set; }

        public void DisplayUser()
        {
            Console.WriteLine($"Id; {Id} Firstname: {Firstname}  LastName: {Lastname} Age:{Age}");
        }
    }

    public class SortUser : IComparer<User>
    {
        private readonly string _sortPropertyName;

        public SortUser
        (
            string sortPropertyName
        ) {
            _sortPropertyName = sortPropertyName;
        }

        public int Compare(User? x, User? y)
        {
            int result = -1;
            
            if (x != null && y != null)
            {
                PropertyInfo? propertyX = x.GetType().GetProperty(_sortPropertyName);
                PropertyInfo? propertyY = y.GetType().GetProperty(_sortPropertyName);

                if (propertyX != null && propertyY != null)
                {
                    object? propertyXValue = propertyX.GetValue(x);
                    object? propertyYValue = propertyY.GetValue(y);

                    if (propertyXValue == propertyYValue)
                        result = 0;
                    else if (propertyXValue is int && propertyYValue is int)
                    {
                        if ((int)propertyXValue > (int)propertyYValue)
                            result = 1;
                    }
                    else
                        result = -1;
                }
            }

            return result;
        }
    }

    public class StrategyArrayUsers
    {
        private readonly User[] _users;

        public StrategyArrayUsers()
        {
            _users = new User[]
            {
                new User() { Id = 1 , Firstname = "Firstname 1" , Lastname = "Lastname 1" , Age = 15 },
                new User() { Id = 2 , Firstname = "Firstname 2" , Lastname = "Lastname 2" , Age = 27 },
                new User() { Id = 3 , Firstname = "Firstname 3" , Lastname = "Lastname 3" , Age = 3 },
                new User() { Id = 4 , Firstname = "Firstname 4" , Lastname = "Lastname 4" , Age = 45 },
                new User() { Id = 5 , Firstname = "Firstname 5" , Lastname = "Lastname 5" , Age = 96 },
                new User() { Id = 6 , Firstname = "Firstname 6" , Lastname = "Lastname 6" , Age = 12 },
                new User() { Id = 7 , Firstname = "Firstname 7" , Lastname = "Lastname 7" , Age = 7 },
            };
        }

        public void Excte(string sortPropertyName)
        {
            Console.WriteLine("====================================================================================================");

            foreach (User user in _users)
                user.DisplayUser();

            IComparer<User> comparer = new SortUser(sortPropertyName);
            Array.Sort(_users , comparer);

            Console.WriteLine("====================================================================================================");

            foreach (User user in _users)
                user.DisplayUser();

            Console.WriteLine("====================================================================================================");
        }
    }
}
