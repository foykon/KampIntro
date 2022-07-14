using MyGameDemo.Abstract;
using MyGameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyGameDemo.Concrete
{
    class SaleManager : ISaleService
    {
        List<Bill> bills = new List<Bill>();
        
        public void CreateBill(Game game, User user)
        {
            Bill bill = new Bill();
            bill.GameName = game.Name;
            bill.UserName = user.FirstName;
            bill.Total = game.Price;

            bills.Add(bill);

            Console.WriteLine(bill.GameName + " Has Been Added Into " + bill.UserName + " s Library !");
            Console.WriteLine("Discount : "+bill.Total);
        }
        


    }
}
