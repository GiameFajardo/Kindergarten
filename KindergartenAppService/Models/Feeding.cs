using System.Collections.Generic;

namespace KindergartenAppService.Models
{
    public class Feeding:UniqueEntity
    {
        public virtual ICollection<FeedingKid> FeedingKids { get; set; }
    }
}