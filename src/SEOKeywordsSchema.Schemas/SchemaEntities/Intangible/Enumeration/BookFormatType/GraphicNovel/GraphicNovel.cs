﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOKeywordsSchema.Schemas.SchemaEntities.Intangibles.Enumerations.BookFormatTypes;
public class GraphicNovel : BookFormatType
{
    public override string TypeName { get; protected set; } = nameof(GraphicNovel);
}