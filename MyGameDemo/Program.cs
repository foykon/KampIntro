using MyGameDemo.Adapters;
using MyGameDemo.Concrete;
using MyGameDemo.Entities;
using System;

namespace MyGameDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            User user1 = new User() { Id = 1, FirstName = "Furkan", LastName = "Yıldız", BirthYear = 2002, Tc = "12809486862" };
            UserManager userManager = new UserManager(new MernisServiceAdapter());
            userManager.Add(user1);
            userManager.Update(user1);
            userManager.Delete(user1);

            Game game1 = new Game() { Id = 1, Name = "CS:GO", Price = 150 };
            GameManager gameManager = new GameManager();
            gameManager.Add(game1);
            gameManager.Update(game1);
            gameManager.Delete(game1);

            SaleManager saleManager = new SaleManager();
            saleManager.CreateBill(game1, user1);
            

        }
    }
}
