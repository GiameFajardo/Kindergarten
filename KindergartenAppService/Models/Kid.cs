using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KindergartenAppService.Models
{
    public class Kid : UniqueEntity
    {
        [Required]
        [MinLength(2)]
        [Display(Prompt="Dylan",Name ="Primer Nombre")]
        public string FirstName { get; set; }
        [MinLength(2)]
        [Display(Prompt = "Jesus", Name = "Segundo Nombre")]
        public string SecondName { get; set; }
        [Required]
        [MinLength(2)]
        [Display(Prompt = "Rojas", Name = "Apellido Paterno")]
        public string FatherName { get; set; }
        [MinLength(2)]
        [Display(Prompt = "Pinales", Name = "Apellido Materno")]
        public string MotherName { get; set; }


        private string _fullname;
        [NotMapped]
        [Display(Prompt = "Nombre Completo", Name = "Nombre Completo")]
        public string FullName
        {
            get
            {
                return
                  (string.IsNullOrWhiteSpace(FirstName) ? "" : FirstName) +
                  (string.IsNullOrWhiteSpace(SecondName) ? "" : " " + SecondName) +
                  (string.IsNullOrWhiteSpace(FatherName) ? "" : " " + FatherName) +
                  (string.IsNullOrWhiteSpace(MotherName) ? "" : " " + MotherName)
                  ;
            }
            set { _fullname = value; }
        }

        public Guid TutorId { get; set; }
        public Tutor Tutor { get; set; }
        [Display(Prompt = "Guarderia Id", Name = "GuarderiaId")]
        public Guid KindergarterId { get; set; }
        [Display(Prompt = "Guarderia", Name = "Guarderia")]
        public Kindergarter Kindergarter { get; set; }
        public virtual ICollection<MedicalRecord> MedicalRecords { get; set; }
        public virtual ICollection<FeedingKid> FeedingKids { get; set; }
        public virtual ICollection<Precense> Precenses { get; set; }

    }
}