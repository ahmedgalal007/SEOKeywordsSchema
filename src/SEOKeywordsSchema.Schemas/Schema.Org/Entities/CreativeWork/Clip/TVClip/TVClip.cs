using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.CreativeWork.Clip;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.CreativeWork.Clip.TVClip;
public class TVClip : Clip
{
    public override string TypeName { get; protected set; } = nameof(TVClip);
}
