﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOKeywordsSchema.Schemas.SchemaEntities.CreativeWorks.Games;
public class VideoGame: Game
{
    public override string TypeName { get; protected set; } = nameof(VideoGame);
}