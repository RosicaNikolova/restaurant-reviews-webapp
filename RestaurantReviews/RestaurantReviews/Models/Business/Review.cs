using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantReviews.Models
{

    public class Review
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Comment { get; set; }
        public double FoodScore { get; set; }
        public double ServiceScore { get; set; }
        public double PriceScore { get; set; }
        public string RestaurantName { get; set; }
        public string AuthorFirstName { get; set; }
        public string AuthorLastName { get; set; }


        public override string ToString()
        {
            return $"Restaurant: {this.RestaurantName}, Author: {this.AuthorFirstName} {this.AuthorLastName}, " +
                $"Date: {this.Date} {Environment.NewLine} Rating: Food: {this.FoodScore}, Service: {this.ServiceScore}, Price: {this.PriceScore} {Environment.NewLine}" +
                $"Comment: {this.Comment}";
        }
    }
}
