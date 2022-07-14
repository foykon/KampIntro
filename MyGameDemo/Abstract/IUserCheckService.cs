using MyGameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyGameDemo.Abstract
{
    interface IUserCheckService
    {
        bool IsUserReal(User user);

    }
}
