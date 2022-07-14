using MyGameDemo.Abstract;
using MyGameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyGameDemo.Adapters
{
    class MernisServiceAdapter : IUserCheckService
    {
        public bool IsUserReal(User user)
        {
            //yazılcak
            return false;
        }
    }
}
