﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.CreativeWork.WebPage.CollectionPage;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.CreativeWork.WebPage.CollectionPage.MediaGallery;
public class MediaGallery : CollectionPage
{
    public override string TypeName { get; protected set; } = nameof(MediaGallery);
}
