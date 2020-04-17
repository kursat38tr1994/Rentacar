using Rentacar_DataAccess.Data;
using Rentacar_DataAccess.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Rentacar_DataAccess.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _db;

        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
            Car = new CarRepository(_db);
            Brand = new BrandRepository(_db);
        }
        public ICarRepository Car { get; private set; }
        public IBrandRepository Brand { get; private set; }
        
        public void Dispose()
        {
            _db.Dispose();
        }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
