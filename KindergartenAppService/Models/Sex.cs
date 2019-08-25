using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KindergartenAppService.Models
{
    public enum Sex
    {
        [Display(Name = "Masculino")]
        Masculine = 'M',
        [Display(Name = "Femenino")]
        Femenine = 'F'
    }
}
