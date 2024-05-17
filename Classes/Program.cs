using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager(); // örnekleme yapma
            customerManager.Add();
            customerManager.Update();

            ProductManager productManager = new ProductManager();
            productManager.Add();
            productManager.Update();

            Console.ReadLine();

            Customer customer = new Customer();
            customer.ID = 1;
            customer.City = "Ankara";
            customer.FirstName = "Berkay";
            customer.LastName = "Şahin";

            Customer customer2 = new Customer
            {
                ID = 2,
                City = "Ankara",
                FirstName = "Berkayy",
                LastName = "Şahinn"
            };
            //pascal !
        }
    }
}
