using CoffeeShopSim.Abstract;
using CoffeeShopSim.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShopSim.Concrete
{
    class CustomerCheckManager : IPersonCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            return true;
        }
    }
}
