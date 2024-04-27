
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.CreativeWork.CreativeWorkSeries;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.CreativeWork.CreativeWorkSeries.RadioSeries;
public class RadioSeries : CreativeWorkSeries
{
    public override string TypeName { get; protected set; } = nameof(RadioSeries);
}
