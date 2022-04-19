using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary.Business
{
    abstract public class Discount
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public int CalculatedDiscount { get; set; }

        public abstract int CalculateDiscount(int numberOfReviews);

        public override string ToString()
        {
            return $"{this.Name}";
        }



    }
}
