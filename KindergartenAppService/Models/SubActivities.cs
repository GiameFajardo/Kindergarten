using System;

namespace KindergartenAppService.Models
{
    public class SubActivities:UniqueEntity
    {
        public TimeSpan StaringTime { get; set; }
        public TimeSpan EndingTime { get; set; }
        public DateTime Date { get; set; }
        public Guid ActivityId { get; set; }
        public Activity Activity { get; set; }
    }
}