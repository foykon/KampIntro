using CoffeeShopSim.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShopSim.Abstract
{
    public abstract class BaseCustomerManager : ICustomerService
    {
        public virtual void Save(Customer customer)
        {
            Console.WriteLine("Saved to database : " + customer.FirstName); ;
        }
    }
}
