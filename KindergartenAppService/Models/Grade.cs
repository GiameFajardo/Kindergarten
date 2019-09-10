using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KindergartenAppService.Models
{
    public enum Grade
    {
        [Display(Name = "No aplica")]
        None = 'N',
        [Display(Name = "Infantes")]
        Baby = 'B',
        [Display(Name = "Párvulo")]
        Infant = 'I',
        [Display(Name = "Pre-Kinder")]
        PreKinder = 'P',
        [Display(Name = "Kinder")]
        Kinder = 'K',
        [Display(Name = "Pre-Primario")]
        PrePrimario = 'p',
    }
}
