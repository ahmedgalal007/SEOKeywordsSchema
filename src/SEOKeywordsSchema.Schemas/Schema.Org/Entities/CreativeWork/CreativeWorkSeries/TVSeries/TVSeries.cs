using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.CreativeWork.CreativeWorkSeries;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.CreativeWork.CreativeWorkSeries.TVSeries;
public class TVSeries : CreativeWorkSeries
{
    public override string TypeName { get; protected set; } = nameof(TVSeries);
}
