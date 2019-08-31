using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KindergartenAppService.Models
{
    public enum ReceiptStatus
    {
        [Display(Name = "Precesado")]
        Preccess = 'P',
        [Display(Name = "Cancelado")]
        Cancelled = 'C'
    }
}
