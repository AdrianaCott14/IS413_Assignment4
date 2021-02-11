using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace resturants.Models
{
    public class UserRestaurants
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string RestaurantName { get; set; }

        public string? favDish { get; set; } = "It's all tasty!";

        [Required, RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$")]
        public string PhoneNum { get; set; }


    }
}
