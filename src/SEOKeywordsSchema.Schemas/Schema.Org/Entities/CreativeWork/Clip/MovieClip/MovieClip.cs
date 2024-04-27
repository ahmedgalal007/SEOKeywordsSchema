using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.CreativeWork.Clip;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.CreativeWork.Clip.MovieClip;
public class MovieClip : Clip
{
    public override string TypeName { get; protected set; } = nameof(MovieClip);
}
