using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOKeywordsSchema.Schemas.Entities.CreativeWorks.CreativeWorkSerieses;
public class VideoGameSeries : CreativeWorkSeries
{
    public override string TypeName { get; protected set; } = nameof(VideoGameSeries);
}
