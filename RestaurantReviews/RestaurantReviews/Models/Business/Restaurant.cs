using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantReviews.Models
{
    public class Restaurant
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string PostCode { get; set; }
        public int StreetNumber { get; set; }
        public string PhoneNumber { get; set; }
        public string HasParking { get; set; }
        public string HasDelivery { get; set; }
        public double Food_Score { get; set; }
        public double Service_Score { get; set; }
        public double Price_Score { get; set; }
        public int NumberOfReviews { get; set; }

        public override string ToString()
        {
            return $"{this.Name}, Address: {this.City}, {this.Street} {this.StreetNumber}, {this.PostCode}";
        }
    }

  
}
