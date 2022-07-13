using CoffeeShopSim.Abstract;
using CoffeeShopSim.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShopSim.Concrete
{
    class StarbucksCustomerManager : BaseCustomerManager
    {
        private IPersonCheckService _personCheckService;

        public StarbucksCustomerManager(IPersonCheckService personCheckService)
        {
            _personCheckService = personCheckService;
        }

        public override void Save(Customer customer)
        {
            if (_personCheckService.CheckIfRealPerson(customer))
            {
                base.Save(customer);
            }
            else
            {
                throw new Exception("not a valid person");
            }
            
        }

        
    }
}
