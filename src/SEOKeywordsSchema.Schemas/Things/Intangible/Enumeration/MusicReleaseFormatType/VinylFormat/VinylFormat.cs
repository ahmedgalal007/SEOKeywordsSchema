﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOKeywordsSchema.Schemas.Things.Intangibles.Enumerations.MusicReleaseFormatTypes;
public class VinylFormat : MusicReleaseFormatType
{
    public override string TypeName { get; protected set; } = nameof(VinylFormat);
}