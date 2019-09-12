
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace KindergartenAppService.Models
{
    public class Invoice:UniqueEntity
    {
        [Display(Name = "Secuencia", Prompt = "")]
        public long Sequence { get; set; }
        [NotMapped]
        private string _sequenceString;
        [NotMapped]
        public string SequenceString
        {
            get { return Sequence.ToString().PadLeft(10,'0'); }
            private set { _sequenceString = value; }
        }
        [Display(Name = "Documento", Prompt = "")]
        public string Document { get; set; }
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
        [NotMapped]
        private string _month;
        [NotMapped]
        public string Month
        {
            get
            {
                int month = GeneratedDate.Month;
                return Enum.GetName(typeof(MonthSpanish), month);
            }
            set { _month = value; }
        }
        [NotMapped]
        private string _dueMonth;
        [NotMapped]
        public string DueMonth
        {
            get
            {
                int month = DueDate.Month;
                return Enum.GetName(typeof(MonthSpanish), month);
            }
            set { _dueMonth = value; }
        }
        [NotMapped]
        public MonthSpanish MonthSpanish {
            get
            {
                int month = GeneratedDate.Month;
                switch (month)
                {
                    case 1: return MonthSpanish.Enero;
                    case 2: return MonthSpanish.Febrero;
                    case 3: return MonthSpanish.Marzo;
                    case 4: return MonthSpanish.Abril;
                    case 5: return MonthSpanish.Mayo;
                    case 6: return MonthSpanish.Junio;
                    case 7: return MonthSpanish.Julio;
                    case 8: return MonthSpanish.Agosto;
                    case 9: return MonthSpanish.Septiembre;
                    case 10: return MonthSpanish.Octubre;
                    case 11: return MonthSpanish.Noviembre;
                    case 12: return MonthSpanish.Diciembre;
                    default: return MonthSpanish.Enero;
                }
            }
            set { }
        }
    }
}
