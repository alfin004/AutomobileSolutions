using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AutomobileSolutionsRepository.Entities
{
    public class CarModels
    {
        [Key]
        public Guid CarModelId { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
    }
}
