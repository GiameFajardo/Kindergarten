using System;

namespace KindergartenAppService.Models
{
    public class InvoiceDetail:UniqueEntity
    {
        public decimal Quantity { get; set; }
        public decimal Amount { get; set; }
        public Guid ItemId { get; set; }
        public Item Item { get; set; }
        public Guid InvoiceId { get; set; }
        public Invoice Invoice { get; set; }
    }
}