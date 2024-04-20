using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOKeywordsSchema.Schemas.Things.CreativeWorks.MediaObjects;
public class VideoObject : MediaObject
{
    public override string TypeName { get; protected set; } = nameof(VideoObject);
}
