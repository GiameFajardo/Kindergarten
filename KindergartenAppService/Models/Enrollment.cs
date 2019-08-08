using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace KindergartenAppService.Models
{
    public class Enrollment :UniqueEntity
    {
        [Display(Prompt = "", Name = "Fecha de inscripción")]
        [DataType(DataType.Date)]
        public DateTime EnrollDay { get; set; }
        [Display(Prompt = "", Name = "Niño")]
        public Guid KidId { get; set; }
        [Display(Prompt = "", Name = "Niño")]
        public Kid Kid { get; set; }
        [Display(Prompt = "", Name = "Comentario")]
        public virtual string Comment { get; set; }
        [Display(Prompt = "", Name = "Actividades registradas")]
        public virtual ICollection<EnrollActivity> EnrollActivities { get; set; }
    }
}