﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOKeywordsSchema.Schemas.SchemaEntities.Intangibles.Enumerations.MusicAlbumProductionTypes;
public class LiveAlbum : MusicAlbumProductionType
{
    public override string TypeName { get; protected set; } = nameof(LiveAlbum);
}