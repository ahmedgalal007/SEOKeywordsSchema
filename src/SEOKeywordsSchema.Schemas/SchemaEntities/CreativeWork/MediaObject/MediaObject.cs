using Microsoft.EntityFrameworkCore;

namespace SEOKeywordsSchema.Schemas.SchemaEntities.CreativeWorks;
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