using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KindergartenAppService.Models
{
    public enum Relationship
    {
        Father = 'F',
        Mother = 'M',
        GrandMother = 'm',
        GrandFather = 'f',
        StepMother = 's',
        StepFather = 'z',
        Brother = 'b',
        Sister = 's',
        Other = 'o'
    }
}
