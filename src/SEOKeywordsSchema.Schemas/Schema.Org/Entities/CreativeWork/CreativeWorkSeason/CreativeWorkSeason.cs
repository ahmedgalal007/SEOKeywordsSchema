using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.CreativeWork;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.CreativeWork.CreativeWorkSeason;
public class CreativeWorkSeason : CreativeWork
{
    public override string TypeName { get; protected set; } = nameof(CreativeWorkSeason);
}


// TODO PodcastSeason
// TODO RadioSeason
// TODO TVSeason