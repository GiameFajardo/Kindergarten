using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KindergartenAppService.Models
{
    public class Service:Item
    {
        public Guid ActivityId { get; set; }
        public Activity Activity { get; set; }
    }
}
