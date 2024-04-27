using Microsoft.EntityFrameworkCore;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.CreativeWork;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.CreativeWork.MediaObject;
[EntityTypeConfiguration(typeof(EntityTypeConfigurationBase<MediaObject>))]
public class MediaObject : BaseEntity
{
    public virtual string TypeName { get; protected set; } = nameof(MediaObject);
    public virtual CreativeWork Parent { get; protected set; }
}


// TODO 3DModel
// TODO AmpStory
// TODO AudioObject
// TODO DataDownload
// TODO ImageObject
// TODO LegislationObject
// TODO MusicVideoObject
// TODO TextObject
// TODO VideoObject