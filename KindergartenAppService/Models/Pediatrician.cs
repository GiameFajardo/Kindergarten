using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KindergartenAppService.Models
{
    public class Pediatrician:UniqueEntity
    {
        public Pediatrician()
        {
            Kids = new List<Kid>();
        }
        [Required]
        [MinLength(2)]
        [Display(Prompt = "Isabel Perez", Name = "Nombre completo")]
        public string Name { get; set; }

        [Display(Prompt = "c/ Los rieles, Res. Jardines edf. 3 apto. 1B", Name = "Dirección")]
        public string Address { get; set; }

        [Phone]
        [Display(Prompt = "829-234-5674", Name = "Teléfono")]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }

        public virtual ICollection<Kid> Kids { get; set; }
    }
}
