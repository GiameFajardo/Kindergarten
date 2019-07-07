using System;

namespace KindergartenAppService.Models
{
    public class MedicalRecord: UniqueEntity
    {
        //public Guid MedicalRecordTypeId { get; set; }
        //public MedicalRecordType MedicalRecordType { get; set; }
        public Guid KidId { get; set; }
        public Kid Kid { get; set; }
    }
}