using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Id_1284997__LINQ_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var Categories = new Category[]
                {
                new Category {CategoryId=1,CategoryName="Shirt"},
                new Category{CategoryId=2,CategoryName="Pant"}


                
                };
            var models = new ProductModel[]
                { 
                new ProductModel {ModelId=1,ModelName="Man's Shirt"},
                new ProductModel{ ModelId=2,ModelName="Women's Shirt"}
                
                };
            var products = new Product[]
                {
                new Product {ProductID=1,ProductName="Polo Shirt",Quantity=2,Color="Blue",CategoryID=2,ModelId=1},
               new Product {ProductID=2,ProductName="T Shirt",Quantity=10,Color="Red",CategoryID=2,ModelId=2}


                };
            //var garments = from p in products
            //               join c in Categories
            //               on p.CategoryID equals c.CategoryId
            //               join m in models
            //               on p.ModelId equals m.ModelId
            //               select new { Product = p.ProductID, c.CategoryName, Module = m.ModelName, p.ProductName, p.Color, p.Quantity };
            //foreach (var x in garments)
            //{
            //    Console.WriteLine($"{x.ProductName}\t{x.Module}\t{x.Color}\t{x.Quantity}");
            //}
            //Select productname show in output
            //var pr = from p in products

            //         select p.ProductName;
            //foreach (var ProductName in pr)
            //{
            //    Console.WriteLine(ProductName);
            //}
            //Using order by Desc
            //var cat = from p in products
            //          orderby p.ProductName descending
            //          select p.ProductName;
            //foreach (var ProductName in cat)

            //{
            //    Console.WriteLine(ProductName);
            //}
            var cat = from p in products
                      where p.Quantity>5 //Using Where
                      orderby p.ProductName descending
                      select p.ProductName;
            foreach (var ProductName in cat)

            {
                Console.WriteLine(ProductName);
            }

            Console.ReadKey();

        }
    }
}
