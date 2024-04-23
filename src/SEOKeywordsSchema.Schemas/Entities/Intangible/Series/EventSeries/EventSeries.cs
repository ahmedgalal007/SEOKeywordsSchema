using SEOKeywordsSchema.Schemas.Entities.CreativeWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOKeywordsSchema.Schemas.Entities.Intangibles.Serieses;
public class EventSeries : Series
{
    public override string TypeName { get; protected set; } = nameof(EventSeries);
}
