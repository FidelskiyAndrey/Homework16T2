using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;

namespace Homework16T2
{
    class Program
    {
        static void Main(string[] args)
        {
            System.IO.StreamReader f = new StreamReader(@"C:\Users\andrey\Serialize.json");
            string jsonproduct = f.ReadToEnd();


            Product[] products = JsonSerializer.Deserialize<Product[]>(jsonproduct);
            
            
            double maxprice = 0;
           
            foreach (var product in products)
            {
                maxprice =  product.Price > maxprice ? product.Price : maxprice;
            }

            Console.WriteLine(maxprice);
            Console.ReadKey();
        }
    }
    public class Product
    {

        public int Code { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }


        public Product(int code, string name, double price)
        {
            Code = code;
            Name = name;
            Price = price;
        }
    }



}
