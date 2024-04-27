using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Enumeration.MedicalEnumeration;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Enumeration.MedicalEnumeration.MedicineSystem;
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
