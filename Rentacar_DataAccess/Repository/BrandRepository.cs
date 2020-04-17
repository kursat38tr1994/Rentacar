using Rentacar_DataAccess.Data;
using Rentacar_DataAccess.Repository.IRepository;
using Rentacar_Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Rentacar_DataAccess.Repository
{
    public class BrandRepository : Repository<IBrand>, IBrandRepository
    {
        private readonly ApplicationDbContext _db;
        public BrandRepository(ApplicationDbContext db) : base (db)
        {
            _db = db;
        }
        public void Update(IBrand brand)
        {
            //var objFromDb = _db.Bra.FirstOrDefault(s => s.Id == coverType.Id);
            //if (objFromDb != null)
            //{
            //    objFromDb.Name = coverType.Name;

            //}
        }
    }
}
