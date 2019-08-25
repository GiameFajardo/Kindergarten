
using System.ComponentModel.DataAnnotations;

namespace KindergartenAppService.Models
{
    public enum InvoiceStatus
    {
        [Display(Name = "Preview")]
        Preview = 'W',
        [Display(Name = "Generada")]
        Generated = 'G',
        [Display(Name = "Procesada")]
        Processed = 'P',
        [Display(Name = "Pagada")]
        Paid = 'R'
    }
}
