using MyGameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyGameDemo.Abstract
{
    interface ISaleService
    {
        void CreateBill(Game game,User user);

    }
}
