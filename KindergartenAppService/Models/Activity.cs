using System;
using System.ComponentModel.DataAnnotations;

namespace KindergartenAppService.Models
{
    public class Activity:UniqueEntity
    {
        [Required]
        [Display(Name = "Descripción", Prompt ="Baile folcolorico")]
        public string Description { get; set; }
        [Required]
        [Display(Name ="Guarderia", Prompt ="Seleccione guarderia")]
        public Guid KindergarterId { get; set; }
        [Display(Name = "Guarderia", Prompt = "Seleccione guarderia")]
        public Kindergarter Kindergarter { get; set; }

    }
}