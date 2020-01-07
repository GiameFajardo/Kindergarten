using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace KindergartenAppService.Models
{
    public class PurchaseDetail: UniqueEntity
    {
        [Column(TypeName = "decimal(18,2)")]
        public decimal Quantity { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Amount { get; set; }
        public Guid ItemId { get; set; }
        public Item Item { get; set; }
        public Guid PurchaseId { get; set; }
        public Purchase Purchase { get; set; }
    }
}
