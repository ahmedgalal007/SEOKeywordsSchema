using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOKeywordsSchema.Schemas.Entities.CreativeWorks.WebPages.CollectionPages.MediaGalleries;
public class ImageGallery : MediaGallery  
{
    public override string TypeName { get; protected set; } = nameof(ImageGallery);
}
