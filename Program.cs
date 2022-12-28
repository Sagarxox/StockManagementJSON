using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace JSONInventory
{
   

    namespace JsonExample
    {
        class Program
        {
            static void Main(string[] args)
            {
                // Parse the JSON string
                string json = "{\"products\":[{\"id\":1,\"name\":\"Product 1\",\"price\":9.99,\"quantity\":10},{\"id\":2,\"name\":\"Product 2\",\"price\":19.99,\"quantity\":5},{\"id\":3,\"name\":\"Product 3\",\"price\":29.99,\"quantity\":2}]}";
                Inventory inventory = JsonConvert.DeserializeObject<Inventory>(json);

                // Print the data to the console
                foreach (Product product in inventory.products)
                {
                    Console.WriteLine("ID: {0}", product.id);
                    Console.WriteLine("Name: {0}", product.name);
                    Console.WriteLine("Price: {0}", product.price);
                    Console.WriteLine("Quantity: {0}", product.quantity);
                }
            }
        }

        public class Inventory
        {
            public List<Product> products { get; set; }
        }

        public class Product
        {
            public int id { get; set; }
            public string name { get; set; }
            public decimal price { get; set; }
            public int quantity { get; set; }
        }
    }

}
