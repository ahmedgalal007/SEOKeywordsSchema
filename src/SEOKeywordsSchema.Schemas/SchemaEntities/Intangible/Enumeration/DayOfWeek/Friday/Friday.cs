﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOKeywordsSchema.Schemas.SchemaEntities.Intangibles.Enumerations.DayOfWeekS;
public class Friday : DayOfWeek
{
    public override string TypeName { get; protected set; } = nameof(Friday);
}