using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace KindergartenAppService.Models
{
    public class Purchase: UniqueEntity
    {
        [Display(Name = "Secuencia", Prompt = "")]
        public long Sequence { get; set; }
        [NotMapped]
        private string _sequenceString;
        [NotMapped]
        public string SequenceString
        {
            get { return Sequence.ToString().PadLeft(10, '0'); }
            private set { _sequenceString = value; }
        }
        [Display(Name = "Documento", Prompt = "")]
        public string Document { get; set; }
        [Display(Name = "Fecha de creación", Prompt = "")]
        public DateTime GeneratedDate { get; set; }
        [Display(Name = "Fecha de vencimiento", Prompt = "")]
        public DateTime DueDate { get; set; }
        public ICollection<PurchaseDetail> PurchaseDetails { get; set; }
        public Guid ProviderID { get; set; }
        public Provider Provider { get; set; }
        [Display(Name = "Monto", Prompt = "3,000.00")]
        public decimal Amount { get; set; }
        
    }
}
