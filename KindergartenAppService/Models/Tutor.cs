using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KindergartenAppService.Models
{
    public class Tutor: UniqueEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

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