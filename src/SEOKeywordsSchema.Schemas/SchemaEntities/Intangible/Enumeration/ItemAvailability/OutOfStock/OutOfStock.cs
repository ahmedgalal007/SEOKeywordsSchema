﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOKeywordsSchema.Schemas.SchemaEntities.Intangibles.Enumerations.ItemAvailabilities;
public class OutOfStock : ItemAvailability
{
    public override string TypeName { get; protected set; } = nameof(OutOfStock);
}