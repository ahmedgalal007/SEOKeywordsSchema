﻿using SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Enumeration.MedicalEnumeration.InfectiousAgentClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Enumeration.MedicalEnumeration.InfectiousAgentClass.Prion;
public class Prion : InfectiousAgentClass
{
    public override string TypeName { get; protected set; } = nameof(Prion);
}
