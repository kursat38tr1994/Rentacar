using System;
using System.Collections.Generic;
using System.Text;
using Rentacar_Models;

namespace Rentacar_DataAccess.Repository.IRepository
{
    public interface ICarRepository : IRepository<ICar>
    {
        void update(ICar car);
    }
}
