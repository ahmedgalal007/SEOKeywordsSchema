﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Enumeration.MusicReleaseFormatType;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Enumeration.MusicReleaseFormatType.VinylFormat;
public class VinylFormat : MusicReleaseFormatType
{
    public override string TypeName { get; protected set; } = nameof(VinylFormat);
}
