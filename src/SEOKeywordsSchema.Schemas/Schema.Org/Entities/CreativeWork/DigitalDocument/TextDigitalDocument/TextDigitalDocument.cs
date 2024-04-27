﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.CreativeWork.DigitalDocument;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.CreativeWork.DigitalDocument.TextDigitalDocument;
public class TextDigitalDocument : DigitalDocument
{
    public override string TypeName { get; protected set; } = nameof(TextDigitalDocument);
}
