using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine("Customer information added successfully !" + customer.CustomerID);
        }

        public void Delete(Customer customer)
        {
            Console.WriteLine("Customer information deleted ! " + customer.CustomerID);
        }


        public void List(int customerId, string customerName, string customerSurname)
        {
            Console.WriteLine("Customer information listed!" + " " + customerId + " " + customerName + " " + customerSurname);

        }

    }
}
