using System;
using System.ComponentModel.DataAnnotations;

namespace KindergartenAppService.Models
{
    public class EnrollActivity:UniqueEntity
    {
        [Display(Prompt = "", Name = "Actividad")]
        public Guid ActivityId{ get; set; }
        [Display(Prompt = "", Name = "Actividad")]
        public Activity Activity { get; set; }
        [Display(Prompt = "", Name = "Insripción")]
        public virtual Guid EnrollmentId { get; set; }
        [Display(Prompt = "", Name = "Insripción")]
        public virtual Enrollment Enrollment { get; set; }
    }
}