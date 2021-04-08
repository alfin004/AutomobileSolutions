using AutomobileSolutionsRepository.Entities;
using AutomobileSolutionsService.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AutomobileSolutions.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarModelController : ControllerBase
    {
        private readonly ICarModalService _ICarModalService;
        public CarModelController(ICarModalService ICarModalService)
        {
            _ICarModalService = ICarModalService;
        }
        
        [HttpGet]
        public IEnumerable<CarModels> Get()
        {
            return _ICarModalService.GetAllCarModals();
        }

        // GET api/<CarModel>/5
        [HttpGet("{id}")]
        public CarModels Get(Guid id)
        {
            return _ICarModalService.GetCarModal(id);
        }

        // POST api/<CarModel>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<CarModel>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CarModel>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
