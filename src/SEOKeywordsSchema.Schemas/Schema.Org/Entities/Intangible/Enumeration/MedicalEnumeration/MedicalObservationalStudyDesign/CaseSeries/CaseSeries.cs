﻿using SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Enumeration.MedicalEnumeration.MedicalObservationalStudyDesign;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Enumeration.MedicalEnumeration.MedicalObservationalStudyDesign.CaseSeries;
public class CaseSeries : MedicalObservationalStudyDesign
{
    public override string TypeName { get; protected set; } = nameof(CaseSeries);
}
