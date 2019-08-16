
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KindergartenAppService.Models
{
    public class Invoice:UniqueEntity
    {
        public DateTime Date { get; set; }
        public Guid KidId { get; set; }
        public Kid Kid { get; set; }
        public ICollection<InvoiceDetail> InvoiceDetails { get; set; }
        public virtual ICollection<Payment> Payments { get; set; }
        [Display(Name = "Precio", Prompt = "3,000.00")]
        public decimal Price { get; set; }

    }
}
