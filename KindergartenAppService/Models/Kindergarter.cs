using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KindergartenAppService.Models
{
    public class Kindergarter: UniqueEntity
    {
        [Display(Prompt = "Descripción", Name = "My little hero")]
        public string Description { get; set; }
        [Display(Prompt = "Dirección", Name = "C/")]
        public string Address { get; set; }
        [Display(Prompt = "Correo", Name = "info@mylittlehero.com")]
        public string Mail { get; set; }
        [Display(Prompt = "Teléfono", Name = "809-858-1515")]
        public string Phone { get; set; }
        [Display(Prompt = "Mensaje en pie de factura", Name = "Gracias por preferirnos")]
        public string InvoiceMessage { get; set; }

        public virtual ICollection<Kid> Kids { get; set; }
        public virtual ICollection<ActivityTemplate> ActivityTemplates { get; set; }
        public virtual ICollection<AppUser> Users { get; set; }
    }
}
