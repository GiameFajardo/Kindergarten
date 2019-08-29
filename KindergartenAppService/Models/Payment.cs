using System;

namespace KindergartenAppService.Models
{
    public class Payment
    {
        public Guid InvoiceId{ get; set; }
        public Invoice Invoice { get; set; }
        public Guid ReceiptId { get; set; }
        public Receipt Receipt { get; set; }
        public decimal Amount { get; set; }
    }
}