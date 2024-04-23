using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOKeywordsSchema.Schemas.Entities.CreativeWorks;
public class CreativeWorkSeries : CreativeWork
{
    public override string TypeName { get; protected set; } = nameof(CreativeWorkSeries);
}



// TODO BookSeries
// TODO MovieSeries
// TODO Periodical
// TODO PodcastSeries
// TODO RadioSeries
// TODO TVSeries
// TODO VideoGameSeries