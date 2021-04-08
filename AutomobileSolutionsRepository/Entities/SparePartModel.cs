using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AutomobileSolutionsRepository.Entities
{
    [Table("SparePartModel", Schema = "dbo")]
    public class SparePartModel
    {
        [Key]

        public Guid PartId { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        [Required]
        [MaxLength(50)]
        public string SerialNo { get; set; }

        [Required]
        public Guid CarModelId { get; set; }
    }
}
