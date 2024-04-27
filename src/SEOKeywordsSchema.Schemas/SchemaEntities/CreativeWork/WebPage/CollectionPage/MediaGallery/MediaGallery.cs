using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOKeywordsSchema.Schemas.SchemaEntities.CreativeWorks.WebPages.CollectionPages;
public class MediaGallery: CollectionPage 
{
    public override string TypeName { get; protected set; } = nameof(MediaGallery);
}
