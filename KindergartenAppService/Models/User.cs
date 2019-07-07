using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KindergartenAppService.Models
{
    public class User:UniqueEntity
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public Guid KindergarterId { get; set; }
        public Kindergarter Kindergarter { get; set; }
    }
}
