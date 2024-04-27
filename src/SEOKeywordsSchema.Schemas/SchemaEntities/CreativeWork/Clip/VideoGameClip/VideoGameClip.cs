using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOKeywordsSchema.Schemas.SchemaEntities.CreativeWorks.Clips;
public class VideoGameClip : Clip
{
    public override string TypeName { get; protected set; } = nameof(VideoGameClip);
}
