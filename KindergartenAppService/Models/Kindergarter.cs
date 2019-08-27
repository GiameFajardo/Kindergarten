using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KindergartenAppService.Models
{
    public class Kindergarter: UniqueEntity
    {
        [Display(Prompt = "My little hero", Name = "Descripción")]
        public string Description { get; set; }
        [Display(Prompt = "C/", Name = "Dirección")]
        public string Address { get; set; }
        [Display(Prompt = "info@mylittlehero.com", Name = "Correo")]
        public string Mail { get; set; }
        [Display(Prompt = "809-858-1515", Name = "Teléfono")]
        public string Phone { get; set; }
        [Display(Prompt = "Gracias por preferirnos", Name = "Mensaje de pie de factura")]
        public string InvoiceMessage { get; set; }

        public virtual ICollection<Kid> Kids { get; set; }
        public virtual ICollection<ActivityTemplate> ActivityTemplates { get; set; }
        public virtual ICollection<AppUser> Users { get; set; }
    }
}
