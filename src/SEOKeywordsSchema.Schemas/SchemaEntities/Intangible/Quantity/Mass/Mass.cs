﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOKeywordsSchema.Schemas.SchemaEntities.Intangibles.Quantities;
public class Mass : Quantity
{
    public override string TypeName { get; protected set; } = nameof(Mass);
}