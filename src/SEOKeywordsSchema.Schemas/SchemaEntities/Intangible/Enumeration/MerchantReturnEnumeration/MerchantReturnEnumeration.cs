﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOKeywordsSchema.Schemas.SchemaEntities.Intangibles.Enumerations;
public class MerchantReturnEnumeration : Enumeration
{
    public override string TypeName { get; protected set; } = nameof(MerchantReturnEnumeration);
}


// TODO Member MerchantReturnFiniteReturnWindow
// TODO Member MerchantReturnNotPermitted
// TODO Member MerchantReturnUnlimitedWindow
// TODO Member MerchantReturnUnspecified