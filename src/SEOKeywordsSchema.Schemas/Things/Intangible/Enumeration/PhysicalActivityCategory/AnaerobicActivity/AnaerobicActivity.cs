﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOKeywordsSchema.Schemas.Things.Intangibles.Enumerations.PhysicalActivityCategories;
public class AnaerobicActivity : PhysicalActivityCategory
{
    public override string TypeName { get; protected set; } = nameof(AnaerobicActivity);
}