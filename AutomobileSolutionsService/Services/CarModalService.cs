using AutomobileSolutionsRepository.Entities;
using AutomobileSolutionsRepository.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutomobileSolutionsService.Services
{
    public interface ICarModalService
    {
        IEnumerable<CarModels> GetAllCarModals();

        CarModels GetCarModal(Guid id);
    }

    public class CarModalService : ICarModalService
    {
        private readonly ICarModalRepository _ICarModalRepository;
        public CarModalService(ICarModalRepository ICarModalRepository)
        {
            _ICarModalRepository = ICarModalRepository;
        }

        public IEnumerable<CarModels> GetAllCarModals()
        {
            return _ICarModalRepository.GetAllCarModals();
        }

        public CarModels GetCarModal(Guid id)
        {
            return _ICarModalRepository.GetCarModal(id);
        }
    }
}
