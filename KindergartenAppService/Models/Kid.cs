using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace KindergartenAppService.Models
{
    public class Kid: UniqueEntity
    {
        [Required]
        [MinLength(2)]
        public string FirstName { get; set; }
        [MinLength(2)]
        public string SecondName { get; set; }
        public string FatherName { get; set; }
        public string MotherName { get; set; }
        //public Guid TutorId { get; set; }
        public Tutor Tutor { get; set; }
        public Guid KindergarterId { get; set; }
        public Kindergarter Kindergarter { get; set; }
        public virtual ICollection<MedicalRecord> MedicalRecords { get; set; }
        public virtual ICollection<FeedingKid> FeedingKids { get; set; }
        public virtual ICollection<Precense> Precenses { get; set; }

    }
}