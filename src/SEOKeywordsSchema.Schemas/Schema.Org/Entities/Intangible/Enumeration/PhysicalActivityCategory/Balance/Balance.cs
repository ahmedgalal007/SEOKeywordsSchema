﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Enumeration.PhysicalActivityCategory;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Enumeration.PhysicalActivityCategory.Balance;
public class Balance : PhysicalActivityCategory
{
    public override string TypeName { get; protected set; } = nameof(Balance);
}