using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KindergartenAppService.Models
{
    public enum DocumentType { Invoice = 'I', Recipe = 'R'}
    public class Sequence:UniqueEntity
    {
        public long StaringSequence { get; set; }
        public long CurrentSequence { get; set; }
        public string Prefix { get; set; }
        public DocumentType DocumentType { get; set; }

    }
}
