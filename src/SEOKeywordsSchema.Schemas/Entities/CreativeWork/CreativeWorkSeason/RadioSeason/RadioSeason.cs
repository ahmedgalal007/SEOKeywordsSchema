using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOKeywordsSchema.Schemas.Entities.CreativeWorks.CreativeWorkSeasons;
public class RadioSeason : CreativeWorkSeason
{
    public override string TypeName { get; protected set; } = nameof(RadioSeason);
}
