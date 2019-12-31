using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KindergartenAppService.Models
{
    public class Provider: UniqueEntity
    {
        public string Name { get; set; }
        [Display(Prompt = "c/ Los rieles, Res. Jardines edf. 3 apto. 1B", Name = "Dirección")]
        public string Address { get; set; }
        [Phone]
        [Display(Prompt = "809-234-5674", Name = "Teléfono")]
        public string PhoneNumber { get; set; }
    }
}
