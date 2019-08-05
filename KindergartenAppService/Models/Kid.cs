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

        [Display(Name = "Fecha de nacimiento")]
        public DateTime BirthDate { get; set; }

        //[Display(Name = "Sexo")]
        //public Sex Sex { get; set; }

        //[Display(Prompt = "c/ Los rieles, Res. Jardines edf. 3 apto. 1B", Name = "Dirección")]
        //public string Address { get; set; }

        //[Display(Prompt = "Usar su table", Name = "Actividad favorita")]
        //public string FavoriteAddress { get; set; }

        //[Display(Prompt = "2", Name = "Cantidad de hermanos")]
        //public int SiblingCount { get; set; }

        //[Display(Prompt = "4+", Name = "Size TShirt")]
        //public TShirtSize TShirtSize { get; set; }

        //[Display(Prompt = "Alergia a algunos medicamentos; cererizina.", Name = "Alergias o enfermedades")]
        //public string Diseases { get; set; }

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
        //public virtual Guid PediatricianId { get; set; }
        //public virtual Pediatrician Pediatrician { get; set; }
        public Guid TutorId { get; set; }
        public Tutor Tutor { get; set; }
        //public virtual Guid TutorSecundaryId { get; set; }
        //public virtual Tutor TutorSecundary { get; set; }
        //public virtual Guid TutorAutorizeId { get; set; }
        //public virtual Tutor TutorAutorize { get; set; }
        [Display(Prompt = "Guarderia Id", Name = "GuarderiaId")]
        public Guid KindergarterId { get; set; }
        [Display(Prompt = "Guarderia", Name = "Guarderia")]
        public Kindergarter Kindergarter { get; set; }
        //public virtual Guid EnrollmentId { get; set; }
        public virtual Enrollment Enrollment { get; set; }
        public virtual ICollection<MedicalRecord> MedicalRecords { get; set; }
        public virtual ICollection<FeedingKid> FeedingKids { get; set; }
        public virtual ICollection<Precense> Precenses { get; set; }

    }
}