using MyGameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyGameDemo.Abstract
{
    interface IUserService
    {
        void Add(User user);
        void Update(User user);
        void Delete(User user);

    }
}
