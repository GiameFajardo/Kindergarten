using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KindergartenAppService.Models
{
    public class ActivityTemplate:UniqueEntity
    {

        [Required]
        [Display(Name = "Descripción", Prompt = "Baile folcolorico")]
        public string Description { get; set; }
        [Required]
        [Display(Name = "Guarderia", Prompt = "Seleccione guarderia")]
        public Guid KindergarterId { get; set; }
        [Display(Name = "Guarderia", Prompt = "Seleccione guarderia")]
        public Kindergarter Kindergarter { get; set; }
        [Display(Name = "Actividades")]
        public virtual ICollection<Activity> Activities { get; set; }
    }
}
