using System;
using System.Collections.Generic;
using System.Text;

namespace Rentacar_DataAccess.Repository.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        ICarRepository Car { get;}
        IBrandRepository Brand { get; }

        void Save();
    }
}
