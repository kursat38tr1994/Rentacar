using System;
using System.Collections.Generic;
using System.Text;
using Rentacar_DataAccess.Repository.IRepository;
using Rentacar_Models;

namespace Rentacar_BusinessLogic
{
    public class CarService
    {
        private readonly IUnitOfWork _unitOfWork; 

        public CarService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        //public int Upsert(int? id)
        //{
        //    Car category = new Car();
        //    if (id == null)
        //    {
        //        //this is for create
        //        return View(category);
        //    }
        //    //this is for edit
        //    category = _unitOfWork.Category.Get(id.GetValueOrDefault());
        //    if (category == null)
        //    {
        //        return NotFound();
        //    }
        //    return View(category);

        //}
    }
}
