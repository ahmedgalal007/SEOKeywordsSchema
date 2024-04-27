using MassTransit.Futures.Contracts;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Enumeration.MedicalEnumeration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Enumeration.MedicalEnumeration.MedicalImagingTechnique;
public class MedicalImagingTechnique : MedicalEnumeration
{
    public override string TypeName { get; protected set; } = nameof(MedicalImagingTechnique);
}


// TODO Member CT
// TODO Member MRI
// TODO Member PET
// TODO Member Radiography
// TODO Member Ultrasound
// TODO Member XRay