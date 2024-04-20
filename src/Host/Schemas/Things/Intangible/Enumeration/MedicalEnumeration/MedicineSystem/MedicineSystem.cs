using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSH.WebApi.Domain.Schemas.Things.Intangibles.Enumerations.MedicalEnumerations;
public class MedicineSystem : MedicalEnumeration
{
    public override string TypeName { get; protected set; } = nameof(MedicineSystem);
}


// TODO Member Ayurvedic
// TODO Member Chiropractic
// TODO Member Homeopathic
// TODO Member Osteopathic
// TODO Member TraditionalChinese
// TODO Member WesternConventional
