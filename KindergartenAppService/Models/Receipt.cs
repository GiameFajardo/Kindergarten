using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KindergartenAppService.Models
{
    public class Receipt:UniqueEntity
    {
        public ICollection<Payment> Payments { get; set; }
    }
}
