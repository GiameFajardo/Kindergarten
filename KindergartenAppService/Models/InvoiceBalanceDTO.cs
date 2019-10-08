using KindergartenAppService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KindergartenAppService.DTO
{
    public class InvoiceBalanceDTO
    {
        public InvoiceBalanceDTO()
        {

        }
        public InvoiceBalanceDTO(Invoice invoice)
        {
            Sequence = invoice.Sequence;
            this.SequenceString = invoice.SequenceString;
            this.Status = invoice.Status;
            this.Price = invoice.Price;
            this.Kid = invoice.Kid;
            this.GeneratedDate = invoice.GeneratedDate;
            this.Document = invoice.Document;
            this.DueDate = invoice.DueDate;
        }
        public long Sequence { get; set; }
        private string _sequenceString;
        public string SequenceString
        {
            get { return Sequence.ToString().PadLeft(10, '0'); }
            private set { _sequenceString = value; }
        }
        public string Document { get; set; }
        public DateTime GeneratedDate { get; set; }
        public DateTime DueDate { get; set; }
        public Guid KidId { get; set; }
        public Kid Kid { get; set; }
        public decimal Price { get; set; }
        public decimal Pending { get; set; }
        public InvoiceStatus Status { get; set; }
        private string _month;
        public string Month { get; set; }
       
        private string _dueMonth;
        public string DueMonth{get;set;}
        public string MonthSpanish
        {
            get;set;
        }
    }
}
