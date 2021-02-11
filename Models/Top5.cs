using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace resturants.Models
{
    public class Top5
    {

        public Top5(int rank)
        {
            Rank = rank;
        }

        [Required]
        public int Rank { get; }

        [Required]
        public string RestaurantName { get; set; }

        public string? FavDish { get; set; } = "It's all tasty!";

        [Required]
        public string Address { get; set; }

        [Required]
        public string PhoneNum { get; set; }

        public string? Website { get; set; } = "Coming soon.";

        
        public static Top5[] GetRestaraunts()
        {
            Top5 top1 = new Top5(1)
            {
                RestaurantName = "Asa Ramen",
                FavDish = "Tonkatsu Miso Blend",
                Address = "1120 State St, Orem, UT 84097",
                PhoneNum = "(801) 842-1898",

            };

            Top5 top2 = new Top5(2)
            {
                RestaurantName = "Bombay House",
                FavDish = "Lamb Briyani",
                Address = "463 N University Ave, Provo, UT 84601",
                PhoneNum = "(801) 373-6677",
                Website = "https://bombayhouse.com/"

            };

            Top5 top3 = new Top5(3)
            {
                RestaurantName = "Chom Burger",
                FavDish = "Pastrami Swiss Mushroom Burger",
                Address = "45 300 N, Provo, UT 84601",
                PhoneNum = "(385) 241-7499",
                Website = "http://chomburger.com/"

            };

            Top5 top4 = new Top5(4)
            {
                RestaurantName = "Don Joaquin Street Tacos",
                FavDish = "Literally any Taco",
                Address = "150 W 1230 N St, Provo, UT 84604",
                PhoneNum = "(801) 400-2894",
                Website = "https://stdonjoaquin.com/"

            };

            Top5 top5 = new Top5(5)
            {
                RestaurantName = "Cubby's",
                FavDish = "Buffalo Blue Cheese Fries",
                Address = "1258 N State St, Provo, UT 84604",
                PhoneNum = "(801) 919-3023",
                Website = "http://cubbys.co/"

            };

            return new Top5[] { top1, top2, top3, top4, top5 };
        }
    }
}
