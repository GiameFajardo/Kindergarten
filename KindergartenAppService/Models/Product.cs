using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KindergartenAppService.Models
{
    public class Product:Item
    {

        public virtual ICollection<Stock> Stock { get; set; }
    }
}
