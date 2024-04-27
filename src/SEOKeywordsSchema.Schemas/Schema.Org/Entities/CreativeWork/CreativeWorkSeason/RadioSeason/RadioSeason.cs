using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.CreativeWork.CreativeWorkSeason;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.CreativeWork.CreativeWorkSeason.RadioSeason;
public class RadioSeason : CreativeWorkSeason
{
    public override string TypeName { get; protected set; } = nameof(RadioSeason);
}
