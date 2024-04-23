using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOKeywordsSchema.Schemas.Entities.CreativeWorks.CreativeWorkSerieses.Periodicals;
public class ComicSeries : Periodical
{
    public override string TypeName { get; protected set; } = nameof(ComicSeries);
}
