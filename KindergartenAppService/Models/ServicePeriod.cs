using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KindergartenAppService.Models
{
    public enum ServicePeriod
    {
        [Display(Name = "Indefinido")]
        Undefined = 'U',
        [Display(Name = "Diario")]
        Daily = 'D',
        [Display(Name = "Semanal")]
        Weekly = 'W',
        [Display(Name = "Quincenal")]
        Biweekly = 'B',
        [Display(Name = "Mensual")]
        Monthly = 'M',
        [Display(Name = "Por actividad")]
        Activity = 'A'
    }
}
