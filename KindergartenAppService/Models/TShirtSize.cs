
using System.ComponentModel.DataAnnotations;

namespace KindergartenAppService.Models
{
    public enum TShirtSize
    {
        [Display(Name = "Dos")]
        Two = '2',
        [Display(Name = "Cuatro")]
        Four = '4',
        [Display(Name = "Seis")]
        Six = '6'
    }
}
