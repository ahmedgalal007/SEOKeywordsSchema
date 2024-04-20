using SEOKeywordsSchema.Schemas.Things.CreativeWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOKeywordsSchema.Schemas.Things.Intangibles.Serieses;
public class CreativeWorkSeries : Series
{
    public override string TypeName { get; protected set; } = nameof(CreativeWorkSeries);
}
