﻿using SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Enumeration.MedicalEnumeration.MedicalSpecialty;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Enumeration.MedicalEnumeration.MedicalSpecialty.SpeechPathology;
public class SpeechPathology : MedicalSpecialty
{
    public override string TypeName { get; protected set; } = nameof(SpeechPathology);
}
