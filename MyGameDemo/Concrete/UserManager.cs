using MyGameDemo.Abstract;
using MyGameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyGameDemo.Concrete
{
    class UserManager : IUserService
    {
        IUserCheckService _userCheckService;

        public UserManager(IUserCheckService userCheckService)
        {
            _userCheckService = userCheckService;
        }


        List<User> users = new List<User>();
        
        public void Add(User user)
        {
            if (_userCheckService.IsUserReal(user))
            {
                users.Add(user);
                Console.WriteLine("User " + user.FirstName + " has been added successfully !");
            }
            else
            {
                Console.WriteLine("User " + user.FirstName + " could not be added in system !");
            }
        }

        public void Delete(User user)
        {
            users.Remove(user);
            Console.WriteLine("User " + user.FirstName + " has been deleted successfully !");
        }

        public void Update(User user)
        {
            Console.WriteLine("User " + user.FirstName + " has been updated successfully !");
        }

    }
}
