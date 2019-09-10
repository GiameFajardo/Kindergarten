using KindergartenAppService.Utilities;
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
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }

        [NotMapped]
        public MonthSpanish BirthMonthSpanish
        {
            get
            {
                int month = BirthDate.Month;
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

        [Display(Name = "Género")]
        public Sex Sex { get; set; }

        [Display(Name = "Grado")]
        public Grade Grade { get; set; }

        [Display(Prompt = "c/ Los rieles, Res. Jardines edf. 3 apto. 1B", Name = "Dirección")]
        public string Address { get; set; }

        [Display(Prompt = "Usar su table", Name = "Actividad favorita")]
        public string FavoriteActivities { get; set; }

        [Display(Prompt = "2", Name = "Cantidad de hermanos")]
        public int SiblingCount { get; set; }

        [Display(Prompt = "4+", Name = "Size TShirt")]
        public TShirtSize TShirtSize { get; set; }

        [Display(Prompt = "Alergia a algunos medicamentos; cererizina.", Name = "Alergias o enfermedades")]
        public string Diseases { get; set; }

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
        [NotMapped]
        private string _age;
        [NotMapped]
        public string Age
        {
            get
            {
                int years = 0;
                int months = 0;
                string yearsText = "";
                string monthText = "";
                if (BirthDate != null)
                {
                    years = DateUtilities.YearsBetweenDates(BirthDate, DateTime.Now);
                    months = DateUtilities.MonthsBetweenDates(BirthDate, DateTime.Now);
                }
                if (years>0)
                {
                    yearsText = years.ToString() + " años";
                   
                }
                if (months > 0)
                {
                    monthText = months.ToString() + " meses";
                    if (years > 0)
                    {
                        yearsText += " - ";
                    }
                }
                return yearsText + monthText;
            }
            private set { _age = value; }
        }

        [Display(Prompt = "", Name = "Pediatra")]
        public virtual Guid? PediatricianId { get; set; }
        [Display(Prompt = "", Name = "Pediatra")]
        public virtual Pediatrician Pediatrician { get; set; }
        [Display(Prompt = "", Name = "Tutor principal")]
        public Guid? TutorPrincipalId { get; set; }
        [Display(Prompt = "", Name = "Tutor principal")]
        public Tutor TutorPrincipal { get; set; }
        [Display(Prompt = "", Name = "Tutor secundario")]
        public virtual Guid? TutorSecundaryId { get; set; }
        [Display(Prompt = "", Name = "Tutor secundario")]
        public virtual Tutor TutorSecundary { get; set; }
        [Display(Prompt = "", Name = "Tutor autorizado")]
        public virtual Guid? TutorAutorizedId { get; set; }
        [Display(Prompt = "", Name = "Tutor autorizado")]
        public virtual Tutor TutorAutorized { get; set; }
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