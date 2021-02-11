using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace resturants.Models
{
    public static class TempStorage
    {
        private static List<UserRestaurants> userRests = new List<UserRestaurants>();

        public static IEnumerable<UserRestaurants> Applications => userRests;

        public static void AddApplication(UserRestaurants application)
        {
            userRests.Add(application);
        }
    }
}
