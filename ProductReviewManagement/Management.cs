using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductReviewManagement
{
     public class Management
    {
        // Create a table with a schema that matches that of the query results
        public readonly DataTable dataTable = new DataTable();
        public void TopRecords(List<ProductReview> listProductReview)
        {
            // Query for Retrieve top 3 records from the list who’s rating is high using LINQ
            var recordedData = (from productReviews in listProductReview
                                orderby productReviews.Rating descending
                                select productReviews).Take(3);
            // If you need the results to be in a DataTable
            foreach (var list in recordedData)
            {
                Console.WriteLine("ProductID:" + list.ProductID + " " + "UserID: " + list.UserID
                    + " " + "Rating: " + list.Rating + " " + "Review: " + list.Review + " " + "isLike: " + list.isLike);
                Console.WriteLine("-------------------------------------------------------------");
            }
        }
    }
}
