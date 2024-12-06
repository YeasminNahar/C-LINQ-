using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Id_1284997__LINQ_
{
    public class Product
    {
        public int ProductID { get; set; }
        public int Quantity { get; set; }
        public String ProductName { get; set; }
        public String Color { get; set; }
        public int CategoryID { get; set; }
        public int ModelId { get; set; }
        public virtual Category Category { get; set; }
        public virtual ProductModel ProductModel { get; set; }
        public Product()
        { 
        }
        public Product(int productID, int quantity,string productName,string color,int categoryID,int modelId)
        {
            ProductID = productID;
            Quantity = quantity;
            ProductName = productName;
            Color = color;
            CategoryID = categoryID;
            ModelId = modelId;
        }
    }
    
}
