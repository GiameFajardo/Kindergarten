using System;

namespace KindergartenAppService.Models
{
    public class EnrollActivity:UniqueEntity
    {
        public Guid ActivityId{ get; set; }
        public Activity Activity { get; set; }
    }
}