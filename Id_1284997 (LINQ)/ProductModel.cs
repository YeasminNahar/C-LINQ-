using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Id_1284997__LINQ_
{
    public class ProductModel
    {
        public int ModelId { get; set; }
        public string ModelName { get; set; }
        public virtual ICollection<Product> Products { get; set; }
        public ProductModel()
        {
            Products = new HashSet<Product>();
        }
        public ProductModel(int modelId, string modelName) : this()
        {
            ModelId = modelId;
            ModelName = modelName;
        }
    }
}
