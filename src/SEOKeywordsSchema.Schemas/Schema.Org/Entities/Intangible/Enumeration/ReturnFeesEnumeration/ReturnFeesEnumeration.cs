﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Enumeration;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Enumeration.ReturnFeesEnumeration;
public class ReturnFeesEnumeration : Enumeration
{
    public override string TypeName { get; protected set; } = nameof(ReturnFeesEnumeration);
}


// TODO Member FreeReturn
// TODO Member OriginalShippingFees
// TODO Member RestockingFees
// TODO Member ReturnFeesCustomerResponsibility
// TODO Member ReturnShippingFees