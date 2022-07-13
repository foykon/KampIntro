using CoffeeShopSim.Abstract;
using CoffeeShopSim.Adapters;
using CoffeeShopSim.Concrete;
using CoffeeShopSim.Entities;
using System;

namespace CoffeeShopSim
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new StarbucksCustomerManager(new MernisServiceAdapter());
            customerManager.Save(new Customer
            {
                DateYear = 200,
                FirstName = "Furkan",
                LastName = "Yıldız",
                NationalityId = "12809486862"
            });

        
        
        
        
        }
    }
}
