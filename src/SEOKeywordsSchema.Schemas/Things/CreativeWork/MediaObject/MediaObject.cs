using Microsoft.EntityFrameworkCore;
using SEOKeywordsSchema.Schemas.SchemaProperties.BaseMixedTypes.BaseValueTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOKeywordsSchema.Schemas.Things.CreativeWorks;
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