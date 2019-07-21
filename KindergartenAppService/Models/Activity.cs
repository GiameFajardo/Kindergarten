using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace KindergartenAppService.Models
{
    public class Activity:UniqueEntity
    {
        [Required]
        [Display(Name = "Descripción", Prompt ="Baile folcolorico")]
        public string Description { get; set; }
        [Required]
        [Display(Name = "Plantilla", Prompt = "Selecciones una plantilla")]
        public Guid ActivityTemplateId { get; set; }
        [Display(Name = "Plantilla", Prompt = "Selecciones una plantilla")]
        public ActivityTemplate ActivityTemplate { get; set; }

        public virtual ICollection<SubActivities> SubActivities { get; set; }
    }
}