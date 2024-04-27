using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.CreativeWork.WebPage.CollectionPage.MediaGallery;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.CreativeWork.WebPage.CollectionPage.MediaGallery.VideoGallery;
public class VideoGallery : MediaGallery
{
    public override string TypeName { get; protected set; } = nameof(VideoGallery);
}
