﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Enumeration.ContactPointOption;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Enumeration.ContactPointOption.TollFree;
public class TollFree : ContactPointOption
{
    public override string TypeName { get; protected set; } = nameof(TollFree);
}
