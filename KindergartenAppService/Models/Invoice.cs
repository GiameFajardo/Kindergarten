
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KindergartenAppService.Models
{
    public class Invoice:UniqueEntity
    {
        [Display(Name = "Fecha de creación", Prompt = "")]
        public DateTime GeneratedDate { get; set; }
        [Display(Name = "Fecha de vencimiento", Prompt = "")]
        public DateTime DueDate { get; set; }
        [Display(Name = "Niño", Prompt = "")]
        public Guid KidId { get; set; }
        [Display(Name = "Niño", Prompt = "")]
        public Kid Kid { get; set; }
        public ICollection<InvoiceDetail> InvoiceDetails { get; set; }
        public virtual ICollection<Payment> Payments { get; set; }
        [Display(Name = "Monto", Prompt = "3,000.00")]
        public decimal Price { get; set; }
        [Display(Name = "Estado", Prompt = "")]
        public InvoiceStatus Status { get; set; }
    }
}
