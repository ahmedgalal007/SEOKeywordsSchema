﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.CreativeWork.WebPageElement;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.CreativeWork.WebPageElement.WPFooter;
public class WPFooter : WebPageElement
{
    public override string TypeName { get; protected set; } = nameof(WPFooter);
}