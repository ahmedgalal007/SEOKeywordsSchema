﻿using SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Enumeration.StatusEnumeration.GameServerStatus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Enumeration.StatusEnumeration.GameServerStatus.OnlineFull;
public class OnlineFull : GameServerStatus
{
    public override string TypeName { get; protected set; } = nameof(OnlineFull);
}
