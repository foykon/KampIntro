using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int customerId = 1;
            string customerName = "Emine";
            string customerSurname = "Zeyrek";
            string adress = "İstanbul";
            int phoneNumber = 11111111;

            string[] customers = new string[] { };


            Customer customer1 = new Customer(); //class
            customer1.CustomerID = 1;
            customer1.CustomerName = "Emine";
            customer1.CustomerSurname = "Zeyrek";
            customer1.Address = "İstanbul";
            customer1.PhoneNumber = 11111111;


            Customer customer2 = new Customer();
            customer2.CustomerID = 2;
            customer2.CustomerName = "Ayşe";
            customer2.CustomerSurname = "Bakır";
            customer2.Address = "İstanbul";
            customer2.PhoneNumber = 22222222;

            Customer customer3 = new Customer();
            customer3.CustomerID = 3;
            customer3.CustomerName = "Can";
            customer3.CustomerSurname = "Barut";
            customer3.Address = "Çanakkale";
            customer3.PhoneNumber = 33333333;


            Customer customer4 = new Customer();
            customer3.CustomerID = 4;
            customer3.CustomerName = "Kamil";
            customer3.CustomerSurname = "Gezer";
            customer3.Address = "Bilecik";
            customer3.PhoneNumber = 44444444;




            Customer[] customer = new Customer[] { customer1, customer2, customer3, customer4 };

            foreach (var Customer in customer)
            {
                Console.WriteLine(Customer.CustomerID);
                Console.WriteLine(Customer.CustomerName);
                Console.WriteLine(Customer.CustomerSurname);
                Console.WriteLine(Customer.Address);
                Console.WriteLine(Customer.PhoneNumber);
                Console.WriteLine("-------------------");


            }


            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer2);
            customerManager.Delete(customer3);



            customerManager.List(1, "Emine ", "Zeyrek");
            customerManager.List(2, "Ayşe", "Bakır");
            customerManager.List(3, "Can ", "Barut");
            customerManager.List(4, "Kamil ", "Gezer");

        }
    }
}
