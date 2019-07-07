using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KindergartenAppService.Models
{
    public class Store:UniqueEntity
    {
        public string Address { get; set; }
        public virtual ICollection<Stock> Stock { get; set; }
    }
}
