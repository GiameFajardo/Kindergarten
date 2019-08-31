using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace KindergartenAppService.Models
{
    public class Receipt:UniqueEntity
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

        [Display(Name = "Monto", Prompt = "")]
        public decimal Amount { get; set; }
        [Display(Name = "Documento afectado", Prompt = "")]
        public string AffectedDocument { get; set; }
        [Display(Name = "Estado", Prompt = "")]
        public ReceiptStatus Status { get; set; }

        public ICollection<Payment> Payments { get; set; }
    }
}
