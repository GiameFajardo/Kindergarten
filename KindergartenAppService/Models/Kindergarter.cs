using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KindergartenAppService.Models
{
    public class Kindergarter: UniqueEntity
    {
        public string Description { get; set; }

        public virtual ICollection<Kid> Kids { get; set; }
        public virtual ICollection<ActivityTemplate> ActivityTemplates { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}
