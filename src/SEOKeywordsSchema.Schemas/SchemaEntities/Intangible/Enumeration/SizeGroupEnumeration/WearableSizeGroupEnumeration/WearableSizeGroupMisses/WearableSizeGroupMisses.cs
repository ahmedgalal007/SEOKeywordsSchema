﻿using SEOKeywordsSchema.Schemas.SchemaEntities.Intangibles.Enumerations.SizeGroupEnumerations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOKeywordsSchema.Schemas.SchemaEntities.Intangibles.Enumerations.SizeGroupEnumerations.WearableSizeGroupEnumerations;
public class WearableSizeGroupMisses : WearableSizeGroupEnumeration
{
    public override string TypeName { get; protected set; } = nameof(WearableSizeGroupMisses);
}