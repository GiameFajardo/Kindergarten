using System;

namespace KindergartenAppService.Models
{
    public class Activity:UniqueEntity
    {
        public string Description { get; set; }
        public Guid KindergarterId { get; set; }
        public Kindergarter Kindergarter { get; set; }

    }
}