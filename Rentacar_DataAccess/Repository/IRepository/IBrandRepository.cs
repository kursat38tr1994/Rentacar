using Rentacar_Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Rentacar_DataAccess.Repository.IRepository
{
   public interface IBrandRepository : IRepository<IBrand>
    {
        void Update(IBrand brand);
    }
}
