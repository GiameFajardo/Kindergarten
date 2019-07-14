using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KindergartenAppService.Models
{
    public class Tutor: UniqueEntity
    {
        [Required]
        [MinLength(10,ErrorMessage ="Este campo no permite menos de 10 caracteres.")]
        [Display(Prompt ="Gregorio de Jesus", Name ="Nombres")]
        public string FirstName { get; set; }

        [Required]
        [MinLength(10, ErrorMessage = "Este campo no permite menos de 10 caracteres.")]
        [Display(Prompt = "Rojas Acosta", Name = "Apellidos")]
        public string LastName { get; set; }

        [EmailAddress]
        [Display(Prompt = "greg.rojas@bussisnes.com", Name = "Correo")]
        public string Mail { get; set; }

        [Phone]
        [Display(Prompt = "809-234-5674", Name = "Teléfono")]
        [RegularExpression(@"^(\+\s?)?((?<!\+.*)\(\+?\d+([\s\-\.]?\d+)?\)|\d+)([\s\-\.]?(\(\d+([\s\-\.]?\d+)?\)|\d+))*(\s?(x|ext\.?)\s?\d+)?$", ErrorMessage = "The PhoneNumber field is not a valid phone number")]
        public string MovilNumber { get; set; }

        [Phone]
        [Display(Prompt = "829-234-5674", Name = "Celular")]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }

        [MinLength(10,ErrorMessage ="Este campo no admite menos de 10 caracteres.")]
        [Display(Prompt = "Avenida siempre viva", Name = "Dirección")]
        public string Address { get; set; }


        private string _fullName;
        [NotMapped]
        [Display(Prompt = "Nombre Completo",Name ="Nombre Completo")]
        public string FullName
        {
            get {
                return
                  (string.IsNullOrWhiteSpace(FirstName) ? "" : FirstName) +
                  (string.IsNullOrWhiteSpace(LastName) ? "" : " " + LastName)
                  ;
            }
            set { _fullName = value; }
        }


    }
}