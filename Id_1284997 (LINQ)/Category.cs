using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Id_1284997__LINQ_
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public virtual ICollection<Product> Products { get; set; }
        public Category()
        {
            Products = new HashSet<Product>();
        }
        public Category (int categoryId, string categoryName) :this()
        {
            CategoryId = categoryId;
            CategoryName = categoryName;
        }
    }
}
