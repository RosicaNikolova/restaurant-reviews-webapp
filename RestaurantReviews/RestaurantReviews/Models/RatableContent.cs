using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantReviews.Models
{
    public abstract class RatableContent
    {
        public int Id { get; set; }
        public double Score { get; set; }
        public double PriceRange { get; set; }
        public double Service { get; set; }
        public bool isActive { get; set; }
        public List<string>Characteristics { get; set; }
    }
}
