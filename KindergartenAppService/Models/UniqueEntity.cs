using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KindergartenAppService.Models
{
    public abstract class UniqueEntity
    {
        public Guid Id { get; set; }
    }
}
