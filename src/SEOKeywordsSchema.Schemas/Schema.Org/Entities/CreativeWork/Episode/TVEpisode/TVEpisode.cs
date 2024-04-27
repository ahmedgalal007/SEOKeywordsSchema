using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.CreativeWork.Episode;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.CreativeWork.Episode.TVEpisode;
public class TVEpisode : Episode
{
    public override string TypeName { get; protected set; } = nameof(TVEpisode);
}
