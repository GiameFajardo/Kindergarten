using System;
using System.Collections.Generic;

namespace KindergartenAppService.Models
{
    public class Enrollment :UniqueEntity
    {
        public DateTime EnrollDay { get; set; }
        public Guid KidId { get; set; }
        public Kid Kid { get; set; }
        public virtual ICollection<EnrollActivity> EnrollActivities { get; set; }
    }
}