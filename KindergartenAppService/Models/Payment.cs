using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace KindergartenAppService.Models
{
    public class Payment
    {
        public Guid InvoiceId{ get; set; }
        public Invoice Invoice { get; set; }
        public Guid ReceiptId { get; set; }
        public Receipt Receipt { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Amount { get; set; }
    }
}