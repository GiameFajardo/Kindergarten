using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KindergartenAppService.Models
{
    public enum Relationship
    {
        [Display(Name = "Padre")]
        Father = 'F',
        [Display(Name = "Madre")]
        Mother = 'M',
        [Display(Name = "Abuela")]
        GrandMother = 'm',
        [Display(Name = "Abuelo")]
        GrandFather = 'f',
        [Display(Name = "Madrastra")]
        StepMother = 's',
        [Display(Name = "Padrastro")]
        StepFather = 'z',
        [Display(Name = "Hermano")]
        Brother = 'b',
        [Display(Name = "Hermana")]
        Sister = 's',
        [Display(Name = "Padrino")]
        GodFather = 'G',
        [Display(Name = "Madrina")]
        GodMother = 'g',
        [Display(Name = "Otro")]
        Other = 'o'
    }
}
