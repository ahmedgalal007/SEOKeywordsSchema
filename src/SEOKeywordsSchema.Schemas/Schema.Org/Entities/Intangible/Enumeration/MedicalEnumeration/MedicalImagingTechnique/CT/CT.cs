﻿using SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Enumeration.MedicalEnumeration.MedicalImagingTechnique;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Enumeration.MedicalEnumeration.MedicalImagingTechnique.CT;
public class CT : MedicalImagingTechnique
{
    public override string TypeName { get; protected set; } = nameof(CT);
}
