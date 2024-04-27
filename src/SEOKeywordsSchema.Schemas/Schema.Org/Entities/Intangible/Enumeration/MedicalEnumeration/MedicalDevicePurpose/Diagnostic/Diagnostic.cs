﻿using SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Enumeration.MedicalEnumeration.MedicalDevicePurpose;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Enumeration.MedicalEnumeration.MedicalDevicePurpose.Diagnostic;
public class Diagnostic : MedicalDevicePurpose
{
    public override string TypeName { get; protected set; } = nameof(Diagnostic);
}
