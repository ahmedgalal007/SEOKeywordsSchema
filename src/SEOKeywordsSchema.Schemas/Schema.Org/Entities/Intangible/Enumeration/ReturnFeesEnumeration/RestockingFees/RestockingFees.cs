﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Enumeration.ReturnFeesEnumeration;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Enumeration.ReturnFeesEnumeration.RestockingFees;
public class RestockingFees : ReturnFeesEnumeration
{
    public override string TypeName { get; protected set; } = nameof(RestockingFees);
}
