using CoffeeShopSim.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShopSim.Abstract
{
    interface IPersonCheckService
    {
        bool CheckIfRealPerson(Customer customer);

    }
}
