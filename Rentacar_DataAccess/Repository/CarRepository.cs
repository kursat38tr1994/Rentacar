using Rentacar_DataAccess.Data;
using Rentacar_DataAccess.Repository.IRepository;
using Rentacar_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rentacar_DataAccess.Repository
{
    public class CarRepository : Repository<ICar>, ICarRepository
    {
        private readonly ApplicationDbContext _db;

        public CarRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
        public void update(ICar car)
        {
             var objFromDb = _db.Cars.FirstOrDefault(s => s.Id == car.Id);
            if (objFromDb != null)
            {
                objFromDb.Id = car.Id;
                objFromDb.LicensePlate = car.LicensePlate;
                objFromDb.Fuel = car.Fuel;
                objFromDb.CurrentPrice = car.CurrentPrice;
                objFromDb.Availability = car.Availability;
            }
        }
    }
}
