using AutomobileSolutionsRepository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutomobileSolutionsRepository.Repository
{
    public interface ICarModalRepository
    {
        IEnumerable<CarModels> GetAllCarModals();

        CarModels GetCarModal(Guid id);
    }

    public class CarModalRepository : ICarModalRepository
    {
        private readonly ASContext _ASContext;
        public CarModalRepository(ASContext context)
        {
            _ASContext = context;
        }

        public IEnumerable<CarModels> GetAllCarModals()
        {
            return _ASContext.CarModel.ToList();
        }

        public CarModels GetCarModal(Guid id)
        {
            return _ASContext.CarModel.Find(id);
        }
    }
}
