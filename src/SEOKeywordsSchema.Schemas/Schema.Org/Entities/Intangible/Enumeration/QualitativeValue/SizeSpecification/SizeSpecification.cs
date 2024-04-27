﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Enumeration.QualitativeValue;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Enumeration.QualitativeValue.SizeSpecification;
public class SizeSpecification : QualitativeValue
{
    public override string TypeName { get; protected set; } = nameof(SizeSpecification);
}
