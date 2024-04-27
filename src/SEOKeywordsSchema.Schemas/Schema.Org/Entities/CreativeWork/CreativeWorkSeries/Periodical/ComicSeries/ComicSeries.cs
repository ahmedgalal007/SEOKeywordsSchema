using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.CreativeWork.CreativeWorkSeries.Periodical;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.CreativeWork.CreativeWorkSeries.Periodical.ComicSeries;
public class ComicSeries : Periodical
{
    public override string TypeName { get; protected set; } = nameof(ComicSeries);
}
