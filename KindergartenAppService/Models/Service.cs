using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KindergartenAppService.Models
{
    public class Service:Item
    {
        [Required]
        [Display(Name ="Descripción",Prompt ="Servicio de cuidade")]
        public string Description { get; set; }
        [Display(Name ="Actividad", Prompt ="Seleccione una actividad")]
        public Guid ActivityId { get; set; }
        [Display(Name = "Actividad", Prompt = "Seleccione una actividad")]
        public Activity Activity { get; set; }
        [Display(Name ="Periodo",Prompt ="Seleccione un periodo")]
        public ServicePeriod ServicePeriod { get; set; }
    }
}
