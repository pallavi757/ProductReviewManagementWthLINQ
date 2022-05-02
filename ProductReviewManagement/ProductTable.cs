using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductReviewManagement
{
    public class ProductTable
    {
        // Create a new DataTable.     
        public static DataTable table = new DataTable("productDataTable");
        public void CreateDataTable(List<ProductReview> products)
        {
            DataColumn[] columns = { new DataColumn { ColumnName  = "ProductId",DataType = typeof(int)},
                                 new DataColumn { ColumnName  = "UserId",DataType = typeof(int)},
                                 new DataColumn { ColumnName  = "Rating",DataType = typeof(int)},
                                 new DataColumn { ColumnName  = "Review",DataType = typeof(string)},
                                 new DataColumn { ColumnName  = "IsLike",DataType = typeof(bool)}
                                    };
            table.Columns.AddRange(columns);
            foreach (var product in products)
            {
             table.Rows.Add(new object[] { product.ProductID, product.UserID, product.Rating, product.Review, product.isLike });
            }
        }
        //Shows the table.
        public static void ShowTable()
        {
            foreach (DataColumn col in table.Columns)
            {
                Console.Write("{0,-14}", col.ColumnName);
            }
            Console.WriteLine();

            foreach (DataRow row in table.Rows)
            {
                foreach (DataColumn col in table.Columns)
                {
                    Console.Write("{0,-14}", row[col]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
