using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ClassLibrary.Business
{

    public class Review
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }

        [DataType(DataType.Text)]
        public string Comment { get; set; }

        [Required]
        public double FoodScore { get; set; }
        [Required]
        public double ServiceScore { get; set; }
        [Required]
        public double PriceScore { get; set; }
        [Required]
        public string RestaurantName { get; set; }
        public string AuthorFirstName { get; set; }
        public string AuthorLastName { get; set; }
        public int AuthorId { get; set; }
        public override string ToString()
        {
            return $"Restaurant: {this.RestaurantName}, Author: {this.AuthorFirstName} {this.AuthorLastName}, " +
                $"Date: {this.Date} {Environment.NewLine} Rating: Food: {this.FoodScore}, Service: {this.ServiceScore}, Price: {this.PriceScore} {Environment.NewLine}" +
                $"Comment: {this.Comment}";
        }

        public Review()
        {
                
        }
    }
}
