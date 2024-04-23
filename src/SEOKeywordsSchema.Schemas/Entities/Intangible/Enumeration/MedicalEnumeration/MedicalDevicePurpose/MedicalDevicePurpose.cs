using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOKeywordsSchema.Schemas.Entities.Intangibles.Enumerations.MedicalEnumerations;
public class MedicalDevicePurpose : MedicalEnumeration
{
    public override string TypeName { get; protected set; } = nameof(MedicalDevicePurpose);
}


// todo Member Diagnostic
// todo Member Therapeutic