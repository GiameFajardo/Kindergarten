using System;

namespace KindergartenAppService.Models
{
    public class Stock
    {
        public Guid StoreId { get; set; }
        public Store Store { get; set; }
        public Guid ProductId { get; set; }
        public Product Product { get; set; }
    }
}