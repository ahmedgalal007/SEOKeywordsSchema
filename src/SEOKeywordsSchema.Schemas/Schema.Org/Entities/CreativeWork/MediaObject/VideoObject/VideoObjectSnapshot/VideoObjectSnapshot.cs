using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.CreativeWork.MediaObject.VideoObject;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.CreativeWork.MediaObject.VideoObject.VideoObjectSnapshot;
public class VideoObjectSnapshot : VideoObject
{
    public override string TypeName { get; protected set; } = nameof(VideoObjectSnapshot);
}
