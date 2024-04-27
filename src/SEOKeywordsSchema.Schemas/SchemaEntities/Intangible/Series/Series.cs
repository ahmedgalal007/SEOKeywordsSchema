using SEOKeywordsSchema.Schemas.SchemaEntities.CreativeWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOKeywordsSchema.Schemas.SchemaEntities.Intangibles;
public class Series : Intangible
{
    public override string TypeName { get; protected set; } = nameof(Series);
}


// TODO CreativeWorkSeries
// TODO EventSeries