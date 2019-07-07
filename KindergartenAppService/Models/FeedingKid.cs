using System;

namespace KindergartenAppService.Models
{
    public class FeedingKid
    {
        public Guid KidId { get; set; }
        public Kid Kid { get; set; }
        public Guid FeddingId { get; set; }
        public Feeding Fedding { get; set; }
    }
}