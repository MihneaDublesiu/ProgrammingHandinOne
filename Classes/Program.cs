using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerRetrieval
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! Press any key to display the customer information.");
            Console.ReadKey();
            var customer = new Customer(); 
            customer.Name = "John Scarce";
            customer.Age = 25;
            customer.Zip = 4389;
            customer.Password = "thisisthepassword";
            Console.WriteLine(customer.ToString());
            

        }
              
    }
}


