using KindergartenAppService.Utilities.Validations;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KindergartenAppService.Models
{
    public class RegisterViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Correo")]
        [Remote(action:"IsEmailInUse", controller:"Account")]
        //[ValidEmailDomainAttribute(allowDomain:"giamefajardo.com",
        //                           ErrorMessage ="El correo debe pertenecer al dominio giamefajardo.com")]                                    
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Contraseña")]
        public string Password { get; set; }
        [DataType(DataType.Password)]
        [Display(Name = "Confirmación")]
        [Compare("Password",ErrorMessage = "Contraseña y confirmacion no son iguales.")]
        public string ConfirmPassword { get; set; }
    }
}
