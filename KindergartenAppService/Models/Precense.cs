using System;

namespace KindergartenAppService.Models
{
    public class Precense:UniqueEntity
    {
        public DateTime PrecenseDay { get; set; }
        public Guid KidId { get; set; }
        public Kid Kid { get; set; }
    }
}