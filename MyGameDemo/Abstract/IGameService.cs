using MyGameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyGameDemo.Abstract
{
    interface IGameService
    {
        void Add(Game game);
        void Delete(Game game);
        void Update(Game game);


    }
}
