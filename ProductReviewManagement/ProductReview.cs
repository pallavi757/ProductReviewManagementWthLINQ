using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductReviewManagement
{
    public class ProductReview
    {
        //property
        public int ProductID { get; set; }
        public int UserID { get; set; }
        public int Rating { get; set; }
        public string? Review { get; set; }
        public bool isLike { get; set; }

        ///<summary>Performs an explicit conversion from <see cref="DataRow" /> to <see cref="ProductReview" />.</summary>
        /// <param name="v">The v.</param>
        /// <returns>The result of the conversion.</returns>
        public static explicit operator ProductReview(DataRow v)
        {
            return new ProductReview
            {
                ProductID = v.Field<int>("ProductId"),
                UserID = v.Field<int>("UserId"),
                Rating = v.Field<int>("Rating"),
                Review = v.Field<string>("Review"),
                isLike = v.Field<bool>("IsLike")
            };
        }
    }
}
